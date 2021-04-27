import Text.Read (readMaybe)

main = do
    putStrLn "Saniye cinsinden yaşınızı hesaplayalım. Yaşınız kaç: "
    yaş <- getLine >>= return . readMaybe :: IO (Maybe Int)
    -- yaş atamasinda IO monad yokolup Maybe monad kalacak

    putStrLn $ "Saniye yaşınız: " <> maybe b ab yaş where
        ab = show . (*(365*24*60*60))
        b = "<geçersiz giriş tekrar deneyiniz>"