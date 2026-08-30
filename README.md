# Soenneker.Messages.MsTeams
[![](https://img.shields.io/nuget/v/soenneker.messages.msteams.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.messages.msteams/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.messages.msteams/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.messages.msteams/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.messages.msteams.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.messages.msteams/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.messages.msteams/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.messages.msteams/actions/workflows/codeql.yml)

Defines a message envelope for routing an Adaptive Card payload to a named Microsoft Teams channel.

## Installation

```bash
dotnet add package Soenneker.Messages.MsTeams
```

## Create a message

```csharp
using AdaptiveCards;
using Soenneker.Dtos.AdaptiveCard.Attachments;
using Soenneker.Dtos.MsTeams.Card;
using Soenneker.Messages.MsTeams;

var card = new AdaptiveCard(new AdaptiveSchemaVersion(1, 5));
card.Body.Add(new AdaptiveTextBlock
{
    Text = "Deployment completed",
    Weight = AdaptiveTextWeight.Bolder
});

var teamsCard = new MsTeamsCard();
teamsCard.Attachments.Add(new AdaptiveCardAttachments(card));

var message = new MsTeamsMessage
{
    Type = "teams.notification.v1",
    Id = Guid.NewGuid().ToString("N"),
    Queue = "teams-notifications",
    Sender = "deployment-service",
    CreatedAt = DateTimeOffset.UtcNow,
    Channel = "engineering-alerts",
    MsTeamsCard = teamsCard
};
```

`MsTeamsCard.Type` defaults to `message`. Its `Attachments` collection starts empty, so add at least one card before publishing the message.

## Consumer responsibilities

This package models the queue payload only. It does not resolve `Channel`, store a webhook URL, validate the Adaptive Card, or send a request to Teams. The receiving service should:

- map `Channel` to an approved destination rather than treating it as an arbitrary URL;
- reject missing or empty channel names and attachment collections;
- validate that each card schema version and element is supported by the target Teams client or webhook;
- avoid placing credentials, webhook URLs, or sensitive operational data in the message or card content.

C# `required` members and Newtonsoft.Json's required metadata do not replace validation at the message-processing boundary.
