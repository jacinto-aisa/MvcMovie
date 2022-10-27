using Microsoft.AspNetCore.Mvc;
using MvcMovie.Controllers;
using MvcMovie.Models;
using MvcMovie.Services.Repositorio;

namespace MvcMovie.Test
{
    [TestClass]
    public class UnitTest1
    {
        readonly MoviesController controlador = new(new FakeRepository());

        [TestMethod]
        public void PruebaCursosDetallesVistaEncontrado()
        {
            var result = controlador.Details(2);
            Assert.IsNotNull(result);
        }
        //[TestMethod]
        //[ExpectedException(typeof(System.InvalidOperationException))]
        //public void PruebaCursosDetallesVistaNoEncontrado()
        //{
        //    var result = controlador.Details(4) as ViewResult;
        //    Assert.IsNotNull(result);
        //    Assert.AreEqual("Details", result.ViewName);
        //    Assert.IsNotNull(result.ViewData.Model);
        //    var curso = result.ViewData.Model as Curso;
        //    Assert.IsNotNull(curso);
        //    Assert.AreEqual("Curso de Frances", curso.Name);
        //}
        //[TestMethod]
        //public void PruebaCursosIndexVistaOk()
        //{
        //    var result = controlador.Index() as ViewResult;
        //    Assert.IsNotNull(result);
        //    Assert.AreEqual("Index", result.ViewName);
        //    Assert.IsNotNull(result.ViewData.Model);
        //    var listaCursos = result.ViewData.Model as List<Curso>;
        //    Assert.IsNotNull(listaCursos);
        //    Assert.AreEqual(3, listaCursos.Count);
        //}
    }
}