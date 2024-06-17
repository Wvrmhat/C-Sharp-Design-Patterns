using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Amplifier TheAmplifier = new Amplifier();               //Receiver
            UniversalRemote TheRemote = new UniversalRemote();      //Invoker

            TheRemote.PowerCom = new PowerOnCommand(TheAmplifier);
            TheRemote.MuteCom = new MuteCommand(TheAmplifier);
            TheRemote.VolumeUpCom = new VolumeUpCommand(TheAmplifier);
            TheRemote.VolumeDownCom = new VolumeDownCommand(TheAmplifier);
            TheRemote.Source1Com = new SetSourceCommand(TheAmplifier, "DSTV");
            TheRemote.Source2Com = new SetSourceCommand(TheAmplifier, "Xbox Series X");
            TheRemote.Source3Com = new SetSourceCommand(TheAmplifier, "Apple TV");


            List<CommandBase> Commands = new List<CommandBase>();       //Macro command, which is a series of commands;
            Commands.Add(new SetSourceCommand(TheAmplifier, "DSTV"));
            Commands.Add(new VolumeUpCommand(TheAmplifier));
            Commands.Add(new VolumeUpCommand(TheAmplifier));
            Commands.Add(new VolumeUpCommand(TheAmplifier));
            TheRemote.MacroCom = new MacroCommand(Commands);

            TheRemote.Power();
            TheRemote.SetSource2();

            for(int i = 0; i < 10; ++i)
            {
                TheRemote.VolumeUp();
            }

            TheRemote.Mute();
            TheRemote.SetSource3();
            TheRemote.Mute();
            TheRemote.Macro();
            TheRemote.Power();

            Console.ReadLine();
        }
    }
}
