﻿namespace CodeChallenge.AdventOfCode.AdventOfCode2022.Tests.Day04;

using CodeChallenge.AdventOfCode.AdventOfCode2022.Day04;
using CodeChallenge.Core.IO;

public class Solution02Tests
{
    private readonly Solution02 _solution;
    public Solution02Tests()
    {
        var inputProviderMock = new Mock<IInputProvider<AdventOfCodeChallengeSelection, IEnumerable<string>>>();
        _solution = new Solution02(inputProviderMock.Object);
    }

    [Fact]
    public async Task ComputeSolutionAsync_WithSampleInput_ProducesSampleOutput()
    {
        // Arrange
        var input = new List<string>
        {
            "2-4,6-8",
            "2-3,4-5",
            "5-7,7-9",
            "2-8,3-7",
            "6-6,4-6",
            "2-6,4-8"
        };

        // Act
        var result = await _solution.ComputeSolutionAsync(input).ConfigureAwait(false);

        // Assert
        Assert.Equal(4, result);
    }
}