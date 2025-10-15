import axios from "axios";

const FetchAllPatients = async () =>{
  const baseUrl = import.meta.env.VITE_API_BASE_URL;
  const url = `${baseUrl}/patients`;
  try{
    const response = await axios.get(url);
    return response.data;
  }
  catch(error){
    console.error("Error fetching patients:", error);
    return null;
  }
}

export default FetchAllPatients;
