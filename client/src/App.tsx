import { Outlet } from "react-router";
import Navbar from "./Components/Navbar.tsx";

function App() {
  return (
    <>
      <Navbar />
      <Outlet />

    </>
  )
}

export default App
