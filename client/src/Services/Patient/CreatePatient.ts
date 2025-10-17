import axios from "axios";

const CreatePatient = async(data)=>{
  const baseUrl = import.meta.env.VITE_API_BASE_URL;
  const url = `${baseUrl}/patients`
  try{
    return await axios.post(url, data);
  }
  catch (e){
    console.error("Error adding patient " + e);
    return;
  }
}

export default CreatePatient;
