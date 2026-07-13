# DistributedWorkflowPatterns

> Enterprise reference implementation of distributed workflow patterns in .NET.

![.NET](https://img.shields.io/badge/.NET-8-512BD4)
![Architecture](https://img.shields.io/badge/Architecture-Clean-blue)
![Messaging](https://img.shields.io/badge/Messaging-RabbitMQ-orange)
![License](https://img.shields.io/badge/License-MIT-green)

---

# Overview

Distributed systems become challenging when multiple independent components need to coordinate reliable execution.

This project demonstrates reusable distributed workflow patterns instead of application-specific business logic.

The repository does not implement scenarios such as:

* Order Processing
* Payment
* Reservation
* Shopping Cart

Instead, it provides architectural building blocks for:

* Workflow orchestration
* Saga Pattern
* Message-driven communication
* Compensation
* Retry strategies
* Correlation
* Technology-independent messaging

RabbitMQ is the first transport implementation.
The architecture is designed to allow future integration with Kafka, Azure Service Bus, or MassTransit without changing the core workflow engine.

---

# Architecture

The solution follows Clean Architecture principles.

```
                    API
                     |
                     v
              Application
              /        \
             v          v
        Domain     BuildingBlocks
                     |
                     v
             Infrastructure
```

Dependency direction always moves toward the core.

Infrastructure contains implementation details.

Domain contains workflow concepts without infrastructure dependencies.

---

# Solution Structure

```
DistributedWorkflowPatterns

src/

├── DistributedWorkflowPatterns.Api

├── DistributedWorkflowPatterns.Application

├── DistributedWorkflowPatterns.Domain

├── DistributedWorkflowPatterns.Infrastructure

├── DistributedWorkflowPatterns.Contracts

└── DistributedWorkflowPatterns.BuildingBlocks
```

---

# Core Responsibilities

## Domain

Contains the core workflow model:

* Workflow
* Workflow Step
* Workflow State
* Workflow Execution
* Workflow Compensation

No dependency on external technologies.

---

## Application

Responsible for workflow coordination:

* Workflow execution
* Saga orchestration
* Compensation handling
* Application use cases

---

## BuildingBlocks

Contains reusable abstractions:

* Messaging abstractions
* Correlation concepts
* Retry contracts
* Compensation contracts

---

## Infrastructure

Contains external implementations:

* RabbitMQ transport
* OpenTelemetry configuration
* External adapters

---

## Contracts

Contains shared communication contracts:

* Commands
* Events
* Message definitions

---

# MVP Scope (Version 1)

Implemented:

* Workflow Definition
* Workflow Steps
* Workflow State Management
* Workflow Execution Model
* Messaging Abstractions
* Saga Orchestration
* Compensation Strategy
* RabbitMQ Transport
* Retry Abstractions
* Saga Choreography Contracts
* OpenTelemetry Integration
* Persistence Contract

Not included:

* Database implementation
* Authentication
* Dashboard
* Docker/Kubernetes deployment
* Event Sourcing

---

# Workflow Execution Flow

```
Client
 |
 v
Workflow Definition
 |
 v
Workflow Coordinator
 |
 v
Execute Workflow Step
 |
 v
Publish Message
 |
 v
External Component
 |
 +------------+
 | Success    |
 +------------+
 |
 v
Next Step


Failure:

Workflow Coordinator
 |
 v
Compensation Flow
 |
 v
Rollback Previous Steps
```

---

# Saga Orchestration Flow

```
Coordinator

    |
    v

Execute Step A

    |
    v

Execute Step B

    |
    v

Failure Occurs

    |
    v

Compensate Previous Steps
```

The orchestrator manages:

* Workflow state
* Executed steps
* Failure handling
* Compensation execution

---

# Development Roadmap

## Phase 1 - Foundation

Completed:

* Solution structure
* Clean Architecture setup
* Domain modeling

---

## Phase 2 - Messaging Abstractions

Completed:

* IMessageBus abstraction
* Publisher/Subscriber contracts
* Message metadata concepts

---

## Phase 3 - RabbitMQ Transport

Completed:

* RabbitMQ adapter
* Connection handling
* Message publishing and consuming

---

## Phase 4 - Workflow Runtime

Completed:

* Workflow execution concepts
* Step management
* State transitions

---

## Phase 5 - Saga Orchestrator

Completed:

* Workflow coordination
* Saga execution flow
* Failure handling

---

## Phase 6 - Compensation Engine

Completed:

* Compensation contracts
* Recovery strategy

---

## Phase 7 - Retry Policies

Completed:

* Retry abstractions
* Transient failure handling

---

## Phase 8 - Saga Choreography

Completed:

* Event contracts
* Command contracts
* Decoupled communication model

---

## Phase 9 - OpenTelemetry Integration

Completed:

* OpenTelemetry setup
* Trace instrumentation foundation

---

## Phase 10 - Persistence Contract

Completed:

* Persistence abstraction
* Future database provider support

---

# Design Principles

The project follows:

* Clean Architecture
* Separation of Concerns
* Technology Independence
* Low Coupling
* High Cohesion
* Extensible Design
* Message-driven Architecture

---

# Technology Stack

* .NET 8
* ASP.NET Core
* C#
* Clean Architecture
* RabbitMQ
* OpenTelemetry

---

# Repository Status

Current Version:

**v1.0.0**

Status:

✅ MVP Completed

The first version focuses on architecture and reusable distributed workflow patterns.

Future versions will add:

* Executable workflow examples
* Automated tests
* Database providers
* Additional messaging transports
* Monitoring capabilities

---

# License

MIT License
