using AirBookingESW17.Data;
using AirBookingESW17.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirBookingESW17.Models
{
    public static class DbInitializer2017
    {
        //public static DateTime date = DateTime.Parse("yyyy-MM-dd");

        //public  static string data = date.ToString();

       
        // <param name="context"></param>
        public static void Initializer(ApplicationDbContext context)
        {

            context.Database.EnsureCreated();

            /*-------inserts da tabela Frota ou a criação de objeto da tabela--------------------------------------------*/
            if (!context.Frotas.Any())
            {

                var frotas = new Frota[]
                {
                new Frota { Nome= "Air Booking",Email= "air.booking@net.com",Morada= " Manteigadas Setúbal",
                NIF= 222452019, Telefone= "212023434"},
                new Frota { Nome= "Taag",Email= "taag@net.com",Morada= "Lisboa Campo Grande",
                NIF= 222201632, Telefone= "212023434"},
                 new Frota { Nome= "Tap",Email= "fly@tap.com",Morada= "Lisboa Aeroporto ",
                NIF= 271822190, Telefone= "913231223"}
                };
                foreach (Frota f in frotas)
                {

                    context.Frotas.Add(f);
                }
                context.SaveChanges();
            }

            /*---------------inserts da tabela Tripulação----------------------------------*/

            if (!context.Tripulantes.Any())
            {

                var tripulante = new Tripulacao[] {

                new Tripulacao {NumeroTripulante= 10,Descricao= "Pilotos e Assistentes de bordo",
                    //Voos =voos
                },

                new Tripulacao {NumeroTripulante= 8,Descricao= "Pilotos e Assistentes de bordo",
                    //Voos =voos
                }

            };
                foreach (Tripulacao t in tripulante)
                {
                    context.Tripulantes.Add(t);
                }


                context.SaveChanges();
            }

            /*---------------inserts da tabela Newsletter--------------------------------------------*/

            if (!context.Newsletters.Any())
            {

                var newsletter = new Newsletter[]
                {
                   new Newsletter {NomeDestinatario="André Gastão", EmaisDestinatario="andre.camuenhi@hotmail.com" },
                   new Newsletter {NomeDestinatario="teste teste", EmaisDestinatario="teste.teste@live.com" }
                };

                foreach (Newsletter news in newsletter)
                {
                    context.Newsletters.Add(news);
                }
                context.SaveChanges();
            }

            /*---------------inserts da tabela Cidade Origem e Destino----------------------------------*/

            if (!context.CidadesOrigem.Any())
            {

                var cidadesOrigem = new CidadeOrigem[] {
                    new CidadeOrigem {Nome = "Lisboa", },
                    new CidadeOrigem {Nome = "Porto", },
                    new CidadeOrigem {Nome = "Rio de Janeiro", },
                    new CidadeOrigem {Nome = "Londres", },
                    new CidadeOrigem {Nome = "Nova Iorque", },
                    new CidadeOrigem {Nome = "Paris", },
                    new CidadeOrigem {Nome = "Moscovo", },
                    new CidadeOrigem {Nome = "Dubai", },
                    new CidadeOrigem {Nome = "Oslo", },
                    new CidadeOrigem {Nome = "Amsterdam", },
                    new CidadeOrigem {Nome = "Roma", }
                };

                foreach (CidadeOrigem c in cidadesOrigem)
                {
                    context.CidadesOrigem.Add(c);
                }
                
                context.SaveChanges();
            }

            ////

            if (!context.CidadesDestino.Any())
            {

                var cidadesOrigem = new CidadeDestino[] {
                    new CidadeDestino {Nome = "Lisboa", },
                    new CidadeDestino {Nome = "Porto", },
                    new CidadeDestino {Nome = "Rio de Janeiro", },
                    new CidadeDestino {Nome = "Londres", },
                    new CidadeDestino {Nome = "Nova Iorque", },
                    new CidadeDestino {Nome = "Paris", },
                    new CidadeDestino {Nome = "Moscovo", },
                    new CidadeDestino {Nome = "Dubai", },
                    new CidadeDestino {Nome = "Oslo", },
                    new CidadeDestino {Nome = "Amsterdam", },
                    new CidadeDestino {Nome = "Roma", }
                };

                foreach (CidadeDestino c in cidadesOrigem)
                {
                    context.CidadesDestino.Add(c);
                }

                context.SaveChanges();
            }


            ///*--------------------inserts da tabela Voo--------------------------------------------*/
            if (!context.Voos.Any())
            {
                var voos = new Voo[]
                {
               new Voo { CidadeOrigemId=1,
               CidadeDestinoId=2,
                DataPartida = DateTime.Parse("2016-10-23")
            ,
                DataChegada = DateTime.Parse("2016-10-25"), TripulacaoId=1

                   //Reservas = reservas 
               },
               new Voo { CidadeOrigemId=3,
               CidadeDestinoId=4,
                DataPartida = DateTime.Parse("2016-03-02")
            ,
                DataChegada = DateTime.Parse("2016-03-03"), TripulacaoId= 2

                   //Reservas = reservas
               }
                 };

                foreach (Voo v in voos) { context.Voos.Add(v); }

                context.SaveChanges();
            }


            /*----------------inserts da tabela Avião--------------------------------------------*/
            if (!context.Avioes.Any())
            {

                var avioes = new Aviao[]
                   {
                new Aviao { AvNome = "Boeng 777", AvSerie = "B123", AvCapacidade = 200, AvPartilhado = true,
                    FrotaId = 3, VooId = 2 },
                 new Aviao { AvNome = "Boeng 12304", AvSerie = "Ac12345", AvCapacidade = 450, AvPartilhado= false,
                     FrotaId = 2, VooId = 1 },
                 new Aviao { AvNome = "Jato Executivo", AvSerie = "Ex12ec20", AvCapacidade = 100, AvPartilhado= true,
                     FrotaId = 1, VooId = 2 }};

                foreach (Aviao a in avioes)
                {
                    context.Avioes.Add(a);
                }


                context.SaveChanges();
            }

            /*---------------inserts da tabela Reserva--------------------------------------------*/
            //if (!context.Reservas.Any())
            //{

            //    var reservas = new Reserva[]
            //       {
            //     new Reserva {Data= DateTime.Parse("2015-02-12"), Preco= 200,
            //     UserId= "033606e0-7713-415d-bee0-ed3f345bafb5",VooId= 1 },
            //     new Reserva {Data= DateTime.Parse("2016-04-19"), Preco= 255,
            //     UserId= "4ac840dc-ac3b-4068-b015-77bda1f0458d",VooId= 2 },

            //     new Reserva { Data= DateTime.Parse("2017-01-12"), Preco= 3000,
            //     UserId= "7e1ce211-d605-4b38-8b5f-b90034492376", VooId= 1}


            //       };

            //    foreach (Reserva r in reservas) { context.Reservas.Add(r); }

            //    context.SaveChanges();
            //}


            ///*---------------inserts da tabela Pesquisa--------------------------------------------*/
            //if (!context.ResAvioes.Any())
            //{

            //    var resAviao = new ReservaAviao[]
            //    {


            //new ReservaAviao {Origem= "Lisboa", Destino= "Londres", DataIda=DateTime.Parse("2016-11-23"),
            //    DataRegresso= DateTime.Parse("2016-12-29"),

            //    ReservaId= 2, AviaoId=1},

            //new ReservaAviao {Origem= "Porto", Destino= "Paris", DataIda=DateTime.Parse("2016-02-04"),
            //    DataRegresso= DateTime.Parse("2016-02-04"),

            //    ReservaId= 4, AviaoId=3},



            //new ReservaAviao {Origem= "Lisboa", Destino= "Tokyo", DataIda=DateTime.Parse("2017-01-03"),
            //    DataRegresso= DateTime.Parse("2017-02-17"),

            //    ReservaId= 3, AviaoId=2},

            //    };

            //    foreach (ReservaAviao p in resAviao)
            //    {
            //        context.ResAvioes.Add(p);
            //    }
            //    context.SaveChanges();
            //}




            ///*---------------inserts da tabela Serviço--------------------------------------------*/
            //if (!context.Servicos.Any())
            //{


            //    var servicos = new Servico[]
            //    {
            //    new Servico {Descricao= "Serviço de Tripulação",Preco= 350,
            //    AviaoId=2,ReservaId= 3
            //    },
            //    new Servico {Descricao= "Serviço de refeições",Preco= 50,
            //    AviaoId=1,ReservaId= 2
            //    }
            //    };

            //    foreach (Servico s in servicos) { context.Servicos.Add(s); }

            //    context.SaveChanges();

            //}


            ///*---------------inserts da tabela Notificação--------------------------------------------*/

            //if (!context.Notificacoes.Any())
            //{

            //    var notificoes = new Notificacao[]
            //    {
            //       new Notificacao { Descricao = "mensagem de erro ao autenticar-se", DataNotificacao = DateTime.Parse("2017-01-02"),
            //        NewsletterId=1,
            //    },
            //       new Notificacao { Descricao = "Reserva confirmada", DataNotificacao = DateTime.Parse("2016-10-30"),
            //        NewsletterId=2,
            //    }
            //       };
            //    foreach (Notificacao not in notificoes)
            //    {
            //        context.Notificacoes.Add(not);
            //    }
            //    context.SaveChanges();


            //}


            /////*---------------inserts da tabela configuração---------------------------------------*/

            //if (!context.Configuracoes.Any())
            //{
            //    var config = new Configuracao[]
            //    {
            //            new Configuracao {AntigaPassword="A.c09930639", NovaPassword="A.gastao17",Email="andre.camuenhi@hotmail.com",

            //            UserId="7e1ce211-d605-4b38-8b5f-b90034492376"
            //            },
            //            new Configuracao {AntigaPassword="C.borges12", NovaPassword="t.teste17",Email="cynhtia.boreges@gmail.com",

            //            UserId="4ac840dc-ac3b-4068-b015-77bda1f0458d"
            //            }


            //    };
            //    foreach (Configuracao config1 in config)
            //    {
            //        context.Configuracoes.Add(config1);
            //    }
            //    context.SaveChanges();
            //}

            ///*---------------inserts da tabela contaNotificacão---------------------------------------*/

            //if (!context.ContasNotificacoes.Any())
            //{
            //    var cNotificacao = new ContaNotificacao[]
            //    {
            //               new ContaNotificacao {Descricao="notificado por inserir senha errada",UserId= "033606e0-7713-415d-bee0-ed3f345bafb5",NotificacaoId =2
            //                    },
            //               new ContaNotificacao { Descricao="noticia de confrimação da senha" ,UserId= "7e1ce211-d605-4b38-8b5f-b90034492376",NotificacaoId=1 },
            //               new ContaNotificacao {Descricao=" envia-nos um email sempre que precisares de ajuda", UserId="4ac840dc-ac3b-4068-b015-77bda1f0458d",
            //               NotificacaoId=2}
            //    };
            //    foreach (ContaNotificacao contNot in cNotificacao)
            //    {
            //        context.ContasNotificacoes.Add(contNot);
            //    }
            //    context.SaveChanges();
           // }









        }

    }
}
