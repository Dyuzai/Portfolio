import Aristoteles from '../public/aristoteles.jpeg';
import Figma from '../public/figma.png';
import Js from '../public/js.png';
import Csharp from '../public/csharp.png';
import Node from '../public/node.png';
import Php from '../public/php.png';

export default function Home() {
    return (
        <div className="flex w-screen h-[800px] pt-[76px] bg-black text-white">
            <div className="flex flex-col w-[50%] justify-center pl-10 border-r border-gray-700">
                <h1 className="text-5xl font-bold translate-y-[-80px]">Desenvolvedor <span className='text-red-600'>Full-stack</span></h1>
                <p className="text-xl translate-y-[-80px]">Desenvolvedor Fullstack que <span className='underline'>transforma ideias em produtos reais.</span></p>
                <div className='flex flex-col text-lg translate-y-[-40px]'>
                    <h2 className='font-semibold'>Tecnologias que eu utilizo:</h2>
                    <div className='flex gap-5 items-center '>
                        <img src={Figma} title='Figma' className='w-[50px] h-[50px] hover:brightness-125 hover:drop-shadow-lg transition' alt="Figma" />
                        <img src={Js} title='Javascript' className='w-[50px] h-[50px] hover:brightness-125 hover:drop-shadow-lg transition' alt="JavaScript" />
                        <img src={Csharp} title='C Sharp' className='w-[50px] h-[50px] hover:brightness-125 hover:drop-shadow-lg transition' alt="Csharp" />
                        <img src={Node} title='Node JS' className='w-[70px] h-[70px] hover:brightness-125 hover:drop-shadow-lg transition' alt="NodeJS" />
                        <img src={Php} title='Php' className='w-[70px] h-[70px] hover:brightness-125 hover:drop-shadow-lg transition' alt="Php" />

                    </div>
                </div>
            </div>
            <div className="w-[50%] flex justify-center items-center overflow-hidden">
                <div className="flex w-[500px] h-[500px] bg-red-600 rounded-full justify-center items-center text-black translate-y-[-80px]">
                    <img src={Aristoteles} alt="Aristoteles" className="w-full h-full rounded-full object-cover object-[center_-280px] translate-y-2" />
                </div>
            </div>
        </div>

    )
}