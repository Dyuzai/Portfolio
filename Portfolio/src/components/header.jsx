export default function Header() {
  return (
    <header className="flex w-screen justify-between items-center bg-black fixed p-5 pl-8 pr-8">
      <h1 className="text-3xl font-bold text-white ">Endryw L.</h1>
      <nav>
        <ul className="flex gap-4 text-xl ">
          <li><a href="#home">Home</a></li>
          <li><a href="#sobre">Sobre</a></li>
          <li><a href="#projetos">Projetos</a></li>
        </ul>
      </nav>
    </header>
  );
}