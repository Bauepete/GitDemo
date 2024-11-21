using CarRace;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarRace.Tests;

[TestClass]
[TestSubject(typeof(RaceBuilder))]
public class RaceBuilderTest
{
    [TestMethod]
    [Ignore]
    public void ItShouldProvideARaceController_GivenATrackAndAtLeastOneCarIsAdded()
    {
        var trackComposer = new TrackComposer();
        trackComposer.ComposeFrom(new[] {(50, 100), (800, 300)});
        
        var racerBuilder = new RaceBuilder
        {
            Track = trackComposer.Track
        };
        racerBuilder.AddCar(1, "Red");
        
        var raceController = racerBuilder.RaceController;
        
        Assert.IsNotNull(raceController);
    }

    [TestMethod]
    public void ItShouldProvideNoRaceController_GivenTrackIsMissing()
    {
        var trackComposer = new TrackComposer();
        trackComposer.ComposeFrom(new[] {(50, 100), (800, 300)});
        var raceBuilder = new RaceBuilder();
        var raceController = raceBuilder.RaceController;
        
        Assert.IsNull(raceController);
    }

    [TestMethod]
    public void ItShouldProvideNoRaceController_GivenNoCarIsAdded()
    {
        var trackComposer = new TrackComposer();
        trackComposer.ComposeFrom(new[] {(50, 100), (800, 300)});
        var raceBuilder = new RaceBuilder();
        raceBuilder.Track = trackComposer.Track;
        
        Assert.IsNull(raceBuilder.RaceController);
    }
    
    [TestMethod]
    [Ignore]
    public void ItShouldAddACarToTheTrack_GivenATrackIsDefined()
    {
        var trackComposer = new TrackComposer();
        trackComposer.ComposeFrom(new[] {(50, 100), (800, 300)});
        
        var raceBuilder = new RaceBuilder
        {
            Track = trackComposer.Track
        };
        raceBuilder.AddCar(5, "Red");
        var raceController = raceBuilder.RaceController;
        var raceStatus = raceController?.RaceStatusSortedBy(RaceStatusSortOrder.Rank);
        
        //Assert.AreEqual(raceStatus?[0].CurrentPosition.Section, raceController?.Track.StartSection);
    }
}