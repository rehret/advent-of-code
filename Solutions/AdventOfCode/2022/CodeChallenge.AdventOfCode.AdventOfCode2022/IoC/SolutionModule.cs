﻿namespace CodeChallenge.AdventOfCode.AdventOfCode2022.IoC;

using System.Reflection;

using CodeChallenge.IoC;

internal class SolutionModule : SolutionAutoRegisteringModule<AdventOfCodeSolutionAttribute>
{
    protected override Assembly GetAssembly() => Assembly.GetExecutingAssembly();
}