namespace MarketPulse
{
    public static class Config
    {
        // =====================
        // Основные настройки бота
        // =====================
        public const string BotName = "MarketPulseBot";

        // Интервал проверки товаров (в минутах)
        public const int CheckIntervalMinutes = 30;

        // Максимальное количество товаров на пользователя
        public const int MaxProductsPerUser = 10;

        // =====================
        // Безопасное хранение секретов
        // =====================
        public static class Secrets
        {
            // Получаем значения из переменных окружения
            public static string TelegramToken =>
                Environment.GetEnvironmentVariable("TELEGRAM_TOKEN")
                ?? throw new Exception("TELEGRAM_TOKEN не установлен");

            public static string YooKassaShopId =>
                Environment.GetEnvironmentVariable("YOOKASSA_SHOPID")
                ?? "test_shop_id"; // Для разработки

            public static string YooKassaSecret =>
                Environment.GetEnvironmentVariable("YOOKASSA_SECRET")
                ?? "test_secret"; // Для разработки
        }

        // =====================
        // Настройки парсинга
        // =====================
        public static class Parsing
        {
            // User-Agent для обхода блокировок
            public const string UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/125.0.0.0 Safari/537.36";

            // Таймаут запросов (в секундах)
            public const int TimeoutSeconds = 30;

            // Максимальное количество попыток
            public const int MaxRetries = 3;
        }

        // =====================
        // Настройки базы данных
        // =====================
        public static string DatabasePath =>
            Environment.GetEnvironmentVariable("DB_PATH")
            ?? "Data Source=marketbot.db"; // По умолчанию
    }
}
