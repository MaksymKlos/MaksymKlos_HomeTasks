namespace MyOwnCollection
{
    /// <summary>
    /// Человек.
    /// </summary>
    interface IHuman
    {
        /// <summary>
        /// Имя человека.
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// Фамилия человека.
        /// </summary>
        string Surname { get; set; }
    }
}
