using Decorator;

Radio radio = new();

PlaySoundDecorator playSoundDecorator = new PlaySoundDecorator(radio);
playSoundDecorator.PlaySound();

System.Console.WriteLine();

PlaySoundDvdDecorator playSoundDvdDecorator = new PlaySoundDvdDecorator( radio );
playSoundDvdDecorator.PlaySound();

System.Console.WriteLine();

PlaySoundCdDecorator playSoundCdDvdDecorator = new PlaySoundCdDecorator( playSoundDvdDecorator);
playSoundCdDvdDecorator.PlaySound();
