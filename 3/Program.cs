using _3;

ScladPilomaterialov sklad1 = new ScladPilomaterialov() { Number = 1, Fio = "Петоров П.П.", MaxVolume = 500, Current = 120 };
ScladPilomaterialov sklad2 = new ScladPilomaterialov() { Number = 2, Fio = "Иванов И.И.", MaxVolume = 800, Current = 100 };

sklad1.Add(40);
sklad1.Print();

sklad1.Add(500);
sklad1.Print();

sklad1.Sub(600);
sklad1.Print();

sklad1.Sub(300);
sklad1.Print();