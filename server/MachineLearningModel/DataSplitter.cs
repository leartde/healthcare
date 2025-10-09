using Microsoft.ML;
using MachineLearningModel.DataEntities;
using static Microsoft.ML.DataOperationsCatalog;

namespace MachineLearningModel;

public static class DataSplitter
{
  public static TrainTestData LoadData(this MLContext context, string dataPath, double testSplit)
  {
    IDataView dataView = context.Data.LoadFromTextFile<HeartDiseaseData>(
      path: dataPath,
      hasHeader: true,
      separatorChar: ','
    );
    return context.Data.TrainTestSplit(
      data: dataView,
      testFraction: testSplit
    );
  }

}
