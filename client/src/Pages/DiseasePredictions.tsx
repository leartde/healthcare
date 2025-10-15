import React, { useEffect, useState } from 'react';
import type { HeartDiseasePrediction } from "../Types/HeartDiseasePrediction.ts";
import FetchAllPredictions from "../Services/HeartDiseasePrediction/FetchAllPredictions.ts";
import Table from "../Components/Table.tsx";

const DiseasePredictions = () => {
  const [predictions, setPredictions] = useState<HeartDiseasePrediction[]>([])
  useEffect(() => {
    const getPredictions = async()=>{
       const data = await FetchAllPredictions();
       setPredictions(data);
    }
    getPredictions().then();
  },[]);
  return (
    <div className="p-6">
      <h2 className="text-2xl font-bold text-green-800 mb-4">Heart Disease Prediction</h2>
      <div className="overflow-x-auto font-bold text-green-800 mb-4">
      <Table
       headers={["Id", "Patient Name","Prediction Result", "Disease Probability", "Predicted At",""]}
       rows={predictions.map((pred) => ([
         pred.id,
         pred.clinicalRecord.patient.firstName + " " + pred.clinicalRecord.patient.lastName,
         pred.label ? "Positive" : "Negative",
         pred.probability.toFixed(2),
          new Date(pred.timestamp).toLocaleString(),
         <p className="text-gray-900"> Click here to view full details </p>
       ]))}
      />
      </div>

    </div>
  );
};

export default DiseasePredictions;
