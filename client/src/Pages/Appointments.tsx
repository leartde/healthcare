import React, { useEffect, useState } from 'react';
import type { Appointment } from "../Types/Appointment.ts";
import FetchAllAppointments from "../Services/Appointment/FetchAllAppointments.ts";
import Table from "../Components/Table.tsx";

const Appointments = () => {
  const [appointment, setAppointments] = useState<Appointment[]>([])
  useEffect(() => {
    const getAppointments = async()=>{
       const data = await FetchAllAppointments();
       setAppointments(data);
    }
    getAppointments().then();
  }, []);
  return (
    <div className="p-6">
      <h2 className="text-2xl font-bold text-green-800 mb-4">Appointments</h2>
      <div className="overflow-x-auto rounded-lg text-green-800 mb-4">
        <Table headers={["Id", "Patient Name", "Doctor Name", "Date"]}
        rows={appointment.map((app) => ([
          app.id,
          `${app.patient.firstName} ${app.patient.lastName}`,
          `${app.doctor.firstName} ${app.doctor.lastName}`,
          new Date(app.time).toLocaleTimeString([],{
            year: 'numeric', month: '2-digit', day: '2-digit',
            hour: '2-digit', minute: '2-digit'
          })
        ]))}
        />

      </div>

    </div>
  );
};

export default Appointments;
