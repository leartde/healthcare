import  { useEffect, useState } from 'react';
import type { Doctor } from "../Types/Doctor.ts";
import FetchAllDoctors from "../Services/Doctor/FetchAllDoctors.ts";
import Table from "../Components/Table.tsx";

const Doctors = () => {
  const [doctors, setDoctors] = useState<Doctor[]>([]);
  useEffect(() => {
    const getDoctors = async () => {
      const res = await FetchAllDoctors();
      setDoctors(res);
    }
    getDoctors().then()
  },[]);
  return (
    <>
      <h2 className="text-2xl font-bold text-green-800 mb-4">Doctor Records</h2>

      <div className="overflow-x-auto rounded-lg shadow-md">
        <Table headers={["Id", "First Name", "Last Name"]}
               rows={doctors.map((doctor) => ([
                 doctor.id,
                 doctor.firstName,
                doctor.lastName
               ]))}
        />

      </div>
    </>
  );
};

export default Doctors;
