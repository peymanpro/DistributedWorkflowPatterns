# DistributedWorkflowPatterns

> Enterprise-grade reference implementation of distributed workflow patterns in .NET.

![.NET](https://img.shields.io/badge/.NET-8-512BD4)
![Architecture](https://img.shields.io/badge/Architecture-Clean-blue)
![Messaging](https://img.shields.io/badge/Messaging-RabbitMQ-orange)
![License](https://img.shields.io/badge/License-MIT-green)

---

## Overview

Distributed systems rarely fail because of business logic—they fail because coordinating work across independent services is difficult.

This project focuses on implementing reusable workflow patterns rather than application-specific business scenarios.

Instead of demonstrating an Order Service or Payment Service, this repository provides architectural building blocks for designing reliable distributed workflows that can be reused across different domains.

The project follows Clean Architecture principles and keeps workflow coordination independent from any messaging technology.

---

## Vision

Build a reusable reference implementation for enterprise distributed workflow patterns.

The primary goal is to demonstrate architectural concepts such as:

- Workflow orchestration
- Saga Pattern
- Message-driven communication
- Compensation
- Correlation
- Retry strategies
- Technology-independent messaging abstractions

RabbitMQ is only the first transport implementation.

The architecture is designed so that other providers such as Kafka, Azure Service Bus or MassTransit can be introduced without changing the core workflow engine.

---

# Why this project?

Many examples available online are tightly coupled to a specific business domain:

- Shopping Cart
- Order Processing
- Payment
- Hotel Reservation

Those examples make it difficult to reuse architectural ideas.

This repository intentionally avoids business-specific entities.

Instead, it focuses on generic workflow execution patterns that can serve as reusable building blocks for enterprise systems.

---

# Architecture

The solution follows Clean Architecture.

```

```
                   API
                    │
                    │
             Application
              ↙       ↘
         Domain   BuildingBlocks
                    ▲
                    │
             Infrastructure
```

Dependencies always point toward the domain.

Infrastructure contains implementation details.

Domain contains no infrastructure dependencies.

---

# Solution Structure

```

DistributedWorkflowPatterns

│
├── src
│ ├── DistributedWorkflowPatterns.Api
│ ├── DistributedWorkflowPatterns.Application
│ ├── DistributedWorkflowPatterns.Domain
│ ├── DistributedWorkflowPatterns.Infrastructure
│ ├── DistributedWorkflowPatterns.Contracts
│ └── DistributedWorkflowPatterns.BuildingBlocks
│
├── tests
│
├── docs
│
└── assets

```

---

# Current MVP Scope

Version 1 focuses on building the smallest reusable workflow engine.

Included:

- Workflow Definition
- Workflow Steps
- Workflow State Management
- Message Abstractions
- Saga Orchestration
- Compensation Strategy

Not included yet:

- Database
- Authentication
- Dashboard
- Docker
- Kubernetes
- Persistence
- Event Sourcing

---

# Planned Features

## Workflow Engine

- Workflow Definition
- Workflow Execution
- Step Execution
- State Transitions

---

## Messaging

- Generic Message Bus
- Publisher
- Subscriber
- Correlation
- Message Metadata

---

## Saga

- Saga Orchestrator
- Compensation
- Retry
- Failure Handling

---

## Infrastructure

Initial implementation:

- RabbitMQ

Future implementations:

- Kafka
- Azure Service Bus
- MassTransit

---

# Technologies

- .NET 8
- ASP.NET Core
- C#
- Clean Architecture

Messaging:

- RabbitMQ

Future:

- Kafka
- Azure Service Bus

---

# Project Roadmap

## Phase 1

- Solution Structure
- Documentation
- Domain Model

---

## Phase 2

- Messaging Abstractions

---

## Phase 3

- RabbitMQ Transport

---

## Phase 4

- Workflow Runtime

---

## Phase 5

- Saga Orchestrator

---

## Phase 6

- Compensation Engine

---

## Phase 7

- Advanced Retry Policies

---

## Phase 8

- Saga Choreography

---

## Phase 9

- OpenTelemetry Integration

---

## Phase 10

- Persistence

---

# Design Principles

The project follows these principles:

- Clean Architecture
- Separation of Concerns
- Technology Independence
- Message-driven Design
- Extensibility
- High Cohesion
- Low Coupling

---

# Learning Objectives

This repository demonstrates practical implementation of:

- Distributed Systems
- Enterprise Messaging
- Workflow Engines
- Saga Pattern
- Compensation Pattern
- Retry Strategies
- Correlation Management
- Infrastructure Abstraction

---

# Repository Status

Current Status

 Under Active Development

The project is intentionally built incrementally.

Each Git commit introduces a small, meaningful architectural improvement.

The commit history is part of the documentation.

---

# License

MIT License