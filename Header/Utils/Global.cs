using System.Collections.ObjectModel;
using Header.Utils.Models;

namespace Header.Utils;

public static class Global
{
    public static ObservableCollection<Student> Std { get; } =
    [
        new Student(1, "Шихкеримов Руслан Гаджикурбанович", false, 0, ""),
        new Student(2, "Герейханов Намик Алимадетович", false, 0, ""),
        new Student(3, "Устенко Данил Алексеевич", false, 0, ""),
        new Student(4, "Устенко Данил Алексеевич", false, 0, ""),
        new Student(5, "Устенко Данил Алексеевич", false, 0, ""),
        new Student(6, "Устенко Данил Алексеевич", false, 0, ""),
        new Student(7, "Устенко Данил Алексеевич", false, 0, ""),
        new Student(8, "Устенко Данил Алексеевич", false, 0, ""),
        new Student(9, "Устенко Данил Алексеевич", false, 0, ""),
        new Student(10, "Устенко Данил Алексеевич", false, 0, ""),
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