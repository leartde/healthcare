import type { Doctor } from "./Doctor.ts";
import type { Patient } from "./Patient.ts";

export type Appointment = {
  id: number;
  doctor: Doctor;
  patient: Patient;
  time: string;
}
