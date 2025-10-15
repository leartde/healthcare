import axios from "axios";

const FetchAllAppointments = async () =>{
  const baseUrl = import.meta.env.VITE_API_BASE_URL;
  const url = `${baseUrl}/appointments`;
  try{
    const response = await axios.get(url);
    return response.data;
  }
  catch(error){
    console.error("Error fetching appointments:", error);
    return null;
  }
}
export default FetchAllAppointments;
