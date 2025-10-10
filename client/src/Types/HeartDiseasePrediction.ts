import type { ClinicalRecord } from "./ClinicalRecord.ts";

export type HeartDiseasePrediction = {
  id: number;
  clinicalRecord: ClinicalRecord;
  label: boolean;
  probability: number;
  timestamp: string;
}
