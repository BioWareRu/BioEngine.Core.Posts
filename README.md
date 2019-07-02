# This repo is merged to https://github.com/BioWareRu/BioEngine.Core

# Модуль Posts

Реализация контентной сущности `Пост` для BioEngine. Подходит для блогов, новостных лент.

- Сущность `Post`
- Репозиторий `PostsRepository`
- Провайдера поиска `PostsSearchProvider`
- Провайдер карты сайта `PostsSiteMapNodeService`
- Базовый контроллер для сайта с генератором RSS
- Базовый контроллер и сущность для API 

## Установка

```csharp
bioengine.AddModule<PostsModule>();
```
