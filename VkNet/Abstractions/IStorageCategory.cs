﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using JetBrains.Annotations;
using VkNet.Abstractions.Async;
using VkNet.Categories;
using VkNet.Model;

namespace VkNet.Abstractions
{
	/// <inheritdoc />
	/// <summary>
	/// Storage Методы для работы с переменными в приложении.
	/// </summary>
	[UsedImplicitly]
	public interface IStorageCategory : IStorageCategoryAsync
	{
		/// <summary>
		/// Возвращает значение переменной, название которой передано в параметре key.
		/// </summary>
		/// <param name = "keys">
		/// Список названий переменных, разделённых запятыми. Если указан этот параметр, то параметр key не учитывается. список слов, разделенных через запятую, количество элементов должно составлять не более 1000
		/// </param>
		/// <param name = "userId">
		/// Id пользователя, переменная которого устанавливается, в случае если данные запрашиваются серверным методом. положительное число
		/// </param>
		/// <param name = "global">
		/// Указывается 1, если необходимо работать с глобальными переменными, а не с переменными пользователя. флаг, может принимать значения 1 или 0, по умолчанию 0
		/// </param>
		/// <returns>
		/// Возвращает значение одной или нескольких переменных. Если переменная на сервере отсутствует, то будет возвращена пустая строка.
		/// </returns>
		/// <remarks>
		/// Страница документации ВКонтакте http://vk.com/dev/storage.get
		/// </remarks>
		ReadOnlyCollection<StorageObject> Get(IEnumerable<string> keys = null, ulong? userId = null, bool? global = null);

		/// <summary>
		/// Возвращает названия всех переменных.
		/// </summary>
		/// <param name = "userId">
		/// Id пользователя, названия переменных которого получаются, в случае если данные запрашиваются серверным методом. положительное число
		/// </param>
		/// <param name = "global">
		/// Указывается 1, если необходимо работать с глобальными переменными, а не с переменными пользователя. флаг, может принимать значения 1 или 0, по умолчанию 0
		/// </param>
		/// <param name = "offset">
		/// Смещение, необходимое для выборки определенного подмножества названий переменных. По умолчанию 0. положительное число, по умолчанию 0
		/// </param>
		/// <param name = "count">
		/// Количество названий переменных, информацию о которых необходимо получить. положительное число, максимальное значение 1000, по умолчанию 100
		/// </param>
		/// <returns>
		/// Возвращает массив названий переменных.
		/// </returns>
		/// <remarks>
		/// Страница документации ВКонтакте http://vk.com/dev/storage.getKeys
		/// </remarks>
		ReadOnlyCollection<string> GetKeys(ulong? userId = null, bool? global = null, ulong? offset = null,
			ulong? count = null);

		/// <summary>
		/// Сохраняет значение переменной, название которой передано в параметре key.
		/// </summary>
		/// <param name = "key">
		/// Название переменной. Может содержать символы латинского алфавита, цифры, знак тире, нижнее подчёркивание [a-zA-Z_&#092;-0-9]. строка, максимальная длина 100, обязательный параметр
		/// </param>
		/// <param name = "value">
		/// Значение переменной, сохраняются только первые 4096 байта. строка
		/// </param>
		/// <param name = "userId">
		/// Id пользователя, переменная которого устанавливается, в случае если данные запрашиваются серверным методом. положительное число
		/// </param>
		/// <param name = "global">
		/// Указывается 1, если необходимо работать с глобальными переменными, а не с переменными пользователя. флаг, может принимать значения 1 или 0, по умолчанию 0
		/// </param>
		/// <returns>
		/// Возвращает 1 в случае удачного сохранения переменной.
		/// Для удаления переменной необходимо передать пустое значение в параметре value.
		/// </returns>
		/// <remarks>
		/// Страница документации ВКонтакте http://vk.com/dev/storage.set
		/// </remarks>
		bool Set(string key, string value = null, ulong? userId = null, bool? global = null);
	}
}