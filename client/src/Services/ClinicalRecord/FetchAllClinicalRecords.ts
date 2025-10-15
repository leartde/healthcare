import axios from "axios";

const FetchAllClinicalRecords = async()=>{
  const baseUrl = import.meta.env.VITE_API_BASE_URL;
  const url = `${baseUrl}/clinicalRecords`;
  try{
    const response = await axios(url);
    return response.data;
  }
  catch(error){
    console.error("Error fetching clinical records:", error);
    return [];
  }
}

export default FetchAllClinicalRecords;
