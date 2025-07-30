export default function Header() {
  return (
    <header className="flex justify-between">
      <h1 className="text-lg font-bold ">Endryw Lucas</h1>
      <nav>
        <ul className="flex gap-4">
          <li><a href="#home">Home</a></li>
          <li><a href="#sobre">Sobre</a></li>
          <li><a href="#projetos">Projetos</a></li>
        </ul>
      </nav>
    </header>
  );
}