using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {       //Intancia Clientes
            Cliente cliente1 = new Cliente(01, "Arthur A. Ferreira", "857.032.950-41", "arthur.antunes@sp.senai.com.br", "Madruga");
            Cliente cliente2 = new Cliente(02, "Willian Henry Gates III", "039.618.250-09", "willian@sp.senai.com.br", "Bug");
            Cliente cliente3 = new Cliente(03, "Ada Lovelace", "800.777.920-50", "ada@sp.senai.com.br", "Byron");
            Cliente cliente4 = new Cliente(04, "Linus Torvalds", "933.622.400-03", "linus@sp.senai.com.br", "Pinguim");
            Cliente cliente5 = new Cliente(05, "Grace Hopper", "911.702.988-00", "grace@sp.senai.com.br", "Loboc");
            
            //Lista de Clientes
            List<Cliente> listaClientes  = new List<Cliente>();
            listaClientes.Add(cliente1);
            listaClientes.Add(cliente2);
            listaClientes.Add(cliente3);
            listaClientes.Add(cliente4);
            listaClientes.Add(cliente5);


            ViewBag.listaClientes = listaClientes;


            //Instancia Fornecedor
            Fornecedor fornecedor1 = new Fornecedor(01, "C# PET S/A", "14.182.102./0001-80", "c-sharp@pet.org");
            Fornecedor fornecedor2 = new Fornecedor(02, "Ctrl Alt Dog", "12.142.102./0001-20", "ctrl@pet.org");
            Fornecedor fornecedor3 = new Fornecedor(03, "BootsPet", "16.152.102./0401-70", "bootspet@pet.org");
            Fornecedor fornecedor4 = new Fornecedor(04, "Tik Tok Dogs", "17.182.142./0001-89", "tiktokpets@pet.org");
            Fornecedor fornecedor5 = new Fornecedor(05, "Bifinho foverer", "15.152.100./0001-00", "bifinho@pet.org");

            //Lista Fornecedor 
            List<Fornecedor> listaFornecedores  = new List<Fornecedor>();
            listaFornecedores.Add(fornecedor1);
            listaFornecedores.Add(fornecedor2);
            listaFornecedores.Add(fornecedor3);
            listaFornecedores.Add(fornecedor4);
            listaFornecedores.Add(fornecedor5);

            ViewBag.listaFornecedores = listaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
