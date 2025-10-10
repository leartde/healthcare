import { Link } from "react-router";

const Navbar = () => {
  return (
    <nav className="sticky z-10 bg-green-500/90 shadow-md top-0 flex justify-between gap-4 p-4">
           <ul className="flex text-md space-x-12 text-white">
             <Link to="#">Patients</Link>
             <Link to="#">Doctors</Link>
             <Link to="#">Clinical Records</Link>
             <Link to="#">Appointments</Link>
           </ul>
    </nav>
  );
};

export default Navbar;
