namespace Rennspiel
{
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
            Geschwindigkeit = motor.Beschleunigen(Geschwindigkeit);
        }

        public void Bremsen()
        {
            Geschwindigkeit = bremse.Bremsen(Geschwindigkeit);
        }

        public void MusikAbspielen()
        {
            audioSystem.MusikAbspielen();
        }
    }


}
