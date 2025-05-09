using System.Collections.ObjectModel;
using Header.Utils.Models;

namespace Header.Utils;

public static class Global
{
    public static ObservableCollection<Students> Std { get; } =
    [
        new Students(1, "Шихкеримов Руслан Гаджикурбанович", false, 0, ""),
        new Students(2, "Герейханов Намик Алимадетович", false, 0, ""),
        new Students(3, "Устенко Данил Алексеевич", false, 0, ""),
        new Students(4, "Устенко Данил Алексеевич", false, 0, ""),
        new Students(5, "Устенко Данил Алексеевич", false, 0, ""),
        new Students(6, "Устенко Данил Алексеевич", false, 0, ""),
        new Students(7, "Устенко Данил Алексеевич", false, 0, ""),
        new Students(8, "Устенко Данил Алексеевич", false, 0, ""),
        new Students(9, "Устенко Данил Алексеевич", false, 0, ""),
        new Students(10, "Устенко Данил Алексеевич", false, 0, ""),
    ];

    public static ObservableCollection<Disciplines> Disc { get; } =
    [
        new Disciplines(1, "Физическая культура"),
        new Disciplines(2, "Информационные системы и программирование"),
        new Disciplines(3, "Стандартизация, сертификация и техническая документация"),
        new Disciplines(4, "Теория вероятности и математическая статистика"),
        new Disciplines(5, "Основы безопасности жизнедеятельности"),
        new Disciplines(6, "Экономика отрасли"),
    ];
}