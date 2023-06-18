﻿//Разработайте приложение для учета студентов в университете. Ваша задача - создать класс "Student" для представления студента и класс "StudentManager", который будет отвечать за управление списком студентов.

//Класс "Student" должен содержать следующие поля:
//Имя(Name) - строковое поле.
//Фамилия(Surname) - строковое поле.
//Возраст(Age) - целочисленное поле.
//Курс(Year) - целочисленное поле.
//Класс "Student" должен также иметь конструктор, который принимает значения для всех полей и метод "ToString()", который возвращает строковое представление объекта студента.

//Класс "StudentManager" должен содержать список (List) студентов и иметь следующие методы:
//AddStudent(Student student): добавляет студента в список.
//RemoveStudent(Student student): удаляет студента из списка.
//GetStudentsByYear(int year): возвращает список студентов, находящихся на указанном курсе.
//GetOldestStudent(): возвращает самого старшего студента из списка.

//Создайте консольное приложение, которое будет взаимодействовать с пользователем.
//Пользователь должен иметь возможность добавлять студентов, удалять студентов,
//просматривать список студентов на определенном курсе и получать информацию о самом старшем студенте.
//Приложение должно работать до тех пор, пока пользователь не введет команду для выхода.

using System;
using System.Collections.Generic;

Menu menu = new Menu();
menu.Start();

