using Microsoft.ML.Data;

namespace MachineLearningModel.LoggerService;

public interface ITrainingLogger
{
  void LogInfo(string message);
  void LogMetrics(CalibratedBinaryClassificationMetrics metrics, TimeSpan trainingTime);
  void LogError(string message, Exception ex = null!);
}
