namespace CarRace;

public class Track
{
    private Section? _startSection;
    private Section? _endSection;
    public LockedSection? StartSection => _startSection?.Locked();

    public int Length
    {
        get
        {
            var currentSection = _startSection;
            var length = 0;
            while (currentSection != null)
            {
                length += currentSection.Length;
                currentSection = currentSection.NextSection;
            }
            return length;
        }
    }

    public void Add(Section section)
    {
        if (_startSection == null)
        {
            _startSection = section;
        }
        else
        {
            section.ConnectMeAfter(_endSection);
        }
        _endSection = section;
    }
}