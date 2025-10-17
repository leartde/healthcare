import axios from "axios";

const DeleteClinicalRecord = async(id: number) =>{
  const baseUrl = import.meta.env.VITE_API_BASE_URL;
  const url = `${baseUrl}/clinicalRecords/${id}`;
  try{
    const response = await axios.delete(url);
    if(response.status === 200) return true;
  }
  catch (error){
    console.error("Error deleting clinical record:", error);
    return false;
  }
}

export default DeleteClinicalRecord;
