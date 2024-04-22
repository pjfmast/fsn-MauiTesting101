namespace UnitTestProject;

public class UnitTestsForMainViewModel
{
    [Fact]
    public void IncrementcountOnCounterClicked()
    {
        // Arrange
        var sut = new MauiTesting101.ViewModels.MainPageViewModel();
        // Act
        sut.CounterClickedCommand.Execute(null);
        // Assert
        Assert.Equal(1, sut.Count);
    }
}