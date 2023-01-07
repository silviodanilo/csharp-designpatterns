namespace Decorator
{
    public class PlaySoundDvdDecorator : PlaySoundDecorator
    {
        public PlaySoundDvdDecorator(PlaySoundEquipment playSoundEquipment) : base(playSoundEquipment) { }

        private void DecodeDvdFormat()
        {
            // Decode Dvd format
        }
        public override void PlaySound()
        {
            System.Console.WriteLine("Added play Dvd capability");
            this.DecodeDvdFormat();
            base.PlaySound();
        }

    }
}