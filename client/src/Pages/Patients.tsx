import  { useEffect, useState } from 'react';
import type { Patient } from "../Types/Patient.ts";
import FetchAllPatients from "../Services/Patient/FetchAllPatients.ts";
import Table from "../Components/Table.tsx";

const Patients = () => {
  const [patients, setPatients] = useState<Patient[]>([]);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    const getPatients = async () => {
      try {
        const data = await FetchAllPatients();
        setPatients(data);
      } catch (error) {
        console.error("Error fetching patients:", error);
      } finally {
        setLoading(false);
      }
    }
    getPatients().then();
  }, []);

  if (loading) {
    return (
      <div className="flex justify-center items-center h-64">
        <div className="text-green-600 text-lg">Loading patients...</div>
      </div>
    );
  }

  return (
    <div className="p-6">
      <h2 className="text-2xl font-bold text-green-800 mb-4">Patient Records</h2>

      <div className="overflow-x-auto rounded-lg shadow-md">
       <Table headers={["Id","First Name", "Last Name", "Age", "Sex", "Phone Number", "Email"]}
         rows={patients.map((patient) => ([
           patient.id,
           patient.firstName,
            patient.lastName,
            patient.age,
           patient.sex,
           patient.phoneNumber,
            patient.email
         ]))}
       />

      </div>
    </div>
  );
};

export default Patients;
