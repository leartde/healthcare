using Microsoft.ML;

namespace MachineLearningModel.Trainers;

public interface ITrainer
{
  string Name { get; }
  ITransformer BuildAndTrainModel(MLContext context, IDataView splitTrainSet);
}
