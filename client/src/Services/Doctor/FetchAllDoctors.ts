import axios from "axios";

const FetchAllDoctors =  async () => {
  const baseUrl = import.meta.env.VITE_API_BASE_URL;
  const url = `${baseUrl}/doctors`;
  try{
    const response = await axios.get(url);
    return response.data;
  }
  catch(error){
    console.error("Error fetching doctors:", error);
    return null;
  }
}

export default FetchAllDoctors;
