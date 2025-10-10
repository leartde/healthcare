using Microsoft.ML.Data;

namespace MachineLearningModel.LoggerService;

public class FileTrainingLogger : ITrainingLogger
{
  private readonly string _logsFilePath;
  private readonly string _trainer;
  public FileTrainingLogger(string trainer)
  {
    _trainer = trainer;
    string? projectRoot = Directory.GetParent(Directory.GetCurrentDirectory())?
      .Parent?
      .Parent?
      .FullName;
    
    if (string.IsNullOrEmpty(projectRoot))
    {
      projectRoot = Directory.GetCurrentDirectory(); 
    }
    
    var logsPath = Path.Combine(projectRoot, "logs", "evaluation_metrics");
    Directory.CreateDirectory(logsPath);
    
    _logsFilePath = Path.Combine(logsPath, $"training-{DateTime.Now:yyyyMMdd-HHmmss}.txt");
  }
  public void LogInfo(string message)
  {
    var logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [INFO] {message}";
    File.AppendAllLines(_logsFilePath, new[] { logEntry });
    Console.WriteLine(logEntry);
  }

  public void LogMetrics(CalibratedBinaryClassificationMetrics metrics, TimeSpan trainingTime)
  {
    var lines = new[]
    {
      $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [METRICS] {_trainer} Results:",
      $"  Training Time: {trainingTime.TotalSeconds:F2}s",
      $"  Accuracy: {metrics.Accuracy:P2}",
      $"  AUC: {metrics.AreaUnderRocCurve:P2}",
      $"  F1-Score: {metrics.F1Score:P2}",
      $"  Positive Precision: {metrics.PositivePrecision:P2}",
      $"  Negative Precision: {metrics.NegativePrecision:P2}",

      $" Positive Recall: {metrics.PositiveRecall:P2}",
      $" Negative Recall: {metrics.PositiveRecall:P2}",
      new string('-', 50)
    };
        
    // File.AppendAllLines(_logsFilePath, lines);
    foreach (var line in lines) Console.WriteLine(line);
  }

  public void LogError(string message, Exception ex = null!)
  {
    var logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [ERROR] {message} {ex.Message}";
    File.AppendAllLines(_logsFilePath, new[] { logEntry });
    Console.WriteLine(logEntry);
  }
}
