namespace Decorator
{
    public class PlaySoundCdDecorator : PlaySoundDecorator
    {
        public PlaySoundCdDecorator(PlaySoundEquipment playSoundEquipment) : base(playSoundEquipment) { }
        
        private void DecodeCdFormat()
        {
            // Decode Cd format
        }
        public override void PlaySound()
        {
            System.Console.WriteLine("Added play Cd capability");
            this.DecodeCdFormat();
            base.PlaySound();
        }
    }
}