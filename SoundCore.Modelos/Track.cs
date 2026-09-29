namespace SoundCore.Modelos
{
    public record Track(int Id, string Title, string Artist, int Bpm, int SecondsDuration)
    {
        public override string ToString() =>
            $"[ID: {Id:D3}] {Title} - {Artist} | {Bpm} BPM ({SecondsDuration}s)";
    }
}
