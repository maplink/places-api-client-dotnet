﻿using Maplink.Webservices.Places.Client.Builders;
using Maplink.Webservices.Places.Client.Entities;
using Maplink.Webservices.Places.Client.Wrappers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SharpTestsEx;

namespace Maplink.Webservices.Client.Places.UnitTests.Builders
{
    [TestClass]
    public class UriBuilderTest
    {
        private IUriBuilder _builder;
        private Mock<IConfigurationWrapper> _mockedConfiguration;
        private RadiusSearchRequest _aRadiusRequest;

        [TestInitialize]
        public void SetUp()
        {
            _aRadiusRequest = new RadiusSearchRequest
            {
                Radius = 3,
                Latitude = -32.345,
                Longitude = 12.325263
            };
            
            _mockedConfiguration = new Mock<IConfigurationWrapper>();
            _mockedConfiguration
                .Setup(it => it.ValueFor(It.IsAny<string>()))
                .Returns("base-uri");

            _builder = new UriBuilder(_mockedConfiguration.Object);      
        }

        [TestMethod]
        public void ShouldCreateForRadiusSearch()
        {
            const string expectedUri = "base-uri/places/byradius/?radius=3&latitude=-32.345&longitude=12.325263";

            _builder.ForRadiusSearch(_aRadiusRequest).Should().Be.EqualTo(expectedUri);
        }

        [TestMethod]
        public void ShouldGetBaseUriFromConfigurationWhenCreatingForRadiusSearch()
        {
            _builder.ForRadiusSearch(_aRadiusRequest);

            _mockedConfiguration
                .Verify(it => it.ValueFor("Maplink.Webservices.Places.BaseUri"), Times.Once());
        }
    }
}
