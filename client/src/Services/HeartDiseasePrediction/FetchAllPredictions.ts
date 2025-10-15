import axios from "axios";

const FetchAllPredictions = async() =>{
  const baseUrl = import.meta.env.VITE_API_BASE_URL;
  const url = `${baseUrl}/predictions`;
  try{
    const response = await axios.get(url);
    return response.data;
  }
  catch(error){
    console.error("Error fetching heart disease predictions:", error);
    return null;
  }
}

export default FetchAllPredictions;
