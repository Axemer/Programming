using System;

namespace Programming.Model.Classes
{
	/// <summary>
	/// Содержит информацию о предмете.
	/// </summary>
	public class Subject
	{
		/// <summary>
		/// Оценка
		/// </summary>
		private int _mark;

		/// <summary>
		/// Возвращает и задаёт оценку. Принимает положительные значения.
		/// </summary>
		public int Mark
        {
			get 
			{ 
				return _mark; 
			}

            set
            {
				Validator.AssertValueInRange(nameof(Mark), value, 1, 5);
				_mark = value;
			}
        }

		/// <summary>
		/// Название предмета.
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Имя учителя.
		/// </summary>
		public string TeacherName { get; set; }

		/// <summary>
		/// Фамилия учителя.
		/// </summary>
		public string TeachersLastName { get; set; }

		// <summary>
		/// Создаёт экземпляр класса <see cref="Subject"/>
		/// </summary>
		/// <param name="title">Название предмета.</param>
		/// <param name="teacherName">Имя учителя.</param>
		/// <param name="teacherSurname">Фамилия учителя.</param>
		/// <param name="averageScore">Оценка. Принимает только положительные значения.</param>
		public Subject(string title, string teacherName, string teachersLastName, int Mark)
        {
			Title = title;
			TeacherName = teacherName;
			TeachersLastName = teachersLastName;
			Mark = _mark;
        }
	}
}
