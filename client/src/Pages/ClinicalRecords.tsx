import React, { useEffect, useState } from 'react';
import Table from "../Components/Table.tsx";
import type { ClinicalRecord } from "../Types/ClinicalRecord.ts";
import FetchAllClinicalRecords from "../Services/ClinicalRecord/FetchAllClinicalRecords.ts";

const ClinicalRecords = () => {
  const [clinicalRecords, setClinicalRecords] = useState<ClinicalRecord[]>([]);
  useEffect(() => {
    const getClinicalRecords = async()=>{
      const data = await FetchAllClinicalRecords();
      setClinicalRecords(data);
    }
    getClinicalRecords().then();
  }, []);
  return (
    <div className="p-6">
      <h2 className="text-2xl font-bold text-green-800 mb-4">Clinical Records</h2>
      <div className="overflow-x-auto rounded-lg text-green-800 mb-4">
     <Table
      headers={['Id','Patient Name', 'Recorded By Doctor', 'Recorded Date', 'Patient Sex', 'Chest Pain Type', 'Resting Blood Pressure', 'Cholesterol Total', 'Fasting Blood Sugar', 'Rest ECG', 'Maximum Heart Rate', 'Exercise Induced Angina', 'Old Peak', 'Slope', 'Major Vessels Colored', 'Thalassemia']}
      rows={clinicalRecords.map((record) => ([
        record.id,
        `${record.patient.firstName} ${record.patient.lastName}`,
        `${record.recordedByDoctor.firstName} ${record.recordedByDoctor.lastName}`,
        new Date(record.recordedDate).toLocaleDateString(),
        record.patient.sex,
        record.chestPainType,
        record.restingBloodPressure,
        record.cholesterolTotal,
        record.fastingBloodSugar ? 'True' : 'False',
        record.restEcg,
        record.maximumHeartRate,
        record.exerciseInducedAngina ? 'True' : 'False',
        record.oldPeak,
        record.slope,
        record.majorVesselsColored,
        record.thalassemia
      ]))}
     />

      </div>


      </div>
  );
};

export default ClinicalRecords;
