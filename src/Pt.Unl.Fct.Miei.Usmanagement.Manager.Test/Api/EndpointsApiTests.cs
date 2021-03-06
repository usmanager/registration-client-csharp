/* 
 * Registration-client-api
 *
 * Interage com o registration server (eureka) para registar esta instância ou obter servidores com o qual pode comunicar
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Pt.Unl.Fct.Miei.Usmanagement.Manager.Client;
using Pt.Unl.Fct.Miei.Usmanagement.Manager.Api;
using Pt.Unl.Fct.Miei.Usmanagement.Manager.Model;

namespace Pt.Unl.Fct.Miei.Usmanagement.Manager.Test
{
    /// <summary>
    ///  Class for testing EndpointsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class EndpointsApiTests
    {
        private EndpointsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EndpointsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EndpointsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' EndpointsApi
            //Assert.IsInstanceOfType(typeof(EndpointsApi), instance, "instance is a EndpointsApi");
        }

        
        /// <summary>
        /// Test GetServiceEndpoint
        /// </summary>
        [Test]
        public void GetServiceEndpointTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //var response = instance.GetServiceEndpoint(service);
            //Assert.IsInstanceOf<Endpoint> (response, "response is Endpoint");
        }
        
        /// <summary>
        /// Test GetServiceEndpoints
        /// </summary>
        [Test]
        public void GetServiceEndpointsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //var response = instance.GetServiceEndpoints(service);
            //Assert.IsInstanceOf<List<Endpoint>> (response, "response is List<Endpoint>");
        }
        
        /// <summary>
        /// Test RegisterEndpoint
        /// </summary>
        [Test]
        public void RegisterEndpointTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.RegisterEndpoint();
            
        }
        
    }

}
