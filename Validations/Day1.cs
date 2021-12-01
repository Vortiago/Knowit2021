using NUnit.Framework;
using FluentAssertions;
using System;
using System.Collections.Generic;

namespace Validations;

public class Day1Validations
{
    [TestCase("en", 1)]
    [TestCase("to", 2)]
    [TestCase("tre", 3)]
    [TestCase("fire", 4)]
    [TestCase("fem", 5)]
    [TestCase("seks", 6)]
    [TestCase("sju", 7)]
    [TestCase("åtte", 8)]
    [TestCase("ni", 9)]
    [TestCase("ti", 10)]
    [TestCase("elleve", 11)]
    [TestCase("tolv", 12)]
    [TestCase("tretten", 13)]
    [TestCase("fjorten", 14)]
    [TestCase("femten", 15)]
    [TestCase("seksten", 16)]
    [TestCase("sytten", 17)]
    [TestCase("atten", 18)]
    [TestCase("nitten", 19)]
    [TestCase("tjue", 20)]
    [TestCase("tretti", 30)]
    [TestCase("førti", 40)]
    [TestCase("femti", 50)]
    public void ValidateWordParsing(string word, Int64 output)
    {
        var day = new Days.Day1(word);
        day.ParseWord().Should().Be(output);
    }

    [TestCase("entotrefirefem", new Int64[]{1, 2, 3, 4, 5})]
    [TestCase("sjufirenitrettentrettitretrettitre", new Int64[]{7, 4, 9, 13, 30, 3, 30, 3})]
    public void ValidateBookParsing(string book, IEnumerable<Int64> result){
        var day = new Days.Day1(book);
        day.ParseBook().Should().BeEquivalentTo(result);
    }
}