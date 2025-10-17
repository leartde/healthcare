import type { Patient } from "./Patient.ts";
import type { Doctor } from "./Doctor.ts";

export type ClinicalRecord = {
  id: number;
  patient: Patient;
  recordedByDoctor: Doctor;
  recordedDate : string;
  chestPainType: "Typical Angina" | "Atypical Angina" | "Non-Anginal Pain" | "Asymptomatic";
  restingBloodPressure: number;
  cholesterolTotal: number;
  fastingBloodSugar: "Greater than or equal to 120 mg/dl" | "Less than 120 mg/dl";
  restEcg: "Normal" | "Having ST-T wave abnormality" | "Showing probable or definite left ventricular hypertrophy by Estes' criteria";
  maximumHeartRate: number;
  exerciseInducedAngina: boolean;
  oldPeak : number;
  slope: "Upsloping" | "Flat" | "Downsloping";
  majorVesselsColored: 0 | 1 | 2 | 3;
  thalassemia: "Error" | "Normal" | "Fixed Defect" | "Reversible Defect";
  probability: number;
  label: boolean;
}
