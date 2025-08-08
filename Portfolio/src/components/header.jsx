export default function Header() {
  return (
    <header className="flex w-screen justify-between items-center bg-black fixed p-5 pl-8 pr-8 z-50 border-b border-gray-600">
      <h1 className="text-3xl font-bold text-white ">Endryw L.</h1>
      <nav>
        <ul className="flex gap-6 text-xl pr-4 ">
          <li><a href="#home" className="hover:text-gray-400" >Home</a></li>
          <li><a href="#sobre" className="hover:text-gray-400">Sobre</a></li>
          <li><a href="#projetos" className="hover:text-gray-400">Projetos</a></li>
        </ul>
      </nav>
    </header>
  );
}