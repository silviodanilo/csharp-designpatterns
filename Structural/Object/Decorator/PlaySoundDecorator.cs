namespace Decorator
{
    public class PlaySoundDecorator : PlaySoundEquipment
    {
        private PlaySoundEquipment PlaySoundEquipment;

        public PlaySoundDecorator( PlaySoundEquipment playSoundEquipment )
        {
            PlaySoundEquipment = playSoundEquipment;
        }

        public override void PlaySound()
        {
            this.PlaySoundEquipment.PlaySound();
        }
    }
}