[![](https://img.shields.io/nuget/v/soenneker.messages.msteams.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.messages.msteams/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.messages.msteams/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.messages.msteams/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.messages.msteams.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.messages.msteams/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.messages.msteams/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.messages.msteams/actions/workflows/codeql.yml)

# Soenneker.Messages.MsTeams

A Service Bus Message for Microsoft Teams webhook sending.

## Install

```bash
dotnet add package Soenneker.Messages.MsTeams
```

## What you get

- `MsTeamsMessage` — A Service Bus Message for Microsoft Teams webhook sending.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `MsTeamsMessage.MsTeamsCard` | Gets the Microsoft Teams card associated with this instance. This property is required and must be set during object initialization. | Gets the Microsoft Teams card associated with this instance. This property is required and must be set during object initialization. |
| `MsTeamsMessage.Channel` | Gets the name of the channel associated with this instance. | Gets the name of the channel associated with this instance. |
