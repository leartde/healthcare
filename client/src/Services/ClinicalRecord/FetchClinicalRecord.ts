import axios from "axios";

const FetchClinicalRecord = async(id: number)=>{
  const baseUrl = import.meta.env.VITE_API_BASE_URL;
  const url = `${baseUrl}/clinicalRecords/${id}`;
  try{
    const response = await axios.get(url);
    if(response.status === 200)return response.data;
  }
  catch (error){
    console.error("Error fetching clinical record:", error);
    return
  }
}

export default FetchClinicalRecord;
