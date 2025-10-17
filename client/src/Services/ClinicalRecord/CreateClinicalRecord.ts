import axios from "axios";

const CreateClinicalRecord = async(data)=>{
  const baseUrl = import.meta.env.VITE_API_BASE_URL;
  const url = `${baseUrl}/clinicalRecords`;
  try{
    return await axios.post(url, data);
  }
  catch (e){
    console.error("Error creating clinical record:", e);
    return null;
  }
  }
export default CreateClinicalRecord;
