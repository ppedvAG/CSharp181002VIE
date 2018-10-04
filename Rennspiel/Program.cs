using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rennspiel
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }


    interface IMotor
    {
        int MaximalGeschwindigkeit { get; } // Hardcoden in der Klasse
        int Beschleunigen(int aktuelleGeschwindigkeit);
    }

    interface IBremse
    {
        int Bremsen(int aktuelleGeschwindigkeit);
    }

    interface IAudioSystem
    {
        void MusikAbspielen();
    }

    class Fahrzeug
    {
        public Fahrzeug(IMotor motor, IBremse bremse, IAudioSystem audioSystem)
        {
            this.motor = motor;
            this.bremse = bremse;
            this.audioSystem = audioSystem;
        }

        private IMotor motor;
        private IBremse bremse;
        private IAudioSystem audioSystem;
        public int Geschwindigkeit { get; private set; }

        public void Beschleunigen()
        {
            motor.Beschleunigen(Geschwindigkeit);
        }

        public void Bremsen()
        {
            bremse.Bremsen(Geschwindigkeit);
        }

        public void MusikAbspielen()
        {
            audioSystem.MusikAbspielen();
        }
    }


}
