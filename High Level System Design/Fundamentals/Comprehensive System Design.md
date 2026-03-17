Comprehensive System Design

Fundamentals, Patterns, and Real-World Solutions for Modern Software Systems

# Copyright / Edition / ISBN

© 2025 Vikash Chauhan  
All rights reserved. No part of this publication may be reproduced, distributed, or transmitted in any form or by any means, without the prior written permission of the publisher, except in the case of brief quotations used in reviews or scholarly works.

**Edition:** First Edition  
**ISBN:** \[Insert ISBN if available\]

Disclaimer: The content of this book is for educational purposes. The author and publisher make no warranties of any kind regarding the information presented herein.

# About the Book

Overview  
This book, **Comprehensive System Design**, is designed to provide both **foundational knowledge** and **practical insights** into designing scalable, reliable, and maintainable software systems. It covers everything from **core principles, system architectures, networking, databases, messaging systems, and security**, to **DevOps and deployment strategies**.

Whether you are preparing for **system design interviews**, designing **enterprise systems**, or exploring **modern cloud-native architectures**, this book will equip you with the knowledge and tools to tackle real-world challenges.

**Who This Book Is For**

- Software engineers preparing for **system design interviews**
- Backend developers building **scalable and resilient architectures**
- Architects designing **cloud-native or distributed applications**
- Students and professionals seeking a **complete understanding of modern system design principles**

Learning Outcomes  
By reading this book, you will be able to:

1.  Understand the **core principles of system design** and trade-offs between scalability, reliability, and performance.
2.  Design **end-to-end architectures** for real-world applications.
3.  Implement **messaging and event-driven patterns** reliably.
4.  Apply **database and storage strategies** for large-scale systems.
5.  Ensure **operational excellence, security, and observability** in production.
6.  Deploy systems using **modern DevOps practices** and cloud technologies.

# Acknowledgements

I would like to express my gratitude to:

- My mentors and colleagues for their guidance in real-world system design challenges.
- The open-source community for providing inspiration and practical solutions.
- My family and friends for their unwavering support during the writing of this book.

Table of Contents

[Chapter 1 — Introduction to System Design 26](#_Toc215738425)

[What is System Design? 26](#_Toc215738426)

[Why is System Design Important? 26](#_Toc215738427)

[The Core Pillars of System Design 27](#_Toc215738428)

[Scalability 27](#_Toc215738429)

[Reliability (Availability) 27](#_Toc215738430)

[Performance 28](#_Toc215738431)

[Maintainability 28](#_Toc215738432)

[Functional vs Non-Functional Requirements 28](#_Toc215738433)

[Functional Requirements 28](#_Toc215738434)

[Non-Functional Requirements (NFRs) 29](#_Toc215738435)

[Why Both Requirements Matter 30](#_Toc215738436)

[Real-World Example: E-Commerce Website 30](#_Toc215738437)

[System Design Methodology 30](#_Toc215738438)

[Requirement Clarification 31](#_Toc215738439)

[High-Level Architecture Thinking 31](#_Toc215738440)

[Back-of-the-Envelope Estimation 32](#_Toc215738441)

[Evaluating Trade-offs 32](#_Toc215738442)

[Designing for Failure 33](#_Toc215738443)

[Chapter 2 — Networking Foundations 34](#_Toc215738444)

[Networking & Communication 34](#_Toc215738445)

[Understanding IP Addresses 35](#_Toc215738446)

[What is IP version four? 36](#_Toc215738447)

[What is IP version six? 36](#_Toc215738448)

[Public & Private IP’s 37](#_Toc215738449)

[NAT (Network Address Translation) 39](#_Toc215738450)

[DNS (Domain Name System) 39](#_Toc215738451)

[DNS Resolution 39](#_Toc215738452)

[Importance of DNS in Large-Scale Systems 41](#_Toc215738453)

[Private DNS in Cloud Environments 41](#_Toc215738454)

[Virtual Private Network (VPN) 42](#_Toc215738455)

[Virtual Private Cloud (VPC) or Virtual Network (VNet) 42](#_Toc215738456)

[Subnets and Internal Communication 43](#_Toc215738457)

[The Client–Server Model 44](#_Toc215738458)

[How the Client–Server Communication Works 45](#_Toc215738459)

[Understanding Proxy Servers 46](#_Toc215738460)

[Forward Proxy 46](#_Toc215738461)

[Reverse Proxy 47](#_Toc215738462)

[Comparison Between Forward and Reverse Proxy 47](#_Toc215738463)

[Load Balancing 47](#_Toc215738464)

[What Is Load Balancing? 48](#_Toc215738465)

[Why Do We Need Load Balancing? 49](#_Toc215738466)

[How Does Load Balancing Work? 50](#_Toc215738467)

[Load Balancing Algorithms 50](#_Toc215738468)

[Types of Load Balancers 50](#_Toc215738469)

[API Gateway 51](#_Toc215738470)

[How does an API gateway work? 51](#_Toc215738471)

[What are the benefits of using an API gateway? 52](#_Toc215738472)

[Content Delivery Networks (CDN) 52](#_Toc215738473)

[What is a CDN? 53](#_Toc215738474)

[Why do we need CDNs? 53](#_Toc215738475)

[Why are Syrians needed to understand this? 53](#_Toc215738476)

[What are the key benefits of using a CDN? 54](#_Toc215738477)

[Pull and Push Strategies in Content Delivery Networks (CDNs) 55](#_Toc215738478)

[Chapter 3 — Communication Protocols 56](#_Toc215738479)

[OSI Model and Its Purpose in Secure Communication 56](#_Toc215738480)

[TCP and UDP: The Foundations of Internet Communication 57](#_Toc215738481)

[Transmission Control Protocol (TCP) 57](#_Toc215738482)

[User Datagram Protocol (UDP) 58](#_Toc215738483)

[Hypertext Transfer Protocol (HTTP) 58](#_Toc215738484)

[Understanding REST and RESTful Architecture 59](#_Toc215738485)

[Core Constraints of REST Architecture 59](#_Toc215738486)

[HTTP Methods (Verbs) in REST 60](#_Toc215738487)

[Statelessness and Token-Based Authentication 61](#_Toc215738488)

[Resource Naming and URL Design 62](#_Toc215738489)

[Data Formats and Content Negotiation 62](#_Toc215738490)

[Best Practices for RESTful API Design 62](#_Toc215738491)

[HTTP Status Codes and Their Categories 62](#_Toc215738492)

[Real-Time Communication Protocols 65](#_Toc215738493)

[The Need for Real-Time Communication 66](#_Toc215738494)

[Understanding the WebSocket Protocol 66](#_Toc215738495)

[Polling and Long Polling in Real-Time Communication 67](#_Toc215738496)

[Protocols Beyond REST 69](#_Toc215738497)

[Limitations of REST APIs 70](#_Toc215738498)

[gRPC — High-Performance Communication for Microservices 70](#_Toc215738499)

[GraphQL — Flexible Data Fetching for Modern Clients 72](#_Toc215738500)

[Chapter 4 — Architectural Styles 74](#_Toc215738501)

[Monolithic Architecture 74](#_Toc215738502)

[Multi-Tier Vs Multi-Layer 74](#_Toc215738503)

[Microservices Architecture 75](#_Toc215738504)

[Serverless Architecture 76](#_Toc215738505)

[Client-Server Architecture 77](#_Toc215738506)

[Event-Driven Architecture 77](#_Toc215738507)

[Layered Architecture 77](#_Toc215738508)

[Peer-to-Peer Architecture 78](#_Toc215738509)

[Hybrid Architectural Models 78](#_Toc215738510)

[Why Hybrid Architectures? 79](#_Toc215738511)

[Common Hybrid Approaches 79](#_Toc215738512)

[Benefits of Hybrid Models 79](#_Toc215738513)

[Challenges of Hybrid Architectures 80](#_Toc215738514)

[Chapter 5 — Web Application Foundations 81](#_Toc215738515)

[The Importance of Web Concepts in System Design 81](#_Toc215738516)

[Managing State in a Stateless World 81](#_Toc215738517)

[Serialization: Structuring Data for the Web 82](#_Toc215738518)

[JSON 82](#_Toc215738519)

[XML 82](#_Toc215738520)

[Protocol Buffers 82](#_Toc215738521)

[API Versioning: Evolving Without Breaking 83](#_Toc215738522)

[Content Negotiation: Serving the Right Representation 83](#_Toc215738523)

[Web Security and Cross-Origin Resource Sharing (CORS) 83](#_Toc215738524)

[Chapter 6 — Scalability in System Design 84](#_Toc215738525)

[Understanding Scalability 84](#_Toc215738526)

[Why Systems Must Scale 84](#_Toc215738527)

[Types of Scalability 84](#_Toc215738528)

[Challenges of Scaling 85](#_Toc215738529)

[Scaling Strategies in Practice 86](#_Toc215738530)

[Cost, Complexity, and Performance Trade-offs 86](#_Toc215738531)

[Real-World Examples 86](#_Toc215738532)

[Auto Scaling in the Cloud 86](#_Toc215738533)

[Monitoring and Cost Optimization 87](#_Toc215738534)

[Chapter 7 — Databases & Storage 88](#_Toc215738535)

[Understanding Data: Structured, Semi-Structured, and Unstructured 88](#_Toc215738536)

[Structured Data 88](#_Toc215738537)

[Semi-Structured Data 88](#_Toc215738538)

[Unstructured Data 89](#_Toc215738539)

[Core Storage Properties 89](#_Toc215738540)

[ACID Transactions 89](#_Toc215738541)

[The Triad of Trade-offs: Scalability, Reliability, and Performance 91](#_Toc215738542)

[CAP Theorem 91](#_Toc215738543)

[CAP Theorem says: pick two! 92](#_Toc215738544)

[Real-World Applications of Storage Models 93](#_Toc215738545)

[Database Models: SQL vs NoSQL 94](#_Toc215738546)

[The Role of Databases in System Design 94](#_Toc215738547)

[Relational Databases (SQL) 94](#_Toc215738548)

[NoSQL Databases 95](#_Toc215738549)

[Polyglot Persistence: The Modern Reality 97](#_Toc215738550)

[Object Storage: The Backbone of Modern Unstructured Data Management 97](#_Toc215738551)

[What is an Object? 98](#_Toc215738552)

[Buckets: Logical Containers for Objects 99](#_Toc215738553)

[Cloud Platforms Leading Object Storage 99](#_Toc215738554)

[Real-World Use Cases 100](#_Toc215738555)

[Performance and Cost Trade-Offs 100](#_Toc215738556)

[Distributed File Systems 101](#_Toc215738557)

[What is a File System? 101](#_Toc215738558)

[Limitations of Traditional File Systems 102](#_Toc215738559)

[What is a Distributed File System (DFS)? 102](#_Toc215738560)

[How Distributed File Systems Work — Architecture Overview 103](#_Toc215738561)

[Strengths of Distributed File Systems 104](#_Toc215738562)

[Big Data Fundamentals 105](#_Toc215738563)

[What is Big Data? 105](#_Toc215738564)

[The Six V’s of Big Data 105](#_Toc215738565)

[Why Traditional Storage Systems Fail 106](#_Toc215738566)

[Common Big Data Workloads 106](#_Toc215738567)

[Data Processing Paradigms: Batch vs Stream 107](#_Toc215738568)

[Batch Processing 107](#_Toc215738569)

[Stream Processing 107](#_Toc215738570)

[Chapter 8 — Messaging, Event-Driven Architecture & Event Sourcing 108](#_Toc215738571)

[Event-Driven Systems Overview 108](#_Toc215738572)

[How Event-Driven Systems Work 108](#_Toc215738573)

[Benefits of Event-Driven Architecture 109](#_Toc215738574)

[Trade-Offs & Considerations 109](#_Toc215738575)

[Event-Driven Systems in the Real World 109](#_Toc215738576)

[Messaging Patterns (Queue vs Pub/Sub) 110](#_Toc215738577)

[Message Queue Pattern (Point-to-Point) 110](#_Toc215738578)

[Publish–Subscribe Pattern (Pub/Sub) 110](#_Toc215738579)

[Key Differences — Queue vs Pub/Sub 111](#_Toc215738580)

[Choosing the Right Pattern 112](#_Toc215738581)

[Message Brokers — Kafka vs RabbitMQ vs Cloud Brokers 112](#_Toc215738582)

[Apache Kafka — High-Throughput Event Streaming 112](#_Toc215738583)

[RabbitMQ — Mature Message Queueing (AMQP) 113](#_Toc215738584)

[Cloud-Native Brokers (Managed Services) 113](#_Toc215738585)

[Delivery Guarantees 114](#_Toc215738586)

[At-Least-Once Delivery 114](#_Toc215738587)

[At-Most-Once Delivery 115](#_Toc215738588)

[Exactly-Once Delivery 115](#_Toc215738589)

[Dead Letter Queues (DLQ), Retry & Backoff 116](#_Toc215738590)

[Dead Letter Queue (DLQ) 116](#_Toc215738591)

[Retry & Backoff Mechanisms 117](#_Toc215738592)

[Recommended Best Practices 117](#_Toc215738593)

[Event-Driven Architecture Models 117](#_Toc215738594)

[Choreography vs Orchestration 118](#_Toc215738595)

[Orchestration — Centralized Control 118](#_Toc215738596)

[Event-Carried State vs Event Notification 119](#_Toc215738597)

[Event Notification — “Something happened” 119](#_Toc215738598)

[Event-Carried State — “Something happened + full data” 120](#_Toc215738599)

[Stream Processing (Kafka Streams, Flink, Kinesis) 120](#_Toc215738600)

[Types of Stream Processing 121](#_Toc215738601)

[Popular Stream Processing Technologies 121](#_Toc215738602)

[Event Sourcing & CQRS 122](#_Toc215738603)

[Event Sourcing: Events as the Source of Truth 122](#_Toc215738604)

[CQRS (Command Query Responsibility Segregation) 123](#_Toc215738605)

[Key Concepts in Event Sourcing 123](#_Toc215738606)

[Where Event Sourcing & CQRS Shine 124](#_Toc215738607)

[Outbox Pattern + Change Data Capture (CDC) 125](#_Toc215738608)

[Outbox Pattern 125](#_Toc215738609)

[Change Data Capture (CDC) 125](#_Toc215738610)

[Outbox Pattern vs CDC 126](#_Toc215738611)

[Real-World Use Cases 126](#_Toc215738612)

[Messaging Protocols (AMQP, MQTT, CloudEvents) 127](#_Toc215738613)

[AMQP (Advanced Message Queuing Protocol) 127](#_Toc215738614)

[MQTT (Message Queuing Telemetry Transport) 128](#_Toc215738615)

[CloudEvents 128](#_Toc215738616)

[When to Use What? 129](#_Toc215738617)

[Chapter 9 — System Performance Engineering 131](#_Toc215738618)

[What is System Performance? 131](#_Toc215738619)

[Latency vs Throughput — The Core Performance Metrics 131](#_Toc215738620)

[Bandwidth 132](#_Toc215738621)

[Bandwidth vs Throughput 132](#_Toc215738622)

[Scalability vs Responsiveness — Understanding the Difference 132](#_Toc215738623)

[SLAs, SLOs, and SLIs — How Performance is Measured and Promised 132](#_Toc215738624)

[Percentiles — Why Averages Lie 133](#_Toc215738625)

[Why Performance Matters — More Than a Technical Metric 133](#_Toc215738626)

[Performance Testing — Preparing Systems for the Real World 133](#_Toc215738627)

[Performance Monitoring — Staying Reliable in Production 134](#_Toc215738628)

[Caching in System Design 134](#_Toc215738629)

[Type of Caching 135](#_Toc215738630)

[Caching Strategies 137](#_Toc215738631)

[Cache Eviction Policies 138](#_Toc215738632)

[Asynchronous Messaging and Message Queues in System Design 139](#_Toc215738633)

[Core Components of a Messaging System 140](#_Toc215738634)

[Real-World Example: Decoupled Microservice Communication 140](#_Toc215738635)

[When Should We Use Message Queues? 141](#_Toc215738636)

[RabbitMQ vs. Kafka: A High-Level Comparison 141](#_Toc215738637)

[Message Delivery Guarantees 142](#_Toc215738638)

[Real-World Use Cases 142](#_Toc215738639)

[Best Practices for Messaging Systems 142](#_Toc215738640)

[Concurrency and Parallelism in System Design 142](#_Toc215738641)

[Concurrency 143](#_Toc215738642)

[Parallelism 143](#_Toc215738643)

[Worker Model 144](#_Toc215738644)

[Race Condition 146](#_Toc215738645)

[Database Performance Optimization 147](#_Toc215738646)

[Data Replication 147](#_Toc215738647)

[Data Redundancy 148](#_Toc215738648)

[Database Scaling 150](#_Toc215738649)

[Database Indexes 151](#_Toc215738650)

[Strong vs Eventual Consistency 152](#_Toc215738651)

[Database Sharding 154](#_Toc215738652)

[Normalization and Denormalization 155](#_Toc215738653)

[Connection Pooling 156](#_Toc215738654)

[Query Optimization 156](#_Toc215738655)

[Materialized Views 156](#_Toc215738656)

[Batching and Pagination 156](#_Toc215738657)

[Chapter 10 — Reliability, High Availability & Disaster Recovery 157](#_Toc215738658)

[Introduction to System Reliability 157](#_Toc215738659)

[Understanding Reliability in System Design 157](#_Toc215738660)

[Measuring Reliability: MTBF and MTTR 157](#_Toc215738661)

[Service-Level Agreements (SLAs) 157](#_Toc215738662)

[Availability vs. Durability 158](#_Toc215738663)

[Reliability in System Architecture 158](#_Toc215738664)

[Reliability Challenges in Distributed Systems 158](#_Toc215738665)

[Improving Reliability in Distributed Environments 158](#_Toc215738666)

[Reliability in Cloud-Native Systems 158](#_Toc215738667)

[High Availability, Redundancy, and Fault Tolerance in System Design 159](#_Toc215738668)

[Redundancy 159](#_Toc215738669)

[Consistent Hashing 160](#_Toc215738670)

[Distributed Consensus 162](#_Toc215738671)

[Distributed Locking 163](#_Toc215738672)

[Gossip Protocol 165](#_Toc215738673)

[Failover 166](#_Toc215738674)

[Checksum 166](#_Toc215738675)

[Resiliency Patterns 167](#_Toc215738676)

[Rate Limiting 167](#_Toc215738677)

[Heart Beat 168](#_Toc215738678)

[Circuit Breaker Pattern 169](#_Toc215738679)

[Backup and Recovery in System Design 171](#_Toc215738680)

[Understanding Backup and Recovery 171](#_Toc215738681)

[Types of Backup Strategies 171](#_Toc215738682)

[Recovery Models 172](#_Toc215738683)

[Recovery Objectives: RTO and RPO 172](#_Toc215738684)

[Trade-Offs in Backup Strategy Design 172](#_Toc215738685)

[Best Practices for Backup and Recovery 173](#_Toc215738686)

[Disaster Recovery in System Design 173](#_Toc215738687)

[Chapter 11 — Security & Threat Modeling 175](#_Toc215738688)

[Introduction to Security in System Design 175](#_Toc215738689)

[Authentication 176](#_Toc215738690)

[Basic Authentication 176](#_Toc215738691)

[Bearer Token Authentication (Opaque Tokens) 176](#_Toc215738692)

[JWT (JSON Web Token) Authentication 177](#_Toc215738693)

[OAuth 2.0 178](#_Toc215738694)

[OpenID Connect (OIDC) 178](#_Toc215738695)

[Single Sign-On (SSO) 179](#_Toc215738696)

[SCIM (System for Cross-domain Identity Management) 179](#_Toc215738697)

[Security and Implementation Best Practices 180](#_Toc215738698)

[IdentityServer Token Storage and Revocation 180](#_Toc215738699)

[Authorization 181](#_Toc215738700)

[Role-Based Access Control (RBAC) 181](#_Toc215738701)

[Attribute-Based Access Control (ABAC) 182](#_Toc215738702)

[Policy-Based Access Control (PBAC) 182](#_Toc215738703)

[Rule-Based Access Control 182](#_Toc215738704)

[Discretionary Access Control (DAC) 182](#_Toc215738705)

[Mandatory Access Control (MAC) 183](#_Toc215738706)

[Summary Table 183](#_Toc215738707)

[Data Protection and Secure Communication 183](#_Toc215738708)

[Why Data Protection Matters 183](#_Toc215738709)

[Understanding Encryption 184](#_Toc215738710)

[Encryption at Rest and In Transit 184](#_Toc215738711)

[Symmetric vs Asymmetric Encryption 185](#_Toc215738712)

[TLS/SSL and HTTPS: Securing Communication Channels 185](#_Toc215738713)

[Password Protection: Hashing and Salting 186](#_Toc215738714)

[Public Key Infrastructure (PKI) 186](#_Toc215738715)

[API Security and Hardening 187](#_Toc215738716)

[Security Integration Across the Software Development Life Cycle (SDLC) 188](#_Toc215738717)

[Requirements Phase 188](#_Toc215738718)

[Design Phase 188](#_Toc215738719)

[Development Phase 188](#_Toc215738720)

[Testing Phase 188](#_Toc215738721)

[Deployment Phase 188](#_Toc215738722)

[Maintenance Phase 188](#_Toc215738723)

[Understanding Threats, Attack Vectors, and Mitigation Strategies 188](#_Toc215738724)

[Injection Attacks 189](#_Toc215738725)

[Cross-Site Scripting (XSS) 190](#_Toc215738726)

[Cross-Site Request Forgery (CSRF) 191](#_Toc215738727)

[CORS (Cross-Origin Resource Sharing) 192](#_Toc215738728)

[Server-Side Request Forgery (SSRF) 192](#_Toc215738729)

[DDoS Attacks (Distributed Denial of Service) 193](#_Toc215738730)

[Network and Infrastructure Security 196](#_Toc215738731)

[Why Network Security Matters 196](#_Toc215738732)

[Firewalls and Reverse Proxies 196](#_Toc215738733)

[Protecting APIs and Backend Systems 197](#_Toc215738734)

[Network Segmentation and Isolation 198](#_Toc215738735)

[The Zero Trust Security Model 198](#_Toc215738736)

[Securing Cloud Environments 199](#_Toc215738737)

[Securing Serverless and Containerized Workloads 199](#_Toc215738738)

[Security in Microservices Architecture 199](#_Toc215738739)

[Chapter 12 — Observability & Monitoring 200](#_Toc215738740)

[Logging 200](#_Toc215738741)

[Metrics 201](#_Toc215738742)

[Tracing 201](#_Toc215738743)

[Distributed Debugging 202](#_Toc215738744)

[Distributed Tracing 202](#_Toc215738745)

[Alerting & Dashboards 205](#_Toc215738746)

[Health Checks 205](#_Toc215738747)

[Chapter 13 — Distributed Transactions & Idempotency 206](#_Toc215738748)

[Why Distributed Transactions Are Hard 206](#_Toc215738749)

[Core Challenges in Distributed Transactions 206](#_Toc215738750)

[Two-Phase Commit (2PC) 208](#_Toc215738751)

[How 2PC Works 208](#_Toc215738752)

[Real-World Use Case 209](#_Toc215738753)

[Advantages of 2PC 209](#_Toc215738754)

[Limitations of 2PC 209](#_Toc215738755)

[Three-Phase Commit: An Improvement? 210](#_Toc215738756)

[Why 2PC is Rare in Microservices 210](#_Toc215738757)

[When 2PC Still Makes Sense 210](#_Toc215738758)

[Sagas (Choreography & Orchestration) 211](#_Toc215738759)

[Why Sagas Exist 211](#_Toc215738760)

[How a Saga Works 211](#_Toc215738761)

[Saga Execution Models 212](#_Toc215738762)

[Compensation: The Core of Sagas 213](#_Toc215738763)

[Saga Failure Handling 214](#_Toc215738764)

[When Should You Use Sagas? 214](#_Toc215738765)

[Outbox Pattern 214](#_Toc215738766)

[How the Outbox Pattern Works 215](#_Toc215738767)

[Key Characteristics 215](#_Toc215738768)

[Outbox with Change Data Capture (CDC) 216](#_Toc215738769)

[Supporting Idempotency 216](#_Toc215738770)

[Benefits of the Outbox Pattern 217](#_Toc215738771)

[Operational Considerations 217](#_Toc215738772)

[When to Use Outbox Pattern 217](#_Toc215738773)

[Idempotent APIs 217](#_Toc215738774)

[Why Idempotency Matters in Distributed Systems? 218](#_Toc215738775)

[Idempotent vs. Non-Idempotent HTTP Methods 218](#_Toc215738776)

[How API Requests Get Duplicated? 218](#_Toc215738777)

[Idempotency Strategies 219](#_Toc215738778)

[Idempotency in Event-Driven Architecture 220](#_Toc215738779)

[When to Use Idempotency? 221](#_Toc215738780)

[Exactly-Once Processing Strategies 221](#_Toc215738781)

[Common Exactly-Once Processing Strategies 222](#_Toc215738782)

[Combining Strategies for Strong Guarantees 224](#_Toc215738783)

[Chapter 14 — Deployment, DevOps & CI/CD 225](#_Toc215738784)

[Containers 225](#_Toc215738785)

[The bad old days 225](#_Toc215738786)

[VMware 225](#_Toc215738787)

[Containers 226](#_Toc215738788)

[Docker 226](#_Toc215738789)

[Docker Architecture 228](#_Toc215738790)

[Images 229](#_Toc215738791)

[Docker Compose 230](#_Toc215738792)

[Kubernetes Basics 230](#_Toc215738793)

[Kubernetes Core Building Blocks 231](#_Toc215738794)

[Key Self-Healing Capabilities 231](#_Toc215738795)

[CI/CD Pipelines 231](#_Toc215738796)

[Continuous Integration (CI) 231](#_Toc215738797)

[Continuous Delivery / Deployment (CD) 232](#_Toc215738798)

[Blue-Green & Canary Deployments 232](#_Toc215738799)

[Infrastructure as Code (Terraform, CloudFormation) 233](#_Toc215738800)

[Chapter 15 — Distributed Counter System 236](#_Toc215738801)

[Overview 236](#_Toc215738802)

[Requirements 236](#_Toc215738803)

[Functional Requirements 237](#_Toc215738804)

[Non-Functional Requirements 237](#_Toc215738805)

[Design Considerations 237](#_Toc215738806)

[Data Storage and Retention 238](#_Toc215738807)

[Security and Abuse Protection 239](#_Toc215738808)

[Solution Approaches 239](#_Toc215738809)

[High-level Architecture (components & flow) 245](#_Toc215738810)

[Database Design 246](#_Toc215738811)

[API Design 246](#_Toc215738812)

[Chapter 16 — URL Shortener 250](#_Toc215738813)

[Overview 250](#_Toc215738814)

[Requirements 250](#_Toc215738815)

[Functional Requirements 250](#_Toc215738816)

[Non-Functional Requirements 251](#_Toc215738817)

[Design Considerations 251](#_Toc215738818)

[Encoding Scheme 252](#_Toc215738819)

[Data Storage and Retention 252](#_Toc215738820)

[Security and Abuse Prevention 253](#_Toc215738821)

[Solution Approaches 253](#_Toc215738822)

[High-level Architecture (components & flow) 257](#_Toc215738823)

[Database Design 257](#_Toc215738824)

[API Design 259](#_Toc215738825)

[Chapter 17 — Gist System 262](#_Toc215738826)

[Overview 262](#_Toc215738827)

[Requirements 262](#_Toc215738828)

[Functional Requirements 262](#_Toc215738829)

[Non-Functional Requirements 262](#_Toc215738830)

[Design Considerations 264](#_Toc215738831)

[Slug Generation 264](#_Toc215738832)

[Data Storage and Retention 265](#_Toc215738833)

[Caching Strategy 266](#_Toc215738834)

[Security and Abuse Prevention 266](#_Toc215738835)

[Solution Approaches 267](#_Toc215738836)

[High-Level Architecture 271](#_Toc215738837)

[Database Design 271](#_Toc215738838)

[API Design (RESTful) 273](#_Toc215738839)

[Monitoring, Metrics & Alerts 276](#_Toc215738840)

[Chapter 18 — Email Template Management 277](#_Toc215738841)

[Overview 277](#_Toc215738842)

[Requirements 277](#_Toc215738843)

[Functional Requirements 277](#_Toc215738844)

[Non-Functional Requirements 278](#_Toc215738845)

[Design Considerations 280](#_Toc215738846)

[Template Identifier Design 280](#_Toc215738847)

[Localization Strategy 280](#_Toc215738848)

[Template Override Management 280](#_Toc215738849)

[Data Storage and Retention 280](#_Toc215738850)

[Caching Strategy 282](#_Toc215738851)

[Security and Abuse Prevention 284](#_Toc215738852)

[Solution Approaches 284](#_Toc215738853)

[High-Level Architecture 290](#_Toc215738854)

[Database Design 290](#_Toc215738855)

[API Design (RESTful) 293](#_Toc215738856)

[Monitoring, Metrics & Alerts 296](#_Toc215738857)

[Chapter 19 — Email Provider & Sender 298](#_Toc215738858)

[Overview 298](#_Toc215738859)

[Requirements 298](#_Toc215738860)

[Functional Requirements 298](#_Toc215738861)

[Non-Functional Requirements 299](#_Toc215738862)

[Design Considerations 301](#_Toc215738863)

[Service Responsibility Segregation 301](#_Toc215738864)

[Data Storage Architecture 301](#_Toc215738865)

[Queue-Driven Processing Strategy 302](#_Toc215738866)

[Provider Connector Architecture 302](#_Toc215738867)

[Caching Strategy 304](#_Toc215738868)

[Attachment Handling Strategy 304](#_Toc215738869)

[Async Dispatch Flow 304](#_Toc215738870)

[Operational Concerns 305](#_Toc215738871)

[High-Level Architecture 306](#_Toc215738872)

[Database Design 306](#_Toc215738873)

[API Design (RESTful) 311](#_Toc215738874)

[Auth Service — API Specification 311](#_Toc215738875)

[Email Service — API Specification 313](#_Toc215738876)

[Chapter 20 — News Feed System 317](#_Toc215738877)

[Overview 317](#_Toc215738878)

[Requirements 318](#_Toc215738879)

[Functional Requirements 318](#_Toc215738880)

[Non-Functional Requirements 318](#_Toc215738881)

[Design Considerations 319](#_Toc215738882)

[Feed Storage and Fan-out 319](#_Toc215738883)

[Data Model and Storage 320](#_Toc215738884)

[Caching Strategy 320](#_Toc215738885)

[Personalization & Ranking 321](#_Toc215738886)

[Performance & Scalability 321](#_Toc215738887)

[Security and Abuse Prevention 321](#_Toc215738888)

[High-level Architecture (components & flow) 321](#_Toc215738889)

[Database Design 322](#_Toc215738890)

[User Service Database Design 322](#_Toc215738891)

[Post Service Database Design 323](#_Toc215738892)

[Relationship Service Database Design 323](#_Toc215738893)

[Engagement Service Database Design 324](#_Toc215738894)

[Notification Service Database Design 325](#_Toc215738895)

[Ranking Service Database Design 325](#_Toc215738896)

[API Design (RESTful) — Endpoint specification 326](#_Toc215738897)

[User Service 326](#_Toc215738898)

[Post Service 327](#_Toc215738899)

[Relationship Service 328](#_Toc215738900)

[Engagement Service 328](#_Toc215738901)

[Notification Service 329](#_Toc215738902)

[Ranking Service 330](#_Toc215738903)

[Chapter 21 — Video Sharing 331](#_Toc215738904)

[Overview 331](#_Toc215738905)

[Requirements 333](#_Toc215738906)

[Functional Requirements 333](#_Toc215738907)

[Non-Functional Requirements 333](#_Toc215738908)

[Design Considerations 334](#_Toc215738909)

[Video Ingest & Processing Pipeline 334](#_Toc215738910)

[Storage & Streaming Delivery 335](#_Toc215738911)

[Engagement & Notification Streams 336](#_Toc215738912)

[Feed Personalization & Recommendations 336](#_Toc215738913)

[Caching Strategy 336](#_Toc215738914)

[Moderation & Compliance 337](#_Toc215738915)

[Security & Abuse Prevention 337](#_Toc215738916)

[Reliability & High Availability Architecture 337](#_Toc215738917)

[Cost Optimization Strategies 337](#_Toc215738918)

[High-level Architecture (components & flow) 338](#_Toc215738919)

[Database Design 338](#_Toc215738920)

[User Service Database Design 338](#_Toc215738921)

[Upload Service Database Design 339](#_Toc215738922)

[Relationship Service Database Design 340](#_Toc215738923)

[Engagement Service Database Design 341](#_Toc215738924)

[Timeline Service Database Design 342](#_Toc215738925)

[Notification Service Database Design 342](#_Toc215738926)

[API Design (RESTful) — Endpoint specification 343](#_Toc215738927)

[User Service APIs 343](#_Toc215738928)

[Upload Service APIs 345](#_Toc215738929)

[Relationship Service APIs 346](#_Toc215738930)

[Engagement Service APIs 347](#_Toc215738931)

[Timeline Service APIs 348](#_Toc215738932)

[Notification Service APIs 349](#_Toc215738933)

[Chapter 22 — Chat System 351](#_Toc215738934)

[Overview 351](#_Toc215738935)

[Requirements 352](#_Toc215738936)

[Functional Requirements 352](#_Toc215738937)

[Non-Functional Requirements 352](#_Toc215738938)

[Design Considerations 353](#_Toc215738939)

[Connection Layer 353](#_Toc215738940)

[Storage Architecture 353](#_Toc215738941)

[Consistency & Durability Strategy 353](#_Toc215738942)

[Security & Abuse Prevention 354](#_Toc215738943)

[Reliability & High Availability Architecture 354](#_Toc215738944)

[Cost Optimization Strategies 354](#_Toc215738945)

[High-level Architecture (components & flow) 354](#_Toc215738946)

[Database Design 354](#_Toc215738947)

[User Service Database Design users 354](#_Toc215738948)

[Devices Database Design devices 355](#_Toc215738949)

[Conversation Service Database Design 355](#_Toc215738950)

[Messaging Service Database Design 355](#_Toc215738951)

[Delivery Receipt Database Design 355](#_Toc215738952)

[Attachment Database Design 356](#_Toc215738953)

[API Design (RESTful) — Endpoint specification 356](#_Toc215738954)

[User Service APIs 356](#_Toc215738955)

[Device Service APIs 356](#_Toc215738956)

[Messaging APIs 356](#_Toc215738957)

[Conversation & Group APIs 356](#_Toc215738958)

[Presence APIs 356](#_Toc215738959)

[E2EE Key APIs 357](#_Toc215738960)

[Notification APIs 357](#_Toc215738961)

[Chapter 23 — **Notification** System 358](#_Toc215738962)

[Overview 358](#_Toc215738963)

[Requirements 359](#_Toc215738964)

[Functional Requirements 359](#_Toc215738965)

[Non-Functional Requirements 359](#_Toc215738966)

[Design Considerations 360](#_Toc215738967)

[High-level Architecture (components & flow) 361](#_Toc215738968)

[Database Design 361](#_Toc215738969)

[User Preferences Database Design 361](#_Toc215738970)

[Templates Database Design 361](#_Toc215738971)

[Event & Notification Mapping Database Design 362](#_Toc215738972)

[Notification Logs Database Design 362](#_Toc215738973)

[DLQ Storage Design 363](#_Toc215738974)

[Provider Configuration Database Design 363](#_Toc215738975)

[Channel Queue Metadata (Optional) 363](#_Toc215738976)

[Ad-hoc Notification Requests 364](#_Toc215738977)

[User Locale & Regional Rules 364](#_Toc215738978)

[Notification Preference Overrides (Per Event) 364](#_Toc215738979)

[API Design (RESTful) — Endpoint specification 365](#_Toc215738980)

[Event Ingestion Service APIs 365](#_Toc215738981)

[Notification Orchestrator Service APIs 366](#_Toc215738982)

[Preferences Service APIs 367](#_Toc215738983)

[Template Management Service APIs 369](#_Toc215738984)

[Delivery Provider Callback APIs 370](#_Toc215738985)

[DLQ & Retry Management APIs 371](#_Toc215738986)

[Metrics & Audit APIs 371](#_Toc215738987)

[Chapter 24 — **Cloud File Storage** System 373](#_Toc215738988)

[Overview 373](#_Toc215738989)

[Requirements 374](#_Toc215738990)

[Functional Requirements 374](#_Toc215738991)

[Non-Functional Requirements 374](#_Toc215738992)

[Design Considerations 375](#_Toc215738993)

[High-level Architecture (components & flow) 377](#_Toc215738994)

[Database Design 377](#_Toc215738995)

[API Design (RESTful) — Endpoint specification 380](#_Toc215738996)

[File Management Service APIs 380](#_Toc215738997)

[Upload Service / Chunk Manager APIs 382](#_Toc215738998)

[Sync Service APIs 382](#_Toc215738999)

[Sharing & ACL APIs 383](#_Toc215739000)

[Versioning APIs 383](#_Toc215739001)

[Search APIs 383](#_Toc215739002)

[Audit APIs 383](#_Toc215739003)

[Chapter 25 — **Online Rental Platform** 384](#_Toc215739004)

[Overview 384](#_Toc215739005)

[Requirements 385](#_Toc215739006)

[Functional Requirements 385](#_Toc215739007)

[Non-Functional Requirements 385](#_Toc215739008)

[Design Constraints 386](#_Toc215739009)

[High-level Architecture (components & flow) 387](#_Toc215739010)

[Database Design 387](#_Toc215739011)

[API Design (RESTful) — Endpoint specification 391](#_Toc215739012)

[Authentication & Identity Service APIs 391](#_Toc215739013)

[Listing Service APIs 391](#_Toc215739014)

[Search Service APIs 392](#_Toc215739015)

[Availability & Calendar APIs 392](#_Toc215739016)

[Booking Service APIs 392](#_Toc215739017)

[Payment Service APIs 393](#_Toc215739018)

[Reviews Service APIs 393](#_Toc215739019)

[Notification Service APIs 393](#_Toc215739020)

[Admin & Moderation APIs 394](#_Toc215739021)

[Chapter 26 — **Auction Platform System** 395](#_Toc215739022)

[Chapter 27 — **Ticketing System** 402](#_Toc215739023)

[Chapter 28 — **E‑commerce Marketplace System** 409](#_Toc215739024)

[Chapter 29 — **Hotel Booking System** 416](#_Toc215739025)

[Chapter 30 — **Taxi Hailing System** 424](#_Toc215739026)

[Chapter 31 — **Collaborative Document Editor** 430](#_Toc215739027)

[Chapter 32 — **Parking Lot System** 436](#_Toc215739028)

[Overview 436](#_Toc215739029)

[Chapter 33 — Web Crawler System 441](#_Toc215739030)

[Overview 441](#_Toc215739031)

[Chapter 34 — Search Engine System 445](#_Toc215739032)

[Overview 445](#_Toc215739033)

[Requirements 445](#_Toc215739034)

[Functional Requirements 445](#_Toc215739035)

[Non-Functional Requirements 445](#_Toc215739036)

# **Section 1:** Fundamentals of System Design

This section introduces the core principles that form the foundation of scalable and high-performance system architecture. We begin by understanding what system design means and why it is essential for building applications that can grow with user demand. Key concepts such as scalability, availability, latency, throughput, fault tolerance, consistency, and reliability are explored in depth to help establish a strong architectural mindset.

We also discuss the differences between monolithic and microservices architectures, how distributed systems operate, and the importance of designing for failures rather than assuming everything will always work correctly. Real-world examples and simple architectural patterns are used to help visualize how components communicate, store data, and interact under load.

By mastering these fundamental concepts, readers gain a solid foundation that prepares them for tackling complex design challenges and making informed engineering decisions throughout system development.

# Chapter 1 — Introduction to System Design

This chapter establishes the foundation for the entire book. It begins by defining **System Design** and explaining its critical role in modern software engineering. The core focus is on introducing the four fundamental **Non-Functional Requirements (NFRs)—Scalability**, **Reliability**, **Performance**, and **Maintainability**—which serve as the guiding principles and trade-off considerations for every architectural decision made throughout the book.

## What is System Design?

System design is the **process of defining the architecture, components, modules, data flows, and interfaces of a software system** to meet specific functional and non-functional requirements. It is the blueprint that determines how a system will work, how its parts interact, and how it will handle scale, reliability, and performance challenges.

System Design provides an overview of a system, product, service, or process. It’s a generic system design that includes the system architecture, database design, and a brief description of systems, services, platforms, and relationships among modules. It involves making high-level decisions about scalability, reliability, performance, and maintainability.

System design at its core is the process of defining how a system should be structured, which includes its overall architecture, what all components should be there, how many modules should be there in the system, how the interfaces should look like, how the data should flow between the modules and components to meet any specific requirement.

But system design isn't just about drawing the diagrams on a whiteboard or on a document. It is more about critically thinking and designing the high-level architecture, taking those high-level decisions that impact not just the functional, but also the non-functional requirements of an application. Non-functional requirements like scalability, reliability, performance and maintainability of a system.

Think about the applications that we use every day. Are these applications scalable? I think so most of the applications that we use are scalable. They are distributed. They probably have huge databases. They are running on some cloud infrastructure and behind each of these applications, there is a well thought out system design that somebody must have done before creating the application, and probably somebody is still thinking about system design to tackle the new scalability, performance and caching related issues. A good system design ensures that your system runs efficiently, it handles massive loads and it automatically recovers from failures smoothly.

## Why is System Design Important?

Now let's talk about why system design is important. It's actually a very critical skill for building scalable, reliable, and efficient software systems. So, let's look at some of the key reasons why the system design actually matters.

The first reason is that it will help you in building scalable and reliable systems. Think about modern applications we are using daily. These platforms handle millions, even billions of users without any problem. A good system design is crucial for such systems. Without a good design, they will crash under heavy load. A well-designed system ensures high availability, fault tolerance, and performance optimizations so that the applications can scale seamlessly. Learning about system design gives you the ammunition to create such scalable applications.

The second is architectural thinking. When you study system design, you are actually going beyond coding. You are thinking at an architectural level. I mean, don't get me wrong, writing efficient code is important, but real-world engineering problems go beyond just writing code. System design helps engineers think at an architectural level. It allows you to make trade-offs like choosing between SQL or NoSQL microservices or monolith, or balancing between consistency or availability. And understanding these concepts will make you a better engineer.

System design is about solving real world engineering challenges. When you truly understand what system design is, why systems are designed in a certain way, then only you will be able to design good systems. Engineers must learn to balance scalability, cost, speed and complexity to achieve their functional and non-functional requirements. At that point of time, for example, choosing a SQL or NoSQL, it isn't about a personal preference. It depends on the functional and non-functional requirements of the application. So informed trade-offs is one of the things that system design learning system design will help you in.

And finally, future proofing the systems. We know that the technology is constantly evolving. Poorly designed systems become bottlenecks over time. A well-designed system, on the other hand, can adapt to growing traffic, new features and emerging technologies. Companies like Netflix and eBay started with monolithic architecture, but later transition to microservices as they scaled by learning system design as a skill, not just as a checklist.

## The Core Pillars of System Design

Every design decision is a trade-off against these four foundational requirements, often referred to as **Non-Functional Requirements (NFRs)**:

### Scalability

The ability of a system to handle a growing amount of work by adding resources. Scalability ensures that as the user base or data volume increases, the system's performance remains acceptable.

- **Horizontal Scaling (Scale Out):** Adding more machines (servers) to the pool. This is generally preferred in cloud environments as it is cheap and virtually unlimited.
- **Vertical Scaling (Scale Up):** Increasing the capacity of a single machine (e.g., adding more CPU, RAM, or faster disk). This hits physical and financial limits quickly.

### Reliability (Availability)

Reliability is the ability of a system to perform its required functions under stated conditions for a specified period of time. **Availability** is a key measurement of reliability, often expressed as the percentage of time the system is operational and accessible (e.g., "five nines" or **99.999%**). Achieving high reliability involves redundancy, fault tolerance, and effective disaster recovery planning.

### Performance

Measured by how quickly the system responds to a user request. Performance is typically quantified by:

- **Latency:** The delay before a transfer of data begins following an instruction for its transfer. Measured in milliseconds (ms) or microseconds ($\\mu s$). Lower latency is always better.
- **Throughput:** The amount of work the system can process in a given period, often measured in **Requests Per Second (RPS)** or transactions per second.

### Maintainability

The ease with which the system can be modified, monitored, and repaired. High maintainability reduces operational costs and speeds up development. Key aspects include:

- **Simplicity:** Keeping the architecture and codebase easy to understand.
- **Operability:** The ease of running and monitoring the system, including robust logging, monitoring, and alerting capabilities.
- **Evolvability:** The ability to make changes with minimal side effects.

## Functional vs Non-Functional Requirements

In any software system, the success of the final product is determined by how well it meets user needs and design expectations. These needs are captured as **requirements**, which serve as the foundation for architecture, development, testing, and validation. Requirements are broadly categorized into **Functional Requirements** and **Non-Functional Requirements**, and understanding the difference between them is essential for building scalable, usable, and maintainable systems.

### Functional Requirements

Functional requirements describe **what the system should do** — the core business features and capabilities. They define the expected behavior of the system under specific conditions and specify **interactions between users and the system**.

These requirements answer questions like:

- What features must the system provide?
- How should the system respond to a particular input?
- What business rules must be followed?

Functional requirements are typically derived from business use cases, workflow analysis, and customer expectations.

**Examples**

- A user shall be able to create, update, and delete their profile.
- The system must send a confirmation email after successful registration.
- The system must support payment transactions using a credit card or UPI.
- A search feature must return relevant results based on input keywords.

**Importance in System Design**

Functional requirements define system scope and guide:

- API design and endpoint definitions
- Data models and database structure
- Integration with external services
- End-to-end workflow implementation

Without well-defined functional requirements, the system may deliver incomplete or incorrect features, leading to user dissatisfaction.

### Non-Functional Requirements (NFRs)

Non-functional requirements specify **how the system should operate** rather than what it should do. They focus on system attributes such as performance, scalability, reliability, usability, security, and maintainability.

NFRs create **quality benchmarks** for evaluating the system’s behavior under different conditions. Even if functional requirements are fully satisfied, the system can still fail if NFRs are ignored — for example, a payment system that crashes during high traffic or loads slowly during checkout will be unacceptable to users.

**Common Categories of NFRs**

| **Category** | **Description** | **Examples** |
| --- | --- | --- |
| **Performance** | Speed & responsiveness of the system | API response time < 200ms |
| **Scalability** | Ability to handle growth in users or data | Auto-scale services during peak hours |
| **Reliability** | System availability and fault tolerance | 99.99% uptime SLA |
| **Security** | Protection against unauthorized access | Data encryption at rest & in transit |
| **Usability** | Ease of use for end-users | Accessible UI for differently-abled users |
| **Maintainability** | Ease of debugging, updates, enhancements | Modular code with clear documentation |
| **Compliance** | Standards, legal and policy adherence | GDPR, PCI-DSS conformity |
| **Observability** | Monitoring, logging, alerts | Distributed tracing for microservices |

### Why Both Requirements Matter

System design requires a **holistic understanding** of both requirement types:

| **Functional** | **Non-Functional** |
| --- | --- |
| Defines _what_ the system does | Defines _how well_ it performs |
| Directly visible to users | Often invisible until something goes wrong |
| Helps complete features | Ensures system quality and user satisfaction |

A well-designed system balances both — delivering the right features **with high quality**.

### Real-World Example: E-Commerce Website

| **Aspect** | **Functional Requirement** | **Non-Functional Requirement** |
| --- | --- | --- |
| Checkout Process | User must be able to purchase products | Checkout should complete within 3 seconds |
| Search Feature | User can filter products by category | Search results should appear within 100ms |
| Payment Security | Support for online transactions | Must comply with PCI-DSS standards |
| System Availability | Login & browsing features | Service available 24/7 with auto-recovery |

Even if the website enables product purchases (functional), poor speed or security (NFR failures) will harm the business.

## System Design Methodology

Designing a large-scale system is not a single-step activity but a structured and iterative process. A robust methodology ensures that engineers move from **problem understanding** to **architectural decisions** with clarity and confidence. This methodology allows designers to balance requirements, scalability goals, cost constraints, and long-term reliability.

The stages described below are widely applied in technical interviews as well as real-world architecture planning.

### Requirement Clarification

The first and most important step in system design is understanding the problem clearly. Misinterpreting requirements leads to incorrect solutions, wasted effort, technical debt, and unhappy stakeholders.

During clarification, engineers seek answers to questions like:

- Who are the target users?
- What are the core features and business rules?
- What are the expectations about scale, performance, security, and reliability?
- Which parts of the system are real-time vs. batch?
- What constraints already exist (technology, budget, compliance)?

This step ensures alignment between what stakeholders **want** and what engineers **plan** to build. Before moving forward, all assumptions must be validated.

**Output of Requirement Clarification**

- Finalized functional and non-functional requirements
- Defined scope and constraints
- User interaction and workflow understanding

### High-Level Architecture Thinking

Once requirements are clear, architects begin to shape the **overall structure** of the system. This includes defining the major system components and how they interact.

Key decisions at this stage:

- Monolithic vs. Microservices architecture
- Database choices (SQL vs. NoSQL)
- Communication patterns (REST, gRPC, event-driven)
- Load balancing approach
- Caching strategy
- External service integrations

High-level architecture avoids technical depth initially and focuses on building a **conceptual blueprint**. The goal is to ensure the design meets performance and scalability expectations while remaining maintainable.

**Typical Deliverables**

- Architecture diagrams
- Component responsibilities
- Technology stack overview

### Back-of-the-Envelope Estimation

This step involves doing quick, rough calculations to validate whether the architecture can handle the expected load. These estimates guide infrastructure size, data partitioning, caching strategies, and API scaling.

Common estimation tasks:

- Traffic volume projections (Requests per second)
- Data storage growth (Daily / Monthly)
- Peak concurrency estimates
- Network bandwidth and latency calculations
- Cache hit rate assumptions

These calculations don’t need perfect precision — only enough insight to avoid disastrous bottlenecks when the system grows.

Example:  
If a system expects 10 million daily active users, the design must proactively plan for:

- Sharding databases
- CDN usage for static content
- Distributed caching

Estimation enables **capacity planning** and early **scalability thinking**.

### Evaluating Trade-offs

Every architectural decision includes compromises. Increasing performance may raise cost. Improving availability may add operational complexity. Choosing consistency might reduce latency.

Engineers must weigh alternatives using:

- **CAP Theorem** (Consistency, Availability, Partition Tolerance)
- **Latency vs. Throughput** goals
- Operational complexity vs. developer productivity
- Costs vs. performance benefits

Examples:

- Eventual consistency enables high availability and low latency.
- Strong consistency may require slower synchronous replication.

Making informed trade-offs prevents over-engineering and ensures the system remains efficient and sustainable.

**Key Consideration Areas**

- Performance vs. Cost
- Scalability vs. Simplicity
- Reliability/Availability vs. Maintenance overhead
- Time-to-market vs. Ideal design perfection

### Designing for Failure

Real-world systems fail — servers crash, networks disconnect, data corrupts, traffic spikes, software bugs escape into production. A good architecture **anticipates** failure instead of reacting to it.

Design principles to handle failure gracefully:

- Redundancy: Multiple replicas of critical services
- Fault isolation: Prevent failure in one component from cascading
- Circuit breakers: Stop repeated requests to a failing service
- Auto-scaling: Handle sudden load increase
- Retry with exponential backoff
- Chaos engineering: Test resilience deliberately

Monitoring, logging, and alerting are key to ensuring failures are detected early and resolved quickly. The system should always aim for **graceful degradation** — even if one part fails, the entire service should not collapse.

# Chapter 2 — Networking Foundations

All large-scale distributed systems rely on the internet's core protocols. This chapter explores the underlying networking concepts necessary for system design, including the Client-Server Model and the purpose of IP Addresses (IPv4 and IPv6). Crucially, it details essential services like DNS (Domain Name System), NAT (Network Address Translation), and VPCs (Virtual Private Clouds), concluding with an analysis of key performance metrics like Latency, Throughput, and Bandwidth.

## Networking & Communication

designing scalable and efficient systems by understanding the key networking and communication principles. Networking and communications are at the core of every large-scale system. Whether you are designing a web application, a distributed system, or a cloud-based service, your system components must efficiently communicate with each other. Without a strong grasp on networking fundamentals, it is impossible to build scalable, reliable, and high-performance systems.

In this chapter, we will break down fundamental networking concepts like IP addresses, DNS, client server, communication proxies, load balancing, API gateway, content delivery networks and all these concepts are essential for both real world system design problems. By the end of this chapter, you will have a solid understanding of how networking plays a crucial role in system design, enabling you to make informed architectural decisions.

Now let's try to understand why networking matters in system design. Imagine using applications like Netflix, WhatsApp, or Amazon. Every time you're streaming a movie on Netflix, you are sending a message on WhatsApp or you are placing an order on Amazon. Millions and millions of data packets are traveling across the network to make that happen seamlessly. This is why networking is a critical component of system design. Every application is made up of multiple components, and at its core, every system relies on data exchange between these components, whether it's a request from a mobile app to a back-end server or communication between distributed microservices, networking ensures that the data flows efficiently.

Second, a well-designed network infrastructure allows the system to scale to handle millions of users. Stays reliable under heavy traffic, and maintain high performance and low latency even with the high traffic. Without effective networking, even the best designed applications can suffer from downtime and slow response times.

Third, there are four key areas in system design. Let's start with communication. Ensuring smooth data transfer between clients and servers, and application servers and databases is the critical aspect of networking. Second is load balancing. Nowadays, we have multiple servers hosting our applications on the internet. Distributing traffic efficiently to prevent an overload on a single server is all about load balancing. Lensing, and that's where the networking related concepts related to load balancing are going to help us. Third, security, we need to protect our servers from unauthorized access and cyber threat. And that's where security related networking protocols and concepts will help us. And finally, efficiency optimizing network performance is to reduce latency and improve user experience is the fundamental point of efficiency in the network design that we do.

Understanding these concepts will help us in designing the systems that are robust, scalable, and secure. So how networking impacts large scale systems. Have you ever wondered how companies like Netflix, Amazon, or Google handle millions of users at the same time without crashing? The answer lies in efficient networking at scale. A system must serve millions, sometimes billions, of users in real time.

Networking ensures that the requests are distributed trade efficiently across servers, preventing bottlenecks and system failures. Without robust networking, even the most powerful application would struggle under the high traffic.

In a large-scale system, data is constantly flowing, whether it is retrieving product details from the database, sending messages in a chat application, or loading a web page. Optimized networking ensures minimal delays and keeping user experience smooth and seamless.

Latency is the time it takes for data to travel between systems. The lower the latency, the better the performance. Networking strategies like CDNs, caching and load balancing help reduce delays and improve resilience, ensuring system stays operational even during the failures. And finally, the cloud computing and distributed system offerings from the cloud computing. Modern applications run on cloud based and distributed architecture, whether it's microservices, communicating over APIs or global user accessing data from a different region, Gene networking will ensure that everything works together efficiently across different data canters and cloud providers.

## Understanding IP Addresses

Imagine trying to send a letter without an address, the Postal Service wouldn't know where to deliver it and your letter would never reach its destination. The same principle applies to the internet. Every device needs an address to send and receive data. This is where IP addresses come in picture.

Why does it matter to understand about IP addresses? Well, whether we are designing a distributed system, working with cloud infrastructure, understanding IP addressing is essential. Every online service, be it Netflix, Amazon or even a simple website relies on a well-structured IP management system to ensure seamless communication and scalability. So, let's get started by first understanding what an IP address is and why it is so important in networking. So, every time you open a website, sends an email or stream a video, your device is communicating with other machines across the internet. But how does it know where to send this request? The answer lies in IP address.

So, what is an IP address? An IP address or Internet protocol address is a unique identifier assigned to every device connected to the internet. Just like your home is an address, your mail carriers find you using that home address. Your computer also has an IP address, which allow computers, servers, and other devices to locate and communicate with each other when they are connected to the internet.

Why are IP addresses important? Without IP addresses, there would be no way to send or receive data online. They are the foundation of all networking. They enable devices to exchange information seamlessly. There are primarily two versions of IP addresses IP version four and IP version six, and they can be classified as public IP and private IP.

Here is a simple diagram of a network. Each device in the network here as an IP address, be it a computer be it a printer, be it a server, or if there are smartphones also connected in this network, every device in this network will have an IP address, and this allows data to flow correctly between different systems, ensuring seamless communication.

So now that we understand what an IP address is and why it matters to have a unique address in the form of IP address, let's explore IP version four, the most commonly used IP version and its structure.

### What is IP version four?

IP version four or Internet Protocol version four is the most commonly used version of IP addressing, and it was actually created decades ago when people were actually designing a solution for giving addresses to every computer on the network. It uses a 32-bit address format divided into four octets, each represented in decimal and separated by dots (for example, 192.168.1.1). Each octet has ranging from 0 to 255. And every octet has a specific responsibility like the first one. Represent the class of the network. The second one and the third one represent what subnet it belongs to, and the fourth one represent what actual device is on the network that it is identifying. This provides approximately 4.3 billion unique addresses, though many are reserved for private networks and special purposes. IPv4 addresses are categorized into different classes (A, B, C, D, and E) based on their range and intended use.

Now, when the internet was first designed, no one expected the number of connected devices to explode at it has today. So, the original IP addressing scheme, the IP version four so far has been the backbone of internet and it has been for decades. But now, since it's there is a limitation of only supporting 4.3 billion unique addresses. It is actually falling short.

Despite its all limitations, IPV four is still widely used because it is deeply embedded in the networking infrastructure, cloud services and corporate networks. However, due to the rapid growth of the internet, IP version four addresses are running out and which led to the development of IP version six.

### What is IP version six?

IPv6, or Internet Protocol version 6, was developed to overcome the limitations of IPv4 and ensure the continued growth of the internet. It uses a 128-bit address format, represented in hexadecimal and separated by colons (for example, 2001:db8::1), allowing for an almost unlimited number of unique IP addresses — approximately (3.4 \\times 10^{38}). IPv6 simplifies network configuration through automatic address assignment, improves routing efficiency, and includes built-in security features such as IPSec for encryption and authentication. It also eliminates the need for Network Address Translation (NAT) by providing each device with a globally unique IP address, paving the way for a more scalable and secure internet.

Each IP version six consists of eight groups of four hexadecimal digits, making it much, much longer than the IP version four. And this format provides enough addresses for every device on this Earth to have a unique address. And IP version six isn't just about more addresses, it is also bringing some key improvements in the IP addressing scheme. Improvements like there is better performance and security, there is a simplified network management, and there is also faster data processing because there is more efficient routing and packet handling that is happening. And with the growth of cloud computing devices, IoT devices and global internet expansion, IP version six adoption is actually increasing very, very rapidly.

## Public & Private IP’s

Now that we understand IP version four and IP version six, to understand what is network address translation, let's look at another critical concept the public IPS and private IPS. And we try to understand what is their role in the system design. Now let's try to look at the private IPS versus public IPS.

So, to do that, think of the entire internet as a big city, your home as a street address and identifies it to the world that is like the public IP address, but inside your home, your device has their own local addresses, like apartment numbers. That is sort of like private IP addresses. So, a public IP address is assigned to a device by an internet service provider that is globally unique, and it allows the devices to communicate directly over the internet. The example includes the IP addresses assigned to websites, cloud servers, and the router that is actually in your home or in any business, whatever router that is actually connected facing the internet. On the contrary, the private IP address is used within a local network and it is not accessible from the internet. These addresses have devices inside a local network, inside the same network to identify each other, like in your home network. You might have laptops, smart TVs, phones for all these devices to communicate with each other. All of them will get a private IP address.

Now, you'll often see these private IP addresses in homes and office networks because private IPS are reusable and they don't require global registration. What I mean by that is that if I have a home, I can have a private IP address like 192.168.6.1, something like this. And my public IP address could still be this. Now there could be another home where the public IP address will be different. It could be 1922, zero three, 23 and 46. But inside that home they could reuse the private IP address. It could still use the same private IP address. Now, understanding this difference between private IPS and public IPS is very crucial for designing the scalable and secure systems.

Why? First reason is security. Private IPS actually isolate the internal system from external threats. So even if anyone gets hold of your private IP address, since this device is not accessible from outside, they will not be able to access this device just by knowing their private IP address. Second is scalability. It allows organizations to use many, many, many internal addresses without needing the public IP addresses. And the third is network management. It helps to manage the cloud networks, virtual private networks and enterprise systems much more efficiently.

Now look at this diagram. This diagram shows a typical network the devices inside a home which are on the left side. They use all private IP addresses to communicate with each other, and whenever they want to communicate to the outside world, they give the private IP addresses as the referrer to the outside world. While the router itself has a public IP address that is provided by your internet service provider. So that is the crux of private IP addresses and public IP addresses. Now that we understand the private and public IP addresses, let's explore how this address types play an important role in the real-world system design.

So, imagine if every device in your home, your phone, your laptop, your smart TV, and even your smart fridge needed a unique, globally accessible IP address meaning public IP address. Now, with billions of devices that we have worldwide right now, we would run out of IP addresses almost instantly like that. This is why we need private IP addresses. So, there are four main reasons for having private IP addresses. The first one is address conservation. IP version four has a limited number of addresses, and using private IPS, allow organizations and homes to reuse the same IP ranges without exhausting the global address pool. The second one is enhanced security. Private IP addresses are not directly reachable from the internet, making them much more secure. This prevents direct external attacks on devices that are inside our network.

Next, efficient network management. Businesses and homes can assign private IP addresses to multiple devices and manage their internal networks efficiently without sending a separate public IP for each device. And this is much more cost effective. Also, using the private IP reduces the need to purchase multiple public IP addresses, which sometimes can be very expensive, especially when it comes to large enterprises.

How private IP is working in System design? Private IPS are used inside corporate networks, cloud infrastructures, and data centers. And they ensure smooth communication between internal services while limiting exposure to the public internet. If you look at this diagram, this shows a typical home network where multiple devices which are inside the home. If you look at here, they use private IPS, while a single public IP is assigned to the router for all the external communication needs. It helps in scalability because we can use any number of private IP addresses within a region or within a private network. It is also much more secure because we can enable firewall rules, create virtual private networks, and we can have private networks within our hosting infrastructure to have better security. Also, it helps in load balancing. So, if we have IP addresses for this, these private IP addresses for three instances of our application, the load balancer can actually efficiently do load balancing within the network using all the private IP addresses.

## NAT (Network Address Translation)

NAT (Network Address Translation) is a network technique that allows multiple devices within a private network to share a single public IP address when accessing the internet. Since private IP addresses (like 192.168.x.x or 10.x.x.x) are not routable on the public internet, NAT acts as a bridge between the private and public networks. It is typically implemented in routers or firewalls. When a device inside the private network sends a request to the internet, NAT replaces the device’s private IP with the router’s public IP before forwarding the request. When the response comes back, NAT uses an internal mapping table to send the data back to the correct device inside the network.

NAT solves this problem by enabling address reuse within private networks, allowing thousands of internal devices to connect to the internet using a single public IP. Additionally, NAT enhances network security by hiding internal IP addresses from the outside world, making it harder for attackers to directly target devices on a private network. In short, NAT allows seamless communication between private subnets and the internet while conserving IP addresses and adding an extra layer of protection.

## DNS (Domain Name System)

DNS (Domain Name System) is the Internet’s distributed directory service that translates human-friendly domain names like www.example.com into IP addresses such as 93.184.216.34, which computers use to locate one another on a network. Because it’s far easier for humans to remember names than numbers, DNS acts as the Internet’s “phonebook,” allowing users to access websites and online resources without needing to memorize numeric addresses.

### DNS Resolution

When you enter a web address into your browser, a process known as DNS resolution begins to find the IP address associated with that domain. The first step occurs locally — your operating system (OS) and browser both maintain their own small DNS caches. If the requested domain name has been recently resolved, the browser retrieves the IP address directly from its cache, which saves time and avoids additional network requests. If the browser cache doesn’t contain the record, it asks the operating system, which in turn checks its local DNS cache.

If neither cache has the answer, the request is sent to a recursive DNS resolver, usually provided by your Internet Service Provider (ISP) or a public DNS service (like Google’s 8.8.8.8 or Cloudflare’s 1.1.1.1). The resolver then performs a sequence of lookups: it first contacts one of the Root DNS Servers, which respond with a reference to the appropriate Top-Level Domain (TLD) server (for example, .com, .org, or .net). The resolver then queries that TLD server, which returns a pointer to the authoritative DNS server for the specific domain — the ultimate source of truth. The authoritative server provides the correct IP address for the requested domain, which the resolver then returns to your operating system and browser.

To make future lookups faster, every participant in this chain — the browser, operating system, recursive resolver, and even some network devices — caches the DNS response for a specific amount of time defined by the Time to Live (TTL) value. This caching system drastically reduces lookup times for repeated visits to the same domain and minimizes DNS traffic on the global network.

In short, the DNS resolution process is a multi-layered, efficient chain of lookups and caches that silently ensures you can type a familiar name like google.com and be seamlessly directed to the correct web server, no matter where it resides on the Internet.

### Importance of DNS in Large-Scale Systems

In large-scale, distributed systems — such as global web applications or cloud-based services — the Domain Name System (DNS) is a critical foundation for reliability, scalability, and performance. It not only converts human-readable domain names into machine-readable IP addresses but also enables traffic distribution, service discovery, and high availability across multiple regions and servers. Without a robust DNS layer, even a perfectly designed backend can fail to reach users effectively.

In such systems, DNS acts as the first point of contact for every user request. It helps direct traffic intelligently by resolving domain names to the most appropriate endpoint — often based on geography, latency, or server health. For example, a global e-commerce application can use DNS to route users in Asia to servers hosted in Singapore and users in Europe to servers in Frankfurt. This not only improves latency but also ensures load balancing across regions.

Moreover, DNS plays a vital role in failover and disaster recovery. When one data center or region goes down, DNS can automatically redirect traffic to a healthy region using low TTL values (so clients refresh IP mappings quickly). In modern architectures like microservices and Kubernetes-based systems, DNS is also used for service discovery, allowing services to communicate dynamically without needing hardcoded IPs.

### Private DNS in Cloud Environments

Cloud providers such as AWS, Azure, and Google Cloud offer managed private DNS services to handle name resolution inside virtual networks (VPCs or VNets). These services let you define and manage custom domain names for your internal services — so applications can communicate using friendly names instead of private IPs. This is crucial for microservices, VMs, containers, and databases running within private subnets.

## Virtual Private Network (VPN)

A Virtual Private Network (VPN) is a secure communication tunnel that allows devices or entire networks to connect to another network — typically over the internet — as if they were physically connected to the same local network. The key idea behind a VPN is to provide privacy, confidentiality, and integrity while transferring data across potentially untrusted networks. When a VPN connection is established, all data transmitted between the two endpoints is encrypted, ensuring that sensitive information such as passwords, personal data, or company secrets cannot be intercepted by unauthorized parties.

VPNs are widely used for both personal and enterprise purposes. On a personal level, individuals use VPNs to protect their online activity, mask their IP addresses, and securely access remote content. In the enterprise context, organizations use VPNs to securely connect their on-premises networks to remote offices, data centers, or cloud environments. For example, when a company migrates part of its infrastructure to the cloud, it can use a VPN to connect its internal data center to a cloud provider’s network, ensuring secure and encrypted communication between on-premises systems and cloud resources.

In the cloud, VPNs often play a vital role in establishing hybrid connectivity. A hybrid network allows workloads to run partially in the cloud and partially on-premises, with seamless communication between the two. Cloud providers like AWS, Azure, and Google Cloud offer managed VPN gateways that simplify this process. A company can create a site-to-site VPN between its local network and its Virtual Private Cloud (VPC) or Virtual Network (VNet), creating the illusion of one unified private network even though part of it resides in the cloud.

## Virtual Private Cloud (VPC) or Virtual Network (VNet)

Building upon the concept of VPNs, cloud platforms introduced the idea of a Virtual Private Cloud (VPC) or Virtual Network (VNet) to allow organizations to create private, isolated networks inside the cloud itself. A VPC (in AWS) or VNet (in Azure and Google Cloud) functions like a software-defined data center, giving users complete control over their networking environment. Within a VPC or VNet, users can define their own IP address ranges, create subnets, configure routing tables, and control inbound and outbound traffic using security rules and firewalls.

The fundamental purpose of a VPC or VNet is to allow cloud resources — such as virtual machines, application services, and databases — to communicate securely and efficiently without ever exposing internal traffic to the public internet. Although these resources reside in the provider’s shared infrastructure, each VPC or VNet is logically isolated from others, ensuring that no data can cross boundaries unless explicitly configured.

For instance, an organization might deploy its web servers in a public subnet (which has controlled access to the internet) and its databases in a private subnet (accessible only within the VPC). All communication between these layers takes place over the provider’s internal backbone network, which is both fast and secure. When external communication is needed, such as downloading updates or sending outbound API calls, NAT gateways are used so that private instances can access the internet without being directly exposed.

## Subnets and Internal Communication

A subnet is a logical subdivision of the network’s IP space. Dividing a VPC or VNet into multiple subnets allows engineers to group resources according to their purpose and security level. For example, a three-tier web application might have separate subnets for the web, application, and database tiers. The web tier, which needs to handle public traffic, is placed in a public subnet with access through an internet gateway. The application and database tiers, on the other hand, reside in private subnets that are not accessible from the public internet but can communicate internally.

Within a VPC or VNet, communication between resources is handled through private IP addresses. Resources within the same subnet can usually talk to one another directly, while communication between subnets is controlled by routing tables and security rules. This separation ensures that sensitive data, such as database queries or internal API calls, never travels over the open internet. When resources exist in different networks — for example, across multiple VPCs or VNets — peering connections or VPN links can be established to enable secure and low-latency connectivity between them.

## The Client–Server Model

The Client–Server Model is a fundamental architectural pattern in computer networking that defines how data, services, and resources are distributed and accessed across a network. In this model, the server is a powerful central system that stores, processes, and manages data or services, while the client is a device or program that requests and uses those resources. The communication between the two occurs over a network — such as a local area network (LAN), a wide area network (WAN), or the internet — following specific communication protocols like HTTP, TCP/IP, or WebSocket.

Whether you are browsing the web, using an app, or streaming a video, you are interacting with this model every day. Understanding how client and servers communicate is crucial for designing scalable and efficient systems. In this model, usually we have a client such as your laptop, phone, or even a smart device like a refrigerator. It sends a request to the server which processes the request and sends back the response.

The essence of the model lies in its clear division of roles. The client initiates requests for information or operations, and the server responds by providing the requested data or performing the required action. For example, when a user opens a website in a browser, the browser acts as the client, sending an HTTP request to a web server. The server then processes this request, retrieves the necessary data from storage or a database, and returns a response — often in the form of a web page — back to the client.

This model is the backbone of almost all modern networked systems, including web applications, email systems, online games, and cloud services. The server is designed to handle multiple client requests concurrently, using various techniques such as multithreading, asynchronous processing, and load balancing to ensure responsiveness and scalability. The client, on the other hand, focuses on user interaction, data presentation, and sending structured requests to the server.

### How the Client–Server Communication Works

The communication between client and server follows a request–response cycle. When a client wants to access a resource — such as a file, web page, or piece of data — it sends a request message to the server using a defined protocol. The server receives the request, processes it (which might involve querying a database, executing a computation, or retrieving files), and sends back a response containing the requested data or an error message if something goes wrong.

This interaction is stateless in many modern systems, particularly in web applications using the HTTP protocol, meaning that each client request is processed independently without the server remembering previous interactions. However, more advanced systems use stateful communication (through mechanisms like sessions, cookies, or persistent connections) when ongoing context or authentication is required — for example, in chat applications, online banking, or multiplayer gaming.

## Understanding Proxy Servers

A proxy server is an intermediary system that sits between a client and a destination server. Its main function is to forward network requests from one party to another while optionally modifying, filtering, or caching those requests or responses. Proxies are used to enhance security, privacy, performance, and control over network traffic.

However, the role of the proxy depends entirely on which side of the communication it serves — the client side or the server side. When the proxy acts on behalf of the client, it is called a Forward Proxy. When it acts on behalf of the server, it is called a Reverse Proxy. Although their internal mechanisms are similar, their placement and purpose in a network architecture are very different.

### Forward Proxy

A Forward Proxy (often simply called a “proxy”) sits in front of clients and acts as an intermediary between the client and the external internet. When a user or an internal system wants to access a remote server, it does not communicate directly with that destination. Instead, it sends the request to the forward proxy, which then forwards the request on the user’s behalf, receives the response, and passes it back to the client.

Forward proxies are commonly used within organizations to control outbound traffic, enforce access policies, and provide anonymity. For example, a company may configure all employee computers to use a forward proxy when browsing the internet. This allows the company’s IT department to filter unwanted websites, log activity, or apply content restrictions. From the perspective of the destination server, all requests appear to come from the proxy’s IP address — not from the individual clients.

Another important use case is privacy and anonymity. Individuals or organizations may use forward proxies to mask their true IP addresses, helping to hide geographical location or identity. Forward proxies can also cache frequently accessed content, reducing bandwidth usage and improving performance for commonly requested resources.

### Reverse Proxy

A Reverse Proxy, in contrast, sits in front of servers and acts as an intermediary between external clients and internal application servers. When a client sends a request to access a website or API, it does not communicate directly with the backend server. Instead, the request first hits the reverse proxy, which decides how to handle it — either serving cached content, routing it to one of several backend servers, or filtering it for security purposes.

Reverse proxies are critical in large-scale web architectures. They are often used for load balancing, caching, security, and SSL termination. For instance, a high-traffic website may deploy multiple web servers behind a reverse proxy. The proxy distributes incoming requests evenly among them, ensuring no single server becomes overwhelmed. This process is known as load balancing, and it greatly enhances scalability and fault tolerance.

A reverse proxy can also serve as a security shield. By hiding the identities and IP addresses of backend servers, it prevents direct access from the internet, reducing the attack surface. It can also perform rate limiting, authentication, and web application firewall (WAF) filtering to block malicious traffic. Furthermore, reverse proxies are often used for SSL/TLS termination, where the proxy handles the encryption and decryption of HTTPS traffic, offloading this CPU-intensive work from backend servers.

Caching is another major benefit. Frequently requested static assets (like images, scripts, or HTML pages) can be stored by the reverse proxy, allowing it to respond directly to clients without repeatedly fetching data from backend servers. This improves speed and reduces server load dramatically.

In essence, a Reverse Proxy represents servers to the outside world. It protects, balances, and accelerates server traffic while offering central points for control and monitoring.

### Comparison Between Forward and Reverse Proxy

Although both act as intermediaries, their direction of operation and purpose differ fundamentally. A Forward Proxy sits in front of clients, controlling and anonymizing outbound traffic. A Reverse Proxy sits in front of servers, managing and protecting inbound traffic.

- In a Forward Proxy setup, the client knows the proxy exists, but the server does not.
- In a Reverse Proxy setup, the client does not know the proxy exists — it simply appears to be the server.

For example, when you use a forward proxy to browse the web, the website you visit sees the proxy’s IP, not yours. When you visit a website protected by a reverse proxy such as Nginx or Cloudflare, you connect to the proxy, and it decides which backend server should handle your request.

## Load Balancing

Load Balancing is one of the most fundamental concepts in modern system design and cloud architecture. It refers to the process of distributing incoming network traffic across multiple servers to ensure that no single machine is overwhelmed, and that the system as a whole remains fast, reliable, and highly available.

Imagine a popular website like YouTube, Amazon, or Netflix. These platforms receive millions of requests every second. It’s impossible for a single server to handle all that traffic — it would quickly become overloaded, causing slowdowns or even outages. To prevent this, such systems deploy multiple servers (often called nodes or instances) behind a load balancer, which acts as a central traffic manager.

### What Is Load Balancing?

At its core, load balancing ensures that workloads are spread evenly across all available resources, whether those are application servers, databases, or network links. The goal is to maximize throughput, minimize response time, and prevent any single component from being a point of failure.

A Load Balancer is a device or software component that sits between clients and servers. When a client sends a request (such as opening a website or making an API call), the load balancer receives that request first. It then decides — based on predefined rules or real-time metrics — which server should handle the request and forwards it there. To the user, this process is completely invisible.

For example, if you have three servers running the same application, a load balancer can distribute incoming traffic evenly between them. If one server becomes busy or goes offline, the load balancer automatically redirects traffic to the remaining healthy servers, ensuring users never experience downtime.

### Why Do We Need Load Balancing?

Load balancing is essential in any large-scale or mission-critical system for several reasons.

The first is performance and scalability. When demand increases — say, during a sale event or viral moment — new servers can be added behind the load balancer to handle the extra traffic. The load balancer then automatically includes these servers in its rotation, allowing the system to scale horizontally. This ensures users continue to experience fast response times even under heavy load.

The second reason is reliability and fault tolerance. Servers can fail due to hardware issues, software crashes, or network problems. Without load balancing, if that one server fails, the entire service might go down. A load balancer constantly monitors the health of each backend server. If it detects that one has failed, it stops sending traffic to it and reroutes requests to healthy servers. This provides high availability and minimizes downtime.

The third reason is maintainability and flexibility. With a load balancer in place, administrators can take servers offline for updates or maintenance without interrupting user access. Traffic is simply redirected to other servers temporarily. This enables zero-downtime deployments, which are critical for businesses operating around the clock.

In addition, load balancers can help with security and efficiency. They can terminate SSL/TLS connections, offloading the CPU-intensive encryption and decryption work from backend servers. They can also filter malicious requests or throttle excessive traffic to protect against denial-of-service (DoS) attacks.

### How Does Load Balancing Work?

Load balancing can occur at different layers of the network stack — primarily Layer 4 (Transport Layer) and Layer 7 (Application Layer) in the OSI model.

At Layer 4, the load balancer operates based on network information such as IP addresses and TCP/UDP ports. It doesn’t inspect the content of the messages. Instead, it forwards packets to backend servers according to predefined algorithms like Round Robin, Least Connections, or IP Hash. This method is fast and efficient but lacks application-level awareness.

At Layer 7, the load balancer operates at the application level, understanding the content of HTTP, HTTPS, or gRPC requests. This allows it to make smarter routing decisions — for example, sending image requests to one set of servers and API requests to another. It can also perform content-based routing, URL rewriting, and header manipulation, making it ideal for modern web architectures.

### Load Balancing Algorithms

Different load balancing algorithms determine how traffic is distributed:

**Round Robin:** Requests are sent to servers in a circular order — first A, then B, then C, and back to A.

**Least Connections:** The load balancer sends the next request to the server currently handling the fewest active connections.

**IP Hash:** The client’s IP address determines which server handles its requests, ensuring session stickiness.

**Weighted Distribution:** Servers are assigned different weights based on capacity, allowing more powerful machines to handle more traffic.

Modern load balancers can dynamically adjust these algorithms based on real-time metrics such as CPU usage, response times, or error rates.

### Types of Load Balancers

Load balancers come in different forms. A hardware load balancer is a dedicated physical appliance used by large enterprises for high-performance environments. A software load balancer is a software-based solution that runs on standard servers or in the cloud — examples include Nginx, HAProxy, and Envoy.

In cloud environments, managed load balancing services are provided by platforms like AWS Elastic Load Balancer (ELB), Azure Load Balancer, and Google Cloud Load Balancing. These services automatically scale with demand, handle failover, and integrate tightly with other cloud components.

## API Gateway

In modern system architecture, APIs act as the bridge between clients and servers. Applications like web applications, mobile applications, and third-party integrations with backend services all depends on APIs. These APIs enable seamless communication, but directly exposing the backend services directly exposing the APIs to the clients can create several challenges. Challenges like security risk, performance bottlenecks, and the management overhead that comes with it.

This is where an API gateway comes in. It serves as a centralized entry point for all the API requests, acting as an intermediary between clients and backend services. An API gateway is responsible for essential functions like authentication, request routing, caching, and enforcing security in our overall design. By implementing an API gateway, we can simplify API management, enhance security, and optimize performance, making it a crucial component in scalable and secure system design.

### How does an API gateway work?

An API gateway functions as a reverse proxy. It sits between the clients and the backend services. Instead of clients communicating directly with the multiple services that are there on our server side, all the requests first go to the API gateway. When a client makes an API request, the gateway receives it. It processes it and determines which backend service should handle the request. It then forwards the request to the appropriate service and returns the response to the client.

Beyond the simple request forwarding, API gateway also provides critical functionalities at its end, such as request transformation, meaning modifying the request format to match the backend service expectation. In some cases, it does authentication to verify the user's identity. It can do rate limiting to prevent API abuse, and it can also do the response handling to send the standard responses back to the users.

By centralizing all these tasks in the API gateway. The API gateway simplify API management. It improves the overall security and enhances the system performance.

### What are the benefits of using an API gateway?

We have already touched upon it, but let's go through them at a very high level. API gateway provides several critical benefits that enhance the security, performance, and manageability of APIs.

First, security is the key advantage by acting as a protective layer. The API gateway prevents direct exposure of the backend services, reducing security risks and enforcing authentication and authorization.

Next, rate limiting rate limiting helps control API traffic. It prevents abuse and mitigates the DDoS attacks by restricting excessive requests from any single client.

Next, load balancing API gateways also provide load balancing. It efficiently distributes the incoming traffic across multiple backend services to ensure high availability and system stability.

Then caching. Caching is another major benefit as it reduces response time by storing frequently requested data, minimizing unnecessary backend processing.

With request transformation, the API gateway can modify request format headers and protocols, enabling seamless communication between clients and backend services. Because clients and backend services might have different requirements when it comes to the format of the request and response.

And then finally logging, logging and monitoring provides visibility into API usage. How the API is performing security threats, and it helps the team track issues and optimize their systems effectively.

Altogether, these benefits make an API gateway essential component in the modern API driven architecture.

In essence, the API Gateway represents the convergence of performance optimization, security enforcement, and architectural abstraction. It simplifies client interaction with complex systems, ensures reliability through intelligent routing and failover integration, and acts as the foundation upon which modern service-oriented architectures are built. Without an API Gateway, a microservices ecosystem would quickly descend into operational chaos; with it, communication becomes structured, secure, and manageable — the hallmark of a well-designed, scalable system.

## Content Delivery Networks (CDN)

Tired of slow-loading websites? A CDN's your answer! It's a network of geographically distributed group of servers that caches content close to end users. A CDN allows for the quick transfer of assets needed for loading Internet content, including HTML pages, JavaScript files, stylesheets, images, and videos.

### What is a CDN?

A CDN is a globally distributed network of servers that works together to efficiently deliver content to the user. CDN strategically placed servers around the world to store and serve content closer to the user, and thereby reducing the latency and improving the performance.

### Why do we need CDNs?

First is very clear to reduce the latency. The content is delivered from the nearest CDN node and thus reducing the delays.

Second, it also enhances the content availability. If one server fails, traffic is rerouted to the next available server. Next nearest available server.

Third, it improves the load handling. So, in case any of the CDN server is overloaded, the CDN will distribute the traffic across multiple servers, preventing the overload of a single CDN server or of the origin server.

And finally, security CDNs provide protection against DDoS attacks. It encrypts traffic and it prevents malicious access.

In modern system design, CDNs are essential for fast, reliable, and secure content delivery. Whether it's a website, it's a video streaming service, or an API response, CDNs are very critical.

### Why are Syrians needed to understand this?

You have to understand the problem that exists without CDN. First is high latency due to geographic distance. If a website is hosted on a single server across the globe, let's say you are trying to access from India and the website is hosted in New York, then the user will experience noticeable delays because the data has to travel across the globe. Second is if there is a single server, even if it is geographically close to me, with thousands and thousands of requests that are coming to it Great. Sometimes what happens is that the origin server which hosts the content, gets overloaded and it could cause crashes and slow performances. And the third reason is bandwidth constraints and slow load times. Without CDN, every user request must be handled by a same origin server, which will end up consuming large amounts of bandwidth and increase cost.

So, to overcome these issues, we need a better approach one that reduces latency, offloads traffic from the origin server to other servers, and ensures a smoother user experience. And this is exactly where CDNs come into play. So now that we understand why CDNs are essential, let's break down how they work.

A CDN consists of multiple components that work together to deliver the content Efficiently while reducing latency and the server load. So there are three main components of CDN network. First is origin server. This is the source of truth. The origin server is where the original content is stored. It could be hosted in a data center or a cloud provider or on premises also. However, relying on a single origin for every request creates performance bottlenecks. Then the second components are edge servers or they are also called points of presence pops. This is a global distribution network. CDNs introduce edge servers, which are also known as Point of presence servers. These servers are strategically placed around the globe to store the cached content closer to the user. And then the entire system is actually configured by a request routing system. When a user makes a request, the request routing system determines the best edge server to serve the content. This decision is based on factors like geographic locations, network latency, and the load on the actual server. So together, these components form the backbone of a CDN, ensuring that the users get fast, reliable, and optimized content delivery.

So how CDN works and it handles the request from the user. So every time you visit a website, watch a video, or make an API call, your device makes a request for content without a CDN. This request travels to the origin server, causing delays, but with CDN. How things work. First step the user requests the content. The content could be a web page, a video, or an API data. In second step, the CDN directs the request to the nearest edge server, so when the user makes a request, the domain gets resolved to the servers and the CDN directs the request to the nearest edge server. Instead of sending the request to the distant origin server, the CDN intelligently routes it to the closest edge server. This decision is based on factors like the user's geographic location, network latency, and current server load. Step three if the requested content is already stored on the edge server. I mean, if it is already cached on the edge server, it is delivered instantly to the user, so it reduces the latency and it improves the performance. But if the content is not available on the edge server, the request is forwarded to the origin server. The origin retrieves the contents, sends it back, and also caches it on the CDN server for the next upcoming request. This ensures that the future user's requesting the same content will at least experience the faster load times.

### What are the key benefits of using a CDN?

First, obvious that we have already talked about caching and replication. This is one of the primary benefits of CDNs. Storing frequently accessed content on edge server closer to the user. This reduces the load on the origin server and it minimizes latency.

Second is about load balancing. To prevent the overloading of any single server, CDNs use load balancing and smart request routing strategies depending on the user's location and the network conditions. CDNs direct traffic to the appropriate server. The strategy could be geo based routing, latency based routing, or load aware routing.

Third, it offers the benefit of compression and optimization. CDNs also can optimize the content by compressing files and reducing the bandwidth consumption. There are technologies like gzip shrinking HTML, CSS and JavaScript files. Image optimization. Lazy loading. Minification bundling which CDNs can do, which will actually compress the actual content going to and from, and then optimize the actual data transfer that is happening across servers.

And then finally there are security features. So, beyond performance, students also provide the essential security features to protect the websites from threats like DDoS protection, SSL encryption. And there are also things like bot mitigation that can happen at the CDN. Send a well architected CDN not only speeds up the content delivery, but also ensures reliability, reduces the bandwidth cost, and strengthens security.

### Pull and Push Strategies in Content Delivery Networks (CDNs)

There are two main strategies used by CDNs to deliver content: Pull and Push.

Under the Pull Strategy, also known as lazy loading or on-demand caching, the CDN retrieves content from the origin server only when a user requests it for the first time. When that initial request arrives at an edge server, the CDN checks its local cache. If the content is not already present — a condition known as a cache miss — the CDN fetches the file directly from the origin, delivers it to the user, and stores a copy locally. Subsequent requests for the same resource from other users in that region are then served directly from the cache, significantly reducing latency and origin server load. This model is ideal for dynamic or frequently changing content, as it avoids unnecessary preloading of data that may never be accessed. It also simplifies deployment since developers only need to point the CDN to their origin domain without manually managing the caching process. However, the pull approach can lead to slower response times for the very first request and may increase bandwidth usage if cache expiry policies are not carefully configured.

In contrast, the Push Strategy operates on the principle of proactive distribution. Here, the website owner or application developer manually uploads — or “pushes” — content to the CDN’s edge servers before it is requested by users. This ensures that the content is already available at all relevant CDN locations, allowing instant delivery without any cache misses. The push model is particularly effective for static assets such as images, videos, software downloads, or large datasets that do not change frequently and are expected to be accessed by many users simultaneously. It provides precise control over which files are stored in which regions, offering predictable performance and eliminating the delay associated with on-demand fetching. However, it also introduces additional operational overhead since developers must handle synchronization, updates, and purging of outdated files across CDN nodes manually or via automated pipelines.

From a design perspective, both strategies have their place in modern content delivery systems. The Pull Strategy excels in simplicity and flexibility, making it ideal for content-driven websites, APIs, or e-commerce platforms with constantly updating resources. The Push Strategy, on the other hand, offers deterministic performance for media-heavy or globally distributed applications where pre-positioning content near users is critical. Many enterprise-grade CDNs, such as Cloudflare, Akamai, and AWS CloudFront, allow hybrid configurations — using pull for dynamic assets and push for large static files — to balance efficiency, control, and scalability.

# Chapter 3 — Communication Protocols

This chapter is all about protocols. In this chapter we will explore the core communication protocols that power modern system architecture from TCP and UDP to HTTP, rest, WebSockets and beyond. By the end of this chapter, you will have a solid understanding of the protocols that drive our web applications, APIs, and real time communications. Here in this chapter, we are going to cover predominantly these protocols. We'll start with the basics of TCP and UDP understanding their differences and their use cases. Then we'll dive into HTTP which is the backbone of the web. Next, we'll explore Rest and API design principles followed by real time communication protocols like WebSockets long pulling. And then we will also look at some of the modern API protocols such as gRPC and GraphQL. Finally, we'll wrap up with a summary and we'll discuss the practical application of these protocols. This chapter will give you a strong foundation in protocols essential for system design.

## OSI Model and Its Purpose in Secure Communication

The **OSI (Open Systems Interconnection) Model** is a conceptual framework that standardizes how network communication operates across different systems. It divides networking into **seven logical layers**, each responsible for specific functions that enable devices to exchange data securely and efficiently.

**Why the OSI Model Matters**

- Helps developers and engineers **understand where security controls must be applied**
- Standardizes communication across different vendors and technologies
- Simplifies troubleshooting by isolating issues to a specific layer
- Clarifies how protocols (like HTTPS, TCP/IP) and services operate in the network stack

**OSI Layers Overview**

| **Layer** | **Name** | **Purpose in Communication** | **Security Focus Examples** |
| --- | --- | --- | --- |
| 7   | **Application** | User-facing services and protocols | Authentication, API security, encryption |
| 6   | **Presentation** | Data formatting, compression, encryption | SSL/TLS encryption |
| 5   | **Session** | Session management and communication control | Token management, secure session handling |
| 4   | **Transport** | Reliable data delivery (TCP/UDP) | Port security, firewall rules |
| 3   | **Network** | Routing and logical addressing (IP) | VPN, IPsec, routing security |
| 2   | **Data Link** | MAC addresses, switching, error detection | VLANs, ARP protection, frame security |
| 1   | **Physical** | Hardware transmission (cables, radio waves) | Secure cabling, EMI protection, access control |

Each layer builds upon the one below it, ensuring that data travels from sender to receiver accurately and securely.

## TCP and UDP: The Foundations of Internet Communication

In the world of computer networking and system design, two of the most fundamental protocols that define how data travels across the internet are TCP (Transmission Control Protocol) and UDP (User Datagram Protocol). Every message you send, every file you download, and every video you stream relies on one of these protocols to deliver data from one machine to another. Understanding TCP and UDP is essential not only for network engineers but also for anyone designing scalable and reliable distributed systems. These two protocols illustrate one of the most important trade-offs in system design — the balance between reliability and speed. Some applications require absolute accuracy and error-free data transfer, while others value instant responsiveness and can tolerate a small amount of data loss.

## Transmission Control Protocol (TCP)

The Transmission Control Protocol, or TCP, is one of the most widely used communication protocols on the internet. It plays a vital role in ensuring that data is transmitted accurately, completely, and in the correct order between sender and receiver. TCP is a connection-oriented protocol, meaning that before any actual data exchange occurs, a secure and reliable connection must first be established between the two communicating devices. This setup process is similar to making a phone call—you don’t start speaking until the other person answers. TCP achieves this reliability through a procedure known as the three-way handshake, where the sender and receiver exchange special control messages to confirm that both sides are ready to communicate.

Once the connection is established, TCP ensures that data is delivered reliably and in sequence. Every piece of data sent is broken into packets, and each packet is carefully tracked with a unique sequence number. When these packets reach their destination, TCP reassembles them in the correct order, ensuring no data is missing or misplaced. If any packet is lost or corrupted during transmission, TCP automatically requests its retransmission. This mechanism guarantees error-free and ordered communication, making TCP a perfect fit for use cases where precision and completeness are critical.

For instance, when you are downloading a file, sending an email, or performing an online banking transaction, TCP ensures that the data you receive is exactly what was sent—no missing parts, no distortions. Protocols such as HTTP/HTTPS (web browsing), FTP/SFTP (file transfers), and SMTP/IMAP/POP3 (email services) are all built on top of TCP because they cannot tolerate even a single byte of missing data.

However, this reliability comes with a trade-off. TCP’s constant error checking, acknowledgment, and retransmission add overhead and latency, making it slower compared to other lightweight protocols. The three-way handshake alone introduces additional time before communication can begin. Therefore, while TCP guarantees delivery, it is not ideal for time-sensitive applications that prioritize real-time interaction over accuracy.

In summary, TCP is a connection-oriented, reliable, and ordered communication protocol. It ensures data integrity through acknowledgment and retransmission, making it indispensable for scenarios where accuracy matters more than speed. It forms the backbone of critical internet operations, from web browsing to secure transactions, and remains one of the cornerstones of modern networking.

## User Datagram Protocol (UDP)

In contrast to TCP’s emphasis on reliability, the User Datagram Protocol (UDP) is designed with speed and efficiency in mind. UDP is a connectionless protocol, meaning it does not establish a formal connection before sending data. Instead, it simply sends packets — known as datagrams — without checking whether they are received or not. This approach is similar to sending postcards in the mail without waiting for confirmation that they have arrived. While this might sound risky, it drastically reduces communication overhead and results in much lower latency, making UDP ideal for real-time applications.

Because UDP does not perform error checking, acknowledgment, or retransmission, it is significantly faster than TCP. This speed advantage is crucial for applications that demand instantaneous data flow, where a small amount of data loss is acceptable but delays are not. Examples include online gaming, live video streaming, voice over IP (VoIP), and real-time financial updates. In these cases, receiving the latest data quickly is far more important than ensuring that every packet arrives perfectly. For instance, when you are on a video call, a lost video frame or a short glitch in sound is preferable to a delay that disrupts the conversation.

However, this speed comes at the cost of reliability. Since UDP does not guarantee delivery, packets can be lost, duplicated, or arrive out of order. The protocol also lacks built-in mechanisms for congestion control or flow management, which TCP handles automatically. In applications that cannot tolerate such inconsistencies, developers often build their own lightweight reliability systems on top of UDP or choose TCP instead.

Despite these limitations, UDP’s simplicity and efficiency make it a powerful tool in networking. It enables systems to handle large volumes of simultaneous connections with minimal resource consumption, and its stateless nature makes it highly scalable. For example, DNS (Domain Name System) queries use UDP because they require extremely fast responses — if a DNS request fails, it can simply be retried.

## Hypertext Transfer Protocol (HTTP)

HTTP, short for Hypertext Transfer Protocol, is the application-layer protocol that defines how data is requested and transmitted over the Internet. It specifies the communication rules between two entities — a client, such as a web browser or mobile app, and a server, which hosts the requested resources. These resources could be anything from an HTML page or an image to a JSON response or a video file.

HTTP operates on top of TCP (Transmission Control Protocol), ensuring reliable and ordered data transmission. Traditionally, it communicates over port 80, though its secure counterpart, HTTPS, uses port 443. One of HTTP’s most defining features is that it is text-based and human-readable — meaning its messages can be easily inspected or debugged using tools like browser consoles, cURL, or Postman.

Another crucial characteristic of HTTP is that it is stateless. This means each client request is treated as an independent transaction, and the server does not retain any memory of previous interactions. This statelessness simplifies server design and improves scalability, but it also means that maintaining user-specific information — such as login sessions or shopping carts — requires additional mechanisms like cookies, sessions, or tokens.

## Understanding REST and RESTful Architecture

In the realm of distributed computing and modern system design, **REST**, or **Representational State Transfer**, stands as one of the most influential architectural styles ever devised. REST defines a structured way of building scalable, stateless, and interoperable web services using existing web standards — most notably, the **HTTP protocol**. Instead of introducing new and complex mechanisms, REST leverages the simplicity and universality of HTTP to facilitate communication between clients and servers. Whether you are interacting with a web service, a mobile backend, or a cloud API like those provided by Twitter, GitHub, or Google, you are almost certainly relying on REST principles.

Origins and Core Idea

The concept of REST was introduced in the year **2000** by **Dr. Roy Fielding** in his doctoral dissertation. His vision was to create a standardized architectural approach for building distributed systems that could scale efficiently and communicate seamlessly over the web. REST focuses on **representations of resources**, where a “resource” can be any object or entity — such as a user, a product, or an order — that can be identified and manipulated using standard HTTP operations.

At its heart, REST embraces **stateless communication**, which means every client request must contain all the necessary information for the server to process it. The server does not retain any memory of previous interactions. This design choice dramatically improves **scalability** and **fault tolerance**, as any request can be served by any available server in a cluster without dependency on shared session data.

Why REST is Widely Adopted

REST became the foundation of modern APIs because of its **simplicity, scalability, and interoperability**. Its use of standard HTTP methods makes it easy to implement and understand across languages and platforms. Being **platform-agnostic**, RESTful APIs can be consumed by clients running on different devices, operating systems, and technologies — from web browsers and mobile apps to IoT devices.

Another crucial advantage of REST is **efficiency**. REST APIs can leverage caching at multiple levels (client, proxy, and server), reducing redundant requests and minimizing latency. Since REST avoids session overhead, it is inherently well-suited for **distributed architectures** like cloud-native systems and microservices, where scaling out horizontally is a core requirement.

### Core Constraints of REST Architecture

To qualify as RESTful, an API must adhere to several architectural constraints defined by Roy Fielding. These constraints are the pillars that make REST reliable and scalable:

1.  **Client–Server Architecture** – REST separates the client (which consumes data) and the server (which provides data). This separation allows each side to evolve independently. The client focuses on the user interface and experience, while the server handles data processing and persistence.
2.  **Statelessness** – Each request from a client contains all the information required to process it. The server stores no session context between requests, simplifying scaling and failure recovery.
3.  **Cacheability** – REST allows clients and intermediaries to cache responses to improve performance and reduce load on servers. Caching helps achieve faster response times for frequently accessed resources.
4.  **Layered System** – A RESTful system can be composed of multiple layers — such as security, load balancing, or proxy servers — without affecting how the client interacts with the API. Each layer can operate independently, improving flexibility and scalability.
5.  **Uniform Interface** – Perhaps the most defining characteristic of REST, the uniform interface ensures that all resources are accessed and manipulated using standard HTTP methods in a consistent and predictable manner.

These principles together make REST an architectural style that balances **simplicity, scalability, and independence** — qualities essential for modern distributed systems.

Designing RESTful APIs: Resource-Oriented Approach

In REST, everything is treated as a **resource** — users, posts, comments, products, or orders. Each resource is uniquely identified using a **URI (Uniform Resource Identifier)**. For instance, /users/123 represents a specific user with the ID 123, while /orders might represent the collection of all orders.

Unlike older RPC-style interfaces that focus on actions (e.g., /createUser), REST focuses on **nouns** rather than **verbs**. You do not “createUser”; you perform a POST request to /users. You do not “deleteUser”; you perform a DELETE request to /users/{id}. This resource-oriented thinking keeps APIs **clean, logical, and intuitive**.

### HTTP Methods (Verbs) in REST

RESTful APIs rely on a small set of standard **HTTP methods**, each with a specific purpose and expected behavior. These methods also define whether an operation is **safe** (does not modify the state) or **idempotent** (repeating the same request multiple times results in the same outcome). Understanding these properties is essential for designing reliable APIs.

1.  **GET** –
    - **Purpose:** Retrieve a resource or a collection of resources from the server.
    - **Behavior:** Safe and **idempotent**, meaning it does not alter the server’s state and can be repeated any number of times without side effects.
    - **Example:** GET /users/123 fetches the details of the user with ID 123.
2.  **POST** –
    - **Purpose:** Create a new resource on the server.
    - **Behavior:** **Not idempotent**, because sending the same POST request multiple times may result in multiple identical resources being created.
    - **Example:** POST /users creates a new user record.
3.  **PUT** –
    - **Purpose:** Update or replace an existing resource.
    - **Behavior:** **Idempotent**, as repeating the same request results in the same final state of the resource.
    - **Example:** PUT /users/123 updates the user with ID 123 to the new data provided.
4.  **PATCH** –
    - **Purpose:** Partially update an existing resource.
    - **Behavior:** Not guaranteed to be idempotent, since multiple partial updates may produce different outcomes based on intermediate states.
    - **Example:** PATCH /users/123 updates only specific fields like email or phone number.
5.  **DELETE** –
    - **Purpose:** Remove a resource from the server.
    - **Behavior:** **Idempotent**, as deleting the same resource multiple times has no additional effect after the first deletion.
    - **Example:** DELETE /users/123 deletes the user with ID 123.

By consistently applying these HTTP verbs, developers create APIs that are predictable, consistent, and aligned with RESTful conventions.

### Statelessness and Token-Based Authentication

RESTful APIs are **stateless**, meaning no client context is stored on the server between requests. While this improves scalability, it introduces a challenge for managing authentication or maintaining user sessions. Instead of using traditional session-based authentication, RESTful systems typically rely on **token-based authentication** mechanisms such as **JWT (JSON Web Tokens)** or **OAuth 2.0**.

In this model, the client sends a token with every request (usually in the Authorization header), allowing any server to validate the request without storing user-specific session data. This approach aligns perfectly with REST’s stateless nature and supports distributed architectures where requests may be routed to any instance.

### Resource Naming and URL Design

A well-designed REST API is defined by **clear, predictable, and consistent URLs**. Resources should use plural nouns (/users, /orders) and hierarchical structures to reflect relationships (e.g., /users/123/orders). Actions should not be part of URLs — verbs like /createUser or /deleteOrder should be avoided.

Another best practice is **API versioning**, often implemented in the URL (e.g., /api/v1/users) or request headers. Versioning prevents breaking changes for clients and allows APIs to evolve gracefully over time.

### Data Formats and Content Negotiation

The choice of data format for RESTful APIs typically lies between **JSON** and **XML**.

- **JSON (JavaScript Object Notation)** has become the de facto standard because it is lightweight, easy to parse, and natively supported in web and mobile environments.
- **XML (eXtensible Markup Language)**, though less common today, remains relevant in legacy systems or scenarios requiring strict schema validation via XSDs.

REST supports **content negotiation**, allowing clients to specify their preferred format via the Accept header (application/json or application/xml), ensuring flexibility and interoperability.

### Best Practices for RESTful API Design

1.  **Use Proper HTTP Status Codes:** Return meaningful status codes like 200 OK, 201 Created, 400 Bad Request, 404 Not Found, and 500 Internal Server Error to help clients understand responses.
2.  **Implement Pagination for Large Datasets:** For endpoints returning large collections, use query parameters like ?page=2&limit=50 to reduce load and improve performance.
3.  **Secure APIs with HTTPS and Authentication:** Always use **HTTPS** to protect data integrity and confidentiality, and secure endpoints with OAuth2 or JWT tokens.
4.  **Avoid Verbs in URLs:** Stick to nouns to represent resources. Use HTTP methods to convey the intended action.
5.  **Support Versioning:** Ensure backward compatibility by versioning APIs as they evolve.

By adhering to these best practices, RESTful APIs become robust, scalable, and secure — qualities vital for enterprise-grade systems.

### HTTP Status Codes and Their Categories

Every interaction between a client and a server in a RESTful system concludes with an **HTTP status code**. These codes are an essential part of the HTTP protocol, serving as standardized responses that communicate the result of a client’s request. Instead of relying on custom messages, status codes provide a universal language of success, error, or redirection—understood across all platforms and frameworks.

Each status code is a **three-digit number**, where the **first digit** determines the **category** of the response. This categorization helps both developers and automated systems interpret what occurred during the transaction. For example, codes beginning with “2” indicate success, while those beginning with “4” represent client-side errors.

There are **five major classes** of HTTP status codes: informational, success, redirection, client error, and server error. Let’s explore each category in detail.

#### 1xx – Informational Responses

The **1xx class** of status codes is rarely seen by end users but plays an important role in communication between clients and servers. These codes indicate that the **request has been received** and that the **server is continuing the process**. They are primarily used for control and protocol negotiation.

- **100 Continue:** This response informs the client that it may proceed with sending the request body. It is often used in situations where the client wants to ensure the server is ready before sending large payloads.
- **101 Switching Protocols:** Indicates that the server is switching to a different protocol as requested by the client—for example, upgrading from HTTP to WebSocket.

Informational responses help establish smoother communication, ensuring that the client and server remain synchronized during ongoing exchanges.

#### 2xx – Success Responses

The **2xx series** represents successful operations. When a client receives a status code in this range, it means the request was **valid**, **understood**, and **processed successfully** by the server.

- **200 OK:** The most common and versatile status code. It indicates that the request has succeeded, and the response body (if any) contains the requested resource or information.
- **201 Created:** Indicates that a new resource has been successfully created on the server, usually in response to a POST request. The response often includes a Location header pointing to the new resource’s URI.
- **202 Accepted:** The request has been accepted for processing, but the actual processing may still be in progress. This is often used for asynchronous or background tasks.
- **204 No Content:** Indicates that the request was successful but that there is no additional content to return in the response body. Commonly used after DELETE or successful PUT operations.

Success codes provide confirmation that the client’s request achieved its intended result, forming the backbone of reliable communication between systems.

#### 3xx – Redirection Responses

The **3xx class** of status codes is used when a client must perform additional actions to complete a request—typically following a change in the location of a resource. Redirection responses allow the server to instruct the client to fetch the resource from another URI or endpoint. These responses play a vital role in maintaining **resource continuity**, particularly during URL restructuring, load balancing, and CDN-based content distribution.

- **301 Moved Permanently:** This response indicates that the requested resource has been **permanently moved** to a new URI. Future requests should be directed to this new address. Clients, search engines, and caching systems update their references accordingly.
- **302 Found:** This is one of the most commonly used redirection codes. It tells the client that the resource is temporarily located at a different URI, but that the same original URI should still be used for future requests. However, historically, different browsers handled this response inconsistently by converting the original HTTP method (like POST) to GET, which sometimes led to unexpected behavior.
- **303 See Other:** This code explicitly directs the client to retrieve the requested resource from another URI using a **GET** method. It is often used after a POST request to redirect clients to a confirmation page, ensuring idempotent retrieval of results.
- **307 Temporary Redirect:** The **307 status code** was introduced to **address the ambiguity** of the 302 response. It serves a similar purpose—indicating that the requested resource is temporarily available at a different URI—but with a crucial distinction: **the HTTP method and body of the original request must not change** when the client retries at the redirected location. This means if the original request was a POST, the redirected request must also remain a POST. This makes **307** especially valuable for maintaining consistency in APIs, form submissions, and secure data transfers where method integrity is essential.
- **308 Permanent Redirect:** The 308 code is similar to the 301 status, but it preserves the original HTTP method and body just like 307 does. It signals that the resource has been permanently moved to a new location, and future requests should use the new URI without altering the HTTP method.

Redirection codes thus ensure **smooth transitions** and **client adaptability** in dynamic network environments. Whether you’re redirecting for caching, version migration, or temporary routing, the 3xx family provides a structured and reliable framework for handling these interactions.

#### 4xx – Client Error Responses

The **4xx series** represents errors caused by the **client’s request**. These occur when the request is malformed, unauthorized, or violates server rules. Such responses help developers understand and correct issues on the client side rather than the server.

- **400 Bad Request:** The server cannot process the request due to invalid syntax or malformed input.
- **401 Unauthorized:** Authentication is required, or the provided credentials are invalid. The client must include valid credentials before retrying the request.
- **403 Forbidden:** The client is authenticated but not authorized to perform the requested action.
- **404 Not Found:** The requested resource does not exist or cannot be located on the server.
- **409 Conflict:** The request conflicts with the current state of the target resource—often used during simultaneous updates.
- **422 Unprocessable Entity:** The server understands the content type of the request and the syntax is correct, but it cannot process the request because of **semantic errors** or **validation failures**. This status code is frequently used in APIs that enforce strict data validation rules—for example, when required fields are missing or contain invalid values. Unlike a 400 Bad Request, which signals a syntactical issue, a 422 specifically highlights **logical or domain-level issues** within the payload.
- **429 Too Many Requests:** Indicates that the client has sent too many requests within a specific time window and has been rate-limited.

These codes not only improve communication clarity but also play a key role in **security** and **API usability**, ensuring clients understand the reason for rejection or failure.

#### 5xx – Server Error Responses

While 4xx errors arise from client mistakes, **5xx codes** signify problems on the **server side**. These responses indicate that the client’s request was valid, but the server failed to fulfill it due to internal issues or dependency failures.

- **500 Internal Server Error:** A generic and common error indicating an unexpected condition that prevented the server from completing the request.
- **502 Bad Gateway:** The server, acting as a gateway or proxy, received an invalid response from an upstream server.
- **503 Service Unavailable:** The server is temporarily unable to handle requests, typically due to overload or maintenance. Clients are encouraged to retry after some delay.
- **504 Gateway Timeout:** The server did not receive a timely response from another service while processing the request.

Server error responses are crucial for diagnosing system health, stability, and dependency reliability in distributed architectures.

## Real-Time Communication Protocols

In the world of modern web applications, where users expect instant updates, live notifications, chat messages, and interactive dashboards, **real-time communication** has become an essential capability. Traditional HTTP, while reliable, follows a **request–response model** in which the client must always initiate communication. This makes it inefficient for real-time applications that require the server to push data to clients as events happen. To overcome this limitation, protocols like **WebSockets** were developed — enabling persistent, bidirectional communication between clients and servers over a single connection.

### The Need for Real-Time Communication

Before the introduction of WebSockets, achieving real-time communication on the web was challenging. Developers relied on techniques such as **polling** and **long-polling**, where the client repeatedly sent requests to the server to check for new data. Although functional, these approaches were inefficient because they generated unnecessary network traffic and increased server load, as the majority of requests often returned empty responses.

Applications such as online gaming, chat systems, financial trading platforms, live sports updates, and collaborative editing tools required something better — a way for the server to **push** updates to clients immediately. This led to the emergence of the **WebSocket protocol**, designed to maintain a continuous connection between the client and the server, allowing both to exchange messages freely and efficiently.

### Understanding the WebSocket Protocol

The **WebSocket protocol** is a standardized communication protocol defined by the **IETF (Internet Engineering Task Force)** under **RFC 6455**. It operates over **TCP** and provides a **full-duplex** communication channel — meaning that data can flow simultaneously in both directions without requiring the client to repeatedly initiate new HTTP requests.

A WebSocket connection begins with a **handshake** that starts as a standard HTTP request. The client sends an HTTP GET request to the server with an **Upgrade header**, requesting the protocol change from HTTP to WebSocket. If the server supports WebSockets, it responds with a 101 Switching Protocols status code, confirming the upgrade. Once this handshake completes, the connection “upgrades” from HTTP to WebSocket, and a **persistent, low-latency channel** is established between the client and the server.

Unlike HTTP, which transmits plain text messages, WebSockets send and receive data as **frames** — lightweight binary or text-based packets. This makes communication much faster and more efficient, especially for high-frequency updates such as stock tickers or live chat messages. Because the connection remains open, the server can instantly push new data to connected clients the moment an event occurs, without waiting for a new request.

How WebSockets Work

1.  **Handshake Phase:**
    - The client initiates a WebSocket connection by sending an HTTP request with the Upgrade: websocket header.
    - The server responds with HTTP 101 Switching Protocols, indicating acceptance.
    - Both parties then switch to the WebSocket protocol while maintaining the same underlying TCP connection.
2.  **Data Transfer Phase:**
    - After the handshake, communication happens through **frames**.
    - Frames can contain **text**, **binary data**, **ping/pong messages** (for connection health checks), or **close signals**.
    - Either side can send messages at any time, enabling true bidirectional communication.
3.  **Connection Termination:**
    - Either the client or the server can send a **Close frame**, after which both sides terminate the connection gracefully.

Advantages of WebSockets

The WebSocket protocol offers several key benefits that make it ideal for real-time applications:

- **Full-duplex communication:** Both client and server can send messages independently, without waiting for each other.
- **Low latency:** The persistent connection eliminates the overhead of HTTP headers in repeated requests, reducing delay.
- **Efficiency:** Because it transmits lightweight frames, bandwidth consumption is significantly lower than polling-based methods.
- **Scalability:** WebSockets can handle thousands of concurrent open connections efficiently when paired with event-driven servers like Node.js, ASP.NET Core SignalR, or Go’s Gorilla WebSocket.

### Polling and Long Polling in Real-Time Communication

In the world of real-time communication, where applications strive to deliver instant updates to users, the choice of how data is exchanged between client and server becomes critical. While technologies like **WebSockets** provide true bidirectional communication, not all systems or environments can support such persistent connections due to infrastructure limitations, firewall restrictions, or protocol constraints. In such cases, developers often turn to a simpler yet effective alternative — **Polling** and its more optimized form, **Long Polling**.

What is Polling?

Polling is the most straightforward way for a client to check if the server has new information. In this approach, the client repeatedly sends periodic HTTP requests to the server at fixed intervals — for example, every 5 or 10 seconds — asking whether new data is available. If there is new information, the server responds with it; otherwise, it may simply respond with an empty message or a “no new updates” response.

This mechanism is simple to implement and works well for applications where updates are infrequent and latency requirements are not strict. However, the simplicity of polling comes at a cost. Because the client sends requests continuously — even when there is no new data — it results in **high server load**, **unnecessary bandwidth consumption**, and **increased latency**. The constant opening and closing of connections for each request make polling inefficient, particularly when scaling to thousands or millions of users.

A practical example of polling can be found in older web applications or simple dashboards that periodically refresh their data from the server. For instance, a stock tracking page might poll the server every few seconds to fetch the latest price, or a chat app might check for new messages at regular intervals. While functional, such approaches often lead to unnecessary network chatter and resource usage.

What is Long Polling?

Long Polling was introduced as an improvement over regular polling to make real-time communication more efficient without requiring a persistent socket connection. In long polling, the client still makes an HTTP request to the server — but instead of the server responding immediately, it **holds the request open** until new data becomes available. Only when the server has something meaningful to send does it respond with the data. Once the client receives this response, it immediately sends another request, continuing the cycle.

This creates the illusion of a continuous, near real-time connection using standard HTTP. Unlike regular polling, long polling drastically reduces the number of unnecessary requests and helps achieve lower latency. The connection stays idle only while waiting for an update, making it more resource-friendly and scalable.

For example, in a notification system, when a new event occurs (such as a new message or alert), the server can instantly respond to the waiting long-poll request. The client receives the notification almost immediately, then opens a new request to wait for the next event. This creates an efficient event-driven communication pattern while still relying on traditional HTTP infrastructure.

Long Polling as a WebSocket Alternative

While WebSockets offer the most efficient and modern solution for real-time bidirectional communication, long polling serves as a **viable alternative** when WebSockets are not available or supported — for instance, in older browsers, restricted networks, or environments with limited WebSocket support.

The beauty of long polling lies in its compatibility: it works entirely over **HTTP/HTTPS**, which means it can traverse firewalls and proxies without issues. This makes it especially useful in enterprise networks where persistent TCP connections (like those used by WebSockets) may be blocked.

In such cases, long polling can effectively **mimic WebSocket behavior**. The client maintains an almost continuous communication loop with the server — though not truly bidirectional, it achieves a similar effect of receiving updates as soon as they occur. The main difference lies in efficiency: each long-polling request still involves some HTTP overhead and connection setup, making it less optimal for very high-frequency updates compared to WebSockets.

Applications like **Twitter**, **Facebook notifications**, and some **IoT systems** have historically relied on long polling before migrating to WebSockets or Server-Sent Events (SSE) as infrastructure matured.

Pulling for Website Heartbeats and Health Monitoring

Beyond chat systems or notification feeds, the concept of **polling** or **pulling** is also fundamental to maintaining system health and uptime visibility. In large distributed systems, it’s common for a monitoring service or client application to periodically **“pull” heartbeat signals** or status information from servers, APIs, or devices to ensure they are alive and functioning properly.

This is sometimes referred to as a **heartbeat mechanism** — where the monitoring client polls the server at regular intervals (e.g., every 10 seconds or every minute) to confirm that the application is responsive. If no response is received within the expected time, the monitoring system can trigger alerts, mark the service as “unhealthy,” or even initiate failover mechanisms to reroute traffic to healthy nodes.

While these heartbeats are not designed for end-user updates, they rely on the same core principle of polling — the continuous “pulling” of data to verify system status or maintain synchronization between distributed components. This model ensures proactive detection of downtime and is widely used in cloud services, load balancers, and container orchestration platforms like **Kubernetes**, which continuously poll container states to ensure they’re running as expected.

When to Use Long Polling Over WebSockets

Choosing between WebSockets and long polling depends on the system’s communication requirements and infrastructure constraints. Long polling is an excellent choice when:

- **WebSockets are not supported** by the client, network, or proxy.
- **Bidirectional communication is not critical**, and updates are mostly server-to-client.
- The system operates within **REST-based architectures** that rely on HTTP semantics.
- The application requires **periodic, event-driven updates**, not continuous streaming.

WebSockets, on the other hand, should be preferred for **high-frequency**, **low-latency**, **real-time** systems like multiplayer games, collaborative tools, or live stock tickers where both client and server need to send updates freely and rapidly.

## Protocols Beyond REST

For over a decade, **REST (Representational State Transfer)** has been the de facto standard for building APIs. It brought simplicity, scalability, and a clear separation between client and server, making it ideal for the web era. However, as applications have grown more complex—particularly with the rise of **microservices**, **real-time systems**, and **data-rich frontends**—REST has begun to show its limitations.

Two major modern alternatives have emerged to address these limitations: **gRPC** and **GraphQL**. While both aim to improve efficiency and flexibility, they do so in very different ways. **gRPC** is designed for high-performance, low-latency communication, primarily in backend and service-to-service environments. **GraphQL**, on the other hand, provides flexibility and precision in data retrieval, giving clients the power to define exactly what data they need.

Before diving into each, let’s first understand why REST is not always enough in today’s architectures.

### Limitations of REST APIs

Despite its widespread adoption, REST’s design around fixed endpoints and stateless interactions introduces certain challenges for modern systems:

1.  **Overfetching and Underfetching:**  
    REST endpoints typically return a predefined data structure. Clients often receive more data than needed (overfetching) or too little data (underfetching), forcing them to make multiple requests. For example, fetching a user’s profile might return every detail—address, preferences, and settings—when only the name and email are required.
2.  **Multiple Round Trips and Latency:**  
    When a client needs related data—say, a user and their recent transactions—it might need to make several requests to different endpoints. This increases latency and bandwidth usage, which is particularly harmful in mobile networks or large distributed systems.
3.  **Lack of Real-Time Support:**  
    REST is fundamentally **request-response** driven. The server only responds when the client explicitly asks for data. This makes real-time communication (such as chat messages or live updates) difficult to achieve efficiently, often forcing developers to rely on **polling**, **long polling**, or **WebSockets** as workarounds.

To overcome these issues, modern systems often incorporate **gRPC** and **GraphQL**—two technologies that push beyond REST’s traditional limits in performance and flexibility.

### gRPC — High-Performance Communication for Microservices

**gRPC (Google Remote Procedure Call)** is a **high-performance, open-source RPC framework** developed by Google. It enables efficient communication between services using a **contract-first approach** with **Protocol Buffers (Protobuf)** as its data serialization format. Unlike REST, which uses JSON over HTTP/1.1, gRPC is built on **HTTP/2**, allowing it to handle **multiple requests simultaneously**, compress data more effectively, and even support **real-time streaming**.

At its core, gRPC is designed for **speed, efficiency, and type safety**, making it a perfect fit for **microservices** and **distributed systems** where services must communicate frequently and reliably.

How gRPC Works

1.  **Service Definition using Protocol Buffers:**  
    In gRPC, APIs are defined using a .proto file, where developers describe services and the methods they expose, along with structured message types. This acts as a formal **contract** between client and server. For example:

service UserService {

rpc GetUser(UserRequest) returns (UserResponse);

}

Once defined, gRPC automatically generates client and server code for multiple programming languages, including Go, Java, Python, and C#.

1.  **Binary Serialization with Protobuf:**  
    Instead of JSON, gRPC uses **Protocol Buffers** for serializing structured data. Protobuf is compact and efficient, resulting in smaller payloads and faster transmission. This makes gRPC ideal for **low-bandwidth** environments.
2.  **HTTP/2 and Multiplexing:**  
    Built on HTTP/2, gRPC supports **multiplexing**, meaning multiple requests and responses can flow over a single connection simultaneously. This eliminates the head-of-line blocking problem inherent in HTTP/1.1 and reduces connection overhead.
3.  **Streaming and Real-Time Communication:**  
    gRPC supports four types of communication:
    - Unary RPC (one request, one response)
    - Server streaming (one request, multiple responses)
    - Client streaming (multiple requests, one response)
    - Bidirectional streaming (both sides stream continuously)

This **full-duplex communication** model makes gRPC particularly powerful for real-time systems like chat servers, IoT telemetry, or live data analytics.

Advantages of gRPC

- **High Performance:** Binary serialization and HTTP/2 compression lead to minimal latency and high throughput.
- **Cross-Language Compatibility:** Code generation enables seamless communication between services written in different languages.
- **Streaming Support:** Enables real-time data exchange directly within the protocol.
- **Strong Typing and Contracts:** Strictly defined Protobuf schemas prevent data mismatches and ensure consistent communication.

Ideal Use Cases

- **Microservices Communication:** Efficient inter-service communication in large-scale architectures.
- **Real-Time Data Streaming:** Financial trading, IoT telemetry, and analytics pipelines.
- **Low-Bandwidth or Edge Environments:** gRPC’s lightweight payloads make it ideal for constrained networks.
- **Polyglot Systems:** When services are built using different programming languages.

When Not to Use gRPC

Despite its strengths, gRPC may not be suitable for **public-facing APIs** or **browser-based applications** since browsers do not natively support HTTP/2-based gRPC calls. In such cases, REST or GraphQL may offer simpler integration and broader compatibility.

### GraphQL — Flexible Data Fetching for Modern Clients

While gRPC focuses on backend efficiency, **GraphQL** addresses frontend flexibility. Developed by Facebook, GraphQL is a **query language for APIs** and a **runtime for executing those queries**. It allows clients to request exactly the data they need — nothing more, nothing less. Unlike REST, which exposes multiple endpoints for different resources, GraphQL typically exposes a **single endpoint**, and clients describe the exact shape of the data they want in a single query.

At the heart of GraphQL lies a **schema**, which defines all types of data available in the API and how they relate. This schema serves as a **strongly typed contract** between client and server, ensuring clarity and consistency in communication.

How GraphQL Works

1.  **Schema Definition:**  
    A GraphQL API starts with defining a schema, specifying types and relationships. For example:

type User {

id: ID

name: String

email: String

posts: \[Post\]

}

This schema acts as a blueprint for the data that can be queried.

1.  **Client Queries:**  
    Clients send a query specifying exactly what they need:

{

user(id: 1) {

name

email

posts {

title

}

}

}

The server then returns precisely that information—no more, no less.

1.  **Resolvers:**  
    Each field in the schema has a resolver function that tells the GraphQL server how to fetch the corresponding data, whether from a database, microservice, or external API. This makes GraphQL highly extensible and capable of **aggregating data from multiple sources**.

Advantages of GraphQL

- **Eliminates Overfetching and Underfetching:** Clients control what data is returned.
- **Single Endpoint:** Simplifies API management and reduces the need for multiple requests.
- **Strong Typing:** The schema ensures predictable and validated responses.
- **Aggregated Data Access:** GraphQL can unify data from multiple services or databases into a single response.
- **Ideal for Modern Frontends:** Especially suited for mobile apps and single-page applications where bandwidth and performance are critical.

Ideal Use Cases

- **Frontend-Driven APIs:** Mobile and web applications where different components need different data.
- **Complex or Nested Data:** Scenarios requiring related entities in one query.
- **Data Aggregation Layer:** Systems combining multiple microservices or databases into a unified API.
- **Low-Bandwidth Environments:** Optimized queries reduce payload size and latency.

When Not to Use GraphQL

GraphQL adds server complexity — especially in caching, authorization, and rate limiting. It might be overkill for simple CRUD APIs or systems that don’t need dynamic data selection. REST remains preferable for simpler, predictable interfaces, while GraphQL shines when data flexibility and efficiency matter most.

# Chapter 4 — Architectural Styles

System Architecture is the overall structure of the software and the ways in which that structure provides conceptual integrity for a system.

There are countless system design architectures, each tailored to specific needs and contexts. Here's a list of some prominent ones, along with their pros and cons:

## Monolithic Architecture

A Monolithic Architecture is like a well-built castle – everything's under one roof! All the parts, from foundation to towers, are tightly packed together. It's simple, efficient, and easy to manage. But just like a castle, adding rooms or changing the layout gets tricky, and one big crack can bring the whole thing down.

That's the gist of Monolithic Architecture in the software world. It's a single codebase where everything's connected, making it straightforward to develop and deploy. But scaling gets tough, and changes can be risky. Think of it as a strong foundation for smaller projects, but less flexible for grand renovations.

## Multi-Tier Vs Multi-Layer

In the context of software architecture, the terms “multi-tier” and “multi-layer” are often used interchangeably, but they have distinct meanings:

Multi-layer architecture refers to how the codebase is organized into logical layers. Each layer has a specific role and responsibility within the application. For example, a typical three-layer architecture might consist of a presentation layer (UI), a business logic layer, and a data access layer. The MVC framework is an perfect example of this.

Multi-tier architecture, on the other hand, refers to the physical distribution of these layers across multiple servers or machines. In a multi-tier system, each layer runs on a separate hardware platform. This separation can enhance performance, scalability, and security.

In a monolithic architecture, all the components of the application are interconnected and interdependent. In the context of a monolithic application, multi-layer refers to the organization of code into layers within a single application, while multi-tier would imply that different parts of the application are deployed on different servers.

The three-tier architecture is the most popular implementation of a multi-tier architecture and consists of a single presentation tier, logic tier, and data tier. The following illustration shows an example of a simple, generic three-tier application.

In the two-tier architecture, one tier contains presentation and logic, and data tier. For example, Mobile app contains both UI and business logic and use Api calls to communicate with database.

To summarize, a layer is a logical separation within the application, and a tier is a physical separation of components. Most of the time, it makes sense to split the above-mentioned tiers to achieve further architecture flexibility, synergy, security, and efficiency.

- **Pros:** Simple to develop and deploy, easy to manage and debug, efficient performance.
- **Cons:** Not scalable, tightly coupled components make changes risky, single point of failure.

## Microservices Architecture

Imagine a bustling city instead of a castle! Microservices Architecture is like a metropolis where everything revolves around specialized districts. Each district, a microservice, handles a specific task like shopping, entertainment, or transportation. They work together through well-defined roads (APIs) to keep the city running smoothly.

- **Pros:** Highly scalable and fault-tolerant, independent deployment and development cycles, agile and adaptable.
- **Cons:** Increased complexity, challenges in distributed tracing and debugging, higher operational overhead.

Overall, Microservices Architecture is like a flexible, adaptable city, perfect for large, ever-evolving applications. But remember, it comes with its own set of challenges.

## Serverless Architecture

Imagine a magical restaurant where you don't need a kitchen! That's Serverless Architecture in a nutshell. You focus on crafting delicious dishes (your code), and a trusty wizard (cloud provider) takes care of the cooking (servers) behind the scenes.

  

- **Pros:** Highly scalable and elastic, pay-per-use model reduces cost, no server management required.
- **Cons:** Vendor lock-in, potential cold start latency, limited debugging options, can be expensive for long-running tasks.

## Client-Server Architecture

Imagine a fancy restaurant with expert chefs and attentive waiters! That's Client-Server Architecture in a nutshell.

The kitchen (server) handles cooking and food preparation, while the waiters (clients) take orders and deliver meals. Each has clear responsibilities. Waiters communicate orders to the kitchen, and the kitchen sends back prepared dishes. They work together through a well-defined process.

  

All the food and recipes are stored in the kitchen, ensuring consistency and control. It's like a central hub for data and services.

- **Pros:** Clear separation of concerns, improved security, centralized data management.
- **Cons:** Increased network traffic, single point of failure at the server, potential performance bottlenecks.

## Event-Driven Architecture

Imagine a bustling cityscape where things happen in response to events, not schedules. That's the essence of Event-Driven Architecture. The is genially use in one direction communication.  

  

- **Pros:** Highly decoupled components, responsive to real-time events, scalable and reliable.
- **Cons:** Increased complexity, debugging challenges, requires robust event handling infrastructure.

## Layered Architecture

Imagine a beautiful cake! Layered Architecture is like building that cake with distinct, delicious layers, each with its own purpose.

  

&nbsp;

- **Pros:** Organized and maintainable, promotes code reuse, simplifies testing and deployment.
- **Cons:** Can be inflexible, performance overhead due to layered dependencies, potential bottlenecks at lower layers.

## Peer-to-Peer Architecture

Imagine a lively market where everyone is both shopkeeper and shopper! That's the essence of Peer-to-Peer (P2P) Architecture, where everyone plays an equal role in sharing resources and completing tasks.

&nbsp;

- **Pros:** Highly scalable and resilient, no central point of failure, efficient for sharing resources.
- **Cons:** Increased complexity, security challenges, potential for data inconsistencies.

## Hybrid Architectural Models

A **hybrid architectural model** is a system design approach that combines elements from multiple architectural styles to leverage their respective strengths and mitigate their weaknesses. In real-world applications, no single architectural pattern can perfectly satisfy all requirements—scalability, performance, maintainability, and fault tolerance—so hybrid models are often adopted.

### Why Hybrid Architectures?

- **Complex Requirements**: Modern applications often need to support multiple interaction patterns, such as synchronous requests and asynchronous event processing.
- **Scalability & Flexibility**: Combining patterns allows scaling specific components independently while optimizing cost and performance.
- **Evolution & Migration**: Legacy systems may require hybrid approaches to gradually integrate newer architectures (e.g., moving from monolith to microservices).
- **Business-Specific Needs**: Different parts of a system may have distinct performance, consistency, and reliability requirements.

### Common Hybrid Approaches

1.  **Monolith + Microservices**
    - Core functionality remains in a monolithic system for simplicity and transactional consistency.
    - New features or high-traffic modules are developed as microservices to improve scalability and independent deployment.
2.  **Event-Driven + RESTful Services**
    - Critical, real-time operations use **event-driven messaging** for asynchronous processing.
    - User-facing APIs use **REST/HTTP** for synchronous request-response interactions.
3.  **Microservices + Serverless**
    - Core business logic runs in **microservices** for flexibility and modularity.
    - Event-driven tasks, scheduled jobs, or lightweight operations are implemented using **serverless functions** for cost efficiency and automatic scaling.
4.  **Layered + Event-Driven Architecture**
    - Traditional **layered architecture** (presentation, business, data) manages most system operations.
    - **Event-driven patterns** are used for decoupled communication, audit logging, and notifications.

### Benefits of Hybrid Models

- **Flexibility**: Select the right architecture for each subsystem based on its requirements.
- **Incremental Modernization**: Systems can evolve without a full rewrite.
- **Optimized Performance**: High-throughput components can leverage event-driven or serverless patterns.
- **Improved Reliability**: Critical modules can be isolated using microservices or messaging patterns.

### Challenges of Hybrid Architectures

- **Increased Complexity**: Managing multiple patterns, communication mechanisms, and monitoring becomes harder.
- **Consistency Management**: Ensuring data consistency across different architectural styles requires careful planning.
- **Operational Overhead**: Deployment, logging, monitoring, and fault handling are more complex than in a single-pattern architecture.

**In Practice:**  
Many large-scale systems adopt hybrid architectures. For example, an e-commerce platform may use:

- A **monolithic backend** for transactional order processing
- **Microservices** for inventory, recommendation engines, and search
- **Event-driven messaging** for notifications and analytics
- **Serverless functions** for lightweight image processing tasks

This approach provides the **best of multiple worlds**, optimizing the system for **scalability, reliability, and maintainability**.

# Chapter 5 — Web Application Foundations

The web is the foundation upon which nearly all modern software systems are built. Whether it is a social media platform connecting billions of users, an e-commerce website serving transactions worldwide, or a cloud service orchestrating data across regions, the web defines how systems communicate, scale, and deliver value. Understanding its principles is not only vital for system designers but also forms a cornerstone of every software engineer’s professional expertise.

In this chapter, we will explore the key concepts that define the architecture of web applications — the client–server model, the stateless nature of HTTP, the management of user sessions, the process of serialization for data exchange, the principles of web security, and the mechanisms of versioning and content negotiation that make APIs robust and flexible. Each of these topics builds upon the other, creating a holistic understanding of how large-scale web systems are designed for scalability, reliability, and performance.

## The Importance of Web Concepts in System Design

Before delving into technical details, it is essential to understand why web concepts matter so profoundly in system design. The web is not merely a platform for browsing — it is the underlying network that powers APIs, connects distributed microservices, synchronizes data streams, and delivers real-time experiences to users worldwide. Every scalable system — whether it is Netflix streaming petabytes of data or Amazon handling millions of concurrent orders — relies on web principles to function effectively.

Three pillars define the success of a web-based system: **scalability**, **security**, and **performance**. Scalability ensures that an application can grow to meet user demand. Security protects sensitive information from unauthorized access and attacks. Performance guarantees responsiveness and reliability, keeping users engaged. A deep understanding of these principles is essential not only for building real systems but also for succeeding in system design interviews, where topics like session management, data serialization, and cross-origin security frequently appear.

## Managing State in a Stateless World

At the heart of every web interaction lies the **HTTP protocol**, which is inherently **stateless**. This means that every HTTP request is independent — the server does not remember who sent the previous request or what actions were performed before. While this design simplifies communication and scalability, it introduces a major challenge: how do we maintain a continuous user experience, such as remembering who is logged in or what items remain in a shopping cart?

This is where **state management** becomes essential. Web applications use mechanisms such as **cookies**, **sessions**, and **tokens** to persist user data between requests.

In **session-based authentication**, the server maintains the user’s session information in memory or a database and issues a unique session ID stored as a cookie on the client. Each time the client sends a request, the session ID is included, allowing the server to recognize the user. This method is simple but difficult to scale because session data must be shared among servers in distributed environments.

To address scalability concerns, modern applications often use **token-based authentication**, particularly through **JWTs (JSON Web Tokens)**. Instead of storing session data on the server, JWTs embed the necessary user information within the token itself. This makes the approach stateless, lightweight, and ideal for microservices and APIs. However, since the token resides on the client, it must be carefully protected from theft or replay attacks.

In distributed systems, scalable session management is achieved using techniques such as **sticky sessions**, where each user is consistently routed to the same server, or **distributed session storage**, where sessions are stored in external caches like **Redis** or **Memcached**, allowing any server to access session data. Each technique involves trade-offs between simplicity, scalability, and fault tolerance.

## Serialization: Structuring Data for the Web

In the interconnected world of APIs and distributed systems, **serialization** is the process that allows structured data to travel across the network. Serialization converts complex in-memory objects into a format that can be easily stored or transmitted, while **deserialization** reconstructs the original object from the serialized data. Without serialization, communication between different systems — often built in different programming languages — would be slow, inefficient, and error-prone.

Three of the most common serialization formats are **JSON**, **XML**, and **Protocol Buffers (Protobuf)**.

### JSON

**JSON (JavaScript Object Notation)** has become the de-facto standard for web APIs due to its simplicity, readability, and wide language support. It uses a lightweight key–value structure and integrates naturally with JavaScript, making it ideal for browser–server communication. However, JSON’s text-based nature increases data size and transmission time.

### XML

**XML (Extensible Markup Language)**, once dominant in enterprise systems, is more verbose and tag-based but supports complex hierarchical structures and strict schema validation. This makes XML suitable for banking, insurance, and legacy enterprise applications that prioritize data integrity over transmission speed.

  
Protocol Buffers

**Protocol Buffers (Protobuf)**, developed by Google, use a compact binary format and predefined schema to achieve high performance. They are not human-readable but offer superior efficiency, making them ideal for gRPC-based microservices and real-time communication systems where bandwidth and speed are critical.

Choosing between these formats depends on the trade-off between readability, performance, and compatibility. JSON is preferred for public APIs and web applications; XML remains relevant in schema-heavy enterprise systems; and Protobuf excels in internal, performance-critical architectures.

## API Versioning: Evolving Without Breaking

As applications evolve, APIs must change — new features are added, data structures are modified, and old endpoints are deprecated. However, such changes can easily break existing clients that rely on earlier API versions. **API Versioning** is the practice of maintaining backward compatibility while allowing innovation and evolution.

Versioning can be implemented in several ways. The simplest method is through the **URL path**, such as /api/v1/users or /api/v2/users, where each version represents a distinct API contract. Another common method uses **HTTP headers**, where clients specify the desired version through a custom header like Accept-Version: v2. This approach keeps URLs clean and provides flexibility for API evolution.

API versioning ensures stability and predictability in distributed systems, allowing multiple client versions — such as mobile apps, web clients, or third-party integrations — to coexist without conflict. Thoughtful versioning policies reflect a mature, developer-friendly API design and are crucial for long-term scalability.

## Content Negotiation: Serving the Right Representation

Closely related to versioning is **Content Negotiation**, a mechanism that allows a client to specify the desired format or representation of a resource. For example, a client can request either JSON or XML by setting the Accept header (Accept: application/json or Accept: application/xml). The server examines this header and responds in the appropriate format.

Content negotiation is a core part of **RESTful API design**, as it decouples the client from rigid assumptions about data format. It also supports localization and personalization, allowing clients to receive content in their preferred language (Accept-Language) or encoding (Accept-Encoding). In modern APIs, content negotiation enhances flexibility, reduces redundancy, and improves the developer experience by enabling a single endpoint to serve multiple representations.

## Web Security and Cross-Origin Resource Sharing (CORS)

Security is the backbone of any web system. A scalable application that is not secure is fundamentally flawed. One of the most common challenges in web security arises from the **same-origin policy**, a browser restriction that prevents scripts on one domain from accessing resources on another. While this policy protects users from malicious sites, it can hinder legitimate cross-domain interactions between modern web services.

**Cross-Origin Resource Sharing (CORS)** provides a controlled way to relax this restriction. It allows a server to specify which origins are permitted to access its resources by including headers such as Access-Control-Allow-Origin, Access-Control-Allow-Methods, and Access-Control-Allow-Headers. When configured correctly, CORS enables safe communication between APIs, front-end applications, and third-party integrations.

Beyond CORS, securing web applications involves defending against threats like **Cross-Site Request Forgery (CSRF)** and **Session Hijacking**. Using HTTPS, secure cookies, CSRF tokens, short-lived access tokens, and SameSite attributes are standard practices. These measures ensure that while systems remain accessible and scalable, they also maintain confidentiality, integrity, and trustworthiness.

# Chapter 6 — Scalability in System Design

Scalability lies at the very heart of modern system design. As applications grow, the demand on performance, reliability, and cost efficiency also grows. A system designed for scalability ensures that whether it serves a thousand users or a hundred million, it continues to perform predictably and reliably under pressure. In this chapter, we will unpack the concept of scalability, understand why it is essential, and explore the practical strategies that make systems scale smoothly and efficiently. We will begin by defining what scalability really means, examine its different forms—vertical, horizontal, and diagonal—and study how and when to use each. Later, we will explore load balancing and auto-scaling, two critical enablers of elastic infrastructure in the cloud, and conclude by reflecting on best practices and trade-offs involved in building scalable systems.

## Understanding Scalability

Scalability, at its core, is the ability of a system to handle increased workload gracefully without breaking down, slowing, or becoming unreliable. It ensures that as traffic, data volume, or transactions grow, the system maintains performance, availability, and reliability. A scalable system is like a well-trained athlete—it adapts to increased stress without losing form. This property allows systems to grow from small prototypes into global platforms without requiring a complete architectural overhaul. When a system scales well, users should not even notice the growth in traffic; the experience should remain seamless regardless of load.

### Why Systems Must Scale

Most systems begin small—with manageable user bases and predictable data volumes. However, as they mature, they face exponential growth in several dimensions. The first and most obvious factor is user growth. Applications may expand into new regions or go viral overnight, leading to a sudden surge in active users. Second, as more users interact with the system, data volume grows rapidly—especially in IoT, analytics, or social media platforms where billions of data points are generated daily. Third, peak events such as Black Friday sales, concert ticket releases, or breaking news can cause traffic to spike tenfold within seconds. If a system is not designed to scale, it risks crashing at precisely the moment it is most needed. Furthermore, scalability is essential to maintain service-level agreements (SLAs) that define strict performance and uptime guarantees, such as sub-200 millisecond response times or 99.99% availability. Simply put, if your system cannot scale, it cannot grow—and in competitive digital ecosystems, that often means it cannot survive.

### Types of Scalability

There are primarily two forms of scalability: vertical and horizontal.

Vertical scaling, or scaling up, means adding more power to a single machine—upgrading the CPU, increasing RAM, or expanding storage. It is simple to implement but has physical and financial limits. Once the hardware is maxed out, scaling further becomes impractical or prohibitively expensive.

Horizontal scaling, or scaling out, takes a different approach. Instead of making one machine more powerful, we add more machines and distribute the load across them. This method underpins most large-scale distributed architectures and cloud-native systems. Each machine handles a portion of the total workload, and together they serve millions of requests concurrently. While more flexible and fault-tolerant, horizontal scaling introduces complexity in coordination, state management, and data consistency.

Many real-world systems therefore adopt a hybrid approach—diagonal scaling—which begins with vertical scaling for simplicity and later extends horizontally as demand grows. This hybrid approach provides a practical path that balances cost and complexity while ensuring future growth.

### Challenges of Scaling

Designing scalable systems is not without challenges. One major concern is latency—the time delay between a user’s request and the system’s response. As services multiply across networks, latency increases due to inter-service communication and data synchronization. Another challenge is bottlenecks. A system is only as strong as its weakest component. A single slow database, under-optimized service, or memory-bound task can bring an entire distributed architecture to its knees. Downtime is another scaling hazard. The more servers and services a system includes, the greater the chance of partial failures, deployment disruptions, or synchronization errors. Finally, cost becomes a crucial factor. Scaling up or out consumes more resources—compute power, bandwidth, and storage—which all add up quickly in cloud environments. Without careful monitoring and automation, costs can spiral out of control. Thus, scaling is not just a technical exercise—it’s a continuous balance between performance, reliability, and efficiency.

### Scaling Strategies in Practice

Let us now explore how these scaling strategies work in real systems. Vertical scaling is the simplest to begin with—just add more memory, processing power, or disk capacity to the existing server. It requires no architectural changes, and performance improvements are often immediate. However, vertical scaling has a ceiling and creates a single point of failure. Horizontal scaling, in contrast, adds more servers or containers and uses mechanisms such as load balancers to distribute the workload evenly. For this to work effectively, the system must be designed to be stateless or use a shared state mechanism like a distributed cache or database. Horizontal scaling offers redundancy, resilience, and near-infinite scalability, but it also introduces synchronization and coordination challenges. Diagonal scaling, a blend of both, allows organizations to start small with vertical scaling and later expand horizontally when necessary. It is a pragmatic and cost-effective path, widely used in cloud-native environments where workloads fluctuate.

### Cost, Complexity, and Performance Trade-offs

Every scaling strategy sits within the triangle of cost, complexity, and performance. Vertical scaling is initially cheap and straightforward, but hardware upgrades quickly become expensive. Horizontal scaling brings flexibility and fault tolerance but requires careful architectural planning, load balancing, and monitoring. Performance-wise, vertical scaling delivers great results for single-threaded, CPU-intensive workloads, whereas horizontal scaling shines for parallel processing and large-scale concurrency. Diagonal scaling strikes a balance—simple at the start yet ready to evolve with growth. The art of system design lies in choosing the right trade-offs based on your system’s maturity, traffic patterns, and business needs.

### Real-World Examples

Twitter provides a textbook case of scaling evolution. In its early days, Twitter operated as a monolithic application, which was adequate for a small user base. However, as global adoption surged, performance issues forced the company to re-architect the system. Twitter embraced horizontal scaling, breaking the monolith into microservices, introducing distributed databases, caching layers, and load balancers. This shift allowed the platform to handle massive real-time traffic reliably. Similarly, many modern startups begin with simple vertical scaling—one application and one database. It’s efficient and fast to deploy during the early stages. As user growth accelerates, they transition to horizontal scaling, adopting stateless microservices, redundancy, and distributed data systems. Cloud-native applications often follow a diagonal scaling model, starting small but designed to grow elastically using auto-scaling features provided by cloud platforms.

## Auto Scaling in the Cloud

In today’s cloud-driven world, scalability has become automated through a mechanism called auto scaling. Auto scaling dynamically adjusts compute resources based on system load. It automatically adds servers during traffic surges and removes them when demand drops, ensuring both performance and cost optimization. Cloud providers like AWS, Azure, and Google Cloud have made auto scaling a first-class feature across services such as EC2, Lambda, AKS, and Cloud Run. Auto scaling decisions are triggered by metrics such as CPU utilization, memory usage, request rate, or queue length. Scaling policies may be reactive—responding to threshold breaches—or predictive—anticipating demand based on historical patterns. Predictive scaling is especially powerful for recurring traffic patterns, such as daily user spikes.

## Monitoring and Cost Optimization

Monitoring plays a pivotal role in making auto scaling effective. Key performance indicators such as CPU, memory, network traffic, and queue depth are continuously tracked using tools like AWS CloudWatch or Azure Monitor. These insights help systems adopt proactive scaling, adjusting capacity before performance degradation occurs. However, with flexibility comes financial responsibility. Smart cost management is essential. Overprovisioning wastes resources, while under provisioning risks outages. Cloud providers offer solutions such as spot instances (in AWS or Azure) and preemptible VMs (in GCP) that deliver significant cost savings for non-critical workloads. Developers should also use strategies like right-sizing instances, defining scaling quotas, and enabling scale-to-zero features for idle services. The ultimate goal is to build systems that are not only performant and reliable but also economically efficient.

# Chapter 7 — Databases & Storage

In every large-scale system, **data storage lies at the very heart of the architecture**. Whether it’s a messaging application, a banking platform, or a content delivery network, the way data is stored, retrieved, and managed defines the system’s performance, reliability, and scalability. This section explores how systems handle data at scale — not just how they store it, but how they architect for durability, availability, and future growth.

Every system generates and consumes data. It could be user inputs, application logs, media files, or analytical results. But merely generating data isn’t enough; systems must **store it reliably, retrieve it efficiently, and manage it intelligently at scale**. Persistent storage enables the very features we depend on daily — from user profiles and saved preferences to transaction history, recommendations, and analytics dashboards.

When designing scalable and fault-tolerant systems, **storage cannot be an afterthought**. It must be a core architectural concern, considered early in the design process. The wrong choice of storage technology can create bottlenecks, increase latency, or even risk data loss. The right choice, however, can make the difference between a system that merely functions and one that scales effortlessly to millions of users.

## Understanding Data: Structured, Semi-Structured, and Unstructured

When designing a modern data architecture, it is crucial to understand not only the volume and velocity of data but also its **structure** — the way it is organized, represented, and stored. Broadly, data falls into two categories: structured, semi-structured, and unstructured. Each type serves different purposes and demands distinct storage solutions.

### Structured Data

Structured data represents information that follows a **rigid, predefined schema** — meaning every piece of data fits neatly into tables with specific data types and relationships. This is the world of relational databases like **PostgreSQL**, **MySQL**, and **SQL Server**.  
Each record follows the same pattern of fields and constraints, making it easy to query using **SQL** and ensuring **data integrity, consistency, and atomicity** through ACID transactions.

For example, a Users table might contain columns such as UserId, Email, CreatedAt, and IsActive. Every record in this table conforms to that schema. Structured data is ideal for use cases requiring **complex joins, relationships, and strict validation** — such as financial transactions, employee records, or inventory management.

### Semi-Structured Data

Between structured and unstructured data lies **semi-structured data** — a flexible format that still contains **organizational elements** but does not strictly enforce schema rigidity.  
It has an internal structure that can be interpreted by machines but allows variation between records. Common representations include **JSON**, **XML**, **YAML**, and **Avro**.

This flexibility is what makes **semi-structured storage systems** — such as **Document Databases (MongoDB, Couchbase, Firebase Firestore, Azure Cosmos DB)** — so powerful. They allow developers to evolve schemas dynamically as the application grows, without costly migrations.

Semi-structured data is particularly suited for **content management systems**, **IoT data ingestion**, and **user activity tracking**, where each record may differ slightly but still maintains identifiable key-value pairs or nested attributes.

Document-oriented databases store each record as a **document**, often in JSON or BSON format. Unlike rows in relational databases, these documents can vary in structure. Queries are executed using document-specific query languages that can traverse nested fields, filter data, and even perform aggregations efficiently.

Semi-structured storage thus provides the **perfect balance between flexibility and organization**, enabling rapid application evolution without sacrificing readability or searchability.

### Unstructured Data

Unstructured data lacks any predefined model or consistent format. It includes **text documents, emails, multimedia files (videos, images, audio)**, and even **sensor data** that does not fit neatly into tables or documents.  
Unlike structured data, it cannot be queried using SQL, and unlike semi-structured data, it lacks a uniform schema or metadata to guide interpretation.

Storage systems such as **Amazon S3**, **Azure Blob Storage**, and **Google Cloud Storage** are designed to handle unstructured data at immense scale. These systems store data as “objects,” each identified by a key and optionally enriched with metadata for retrieval and indexing.

While unstructured data cannot be easily queried in traditional ways, modern data processing tools — such as **Elasticsearch**, **Apache Spark**, or **machine learning pipelines** — can extract meaning and structure dynamically through indexing, tagging, or AI-based classification.

## Core Storage Properties

When evaluating or designing storage systems, several **core properties** determine how the system behaves — especially in distributed environments:

- **Durability:** Once data is written, it must persist even in the event of crashes, power failures, or hardware breakdowns. Durability ensures that data, once stored, remains safe over time.
- **Availability:** Availability defines the system’s ability to serve data on demand — even when part of the system fails. Highly available systems, such as payment or messaging platforms, are designed to remain operational despite node or network failures.
- **Consistency:** Consistency guarantees that every read reflects the most recent write. In other words, once data is updated, subsequent reads should reflect the latest version.
- **Atomicity:** Commonly discussed in transactional systems, atomicity ensures that a group of operations either all succeed or all fail. This “all-or-nothing” behavior keeps systems in valid states during complex updates.

These properties form the **foundation of trade-off analysis** in storage design — balancing durability, performance, and fault tolerance based on business needs.

## ACID Transactions

ACID stands for Atomicity, Consistency, Isolation, and Durability. These are four key properties that ensure reliable and consistent data handling in databases. Imagine them as safety nets for your data:

- **Atomicity:** Either all parts of a transaction succeed, or none do. No half-finished updates!
- **Consistency:** Data remains valid before and after each transaction. Think of it as keeping the books balanced.
- **Isolation:** Transactions don't interfere with each other. One transaction's update won't affect another until it's complete.
- **Durability:** Once committed, changes persist even if the system crashes. Consider it as writing in ink, not pencil.

**Benefits**

- **Data integrity:** ACID protects your data from inconsistencies and corruption.
- **Reliability:** Even with failures, transactions ensure updates are correct and completed.
- **Consistency:** Data always maintains its logical rules and constraints.

**Trade-offs**

- **Overhead:** ACID features add processing steps, potentially impacting performance.
- **Deadlocks:** Concurrent transactions waiting for each other can freeze up the system.
- **Scalability:** ACID can be challenging to implement in large, distributed systems.

**Alternatives**

- **BASE:** Emphasizes availability over immediate consistency, suitable for high-volume systems.
- **CAP theorem:** Explains trade-offs between consistency, availability, and partition tolerance.
- **NoSQL databases:** Prioritize scalability and performance over strict ACID guarantees.

**When to use ACID**

- Banking, healthcare, e-commerce: Crucial for accurate and secure financial transactions, patient records, and order processing.
- Mission-critical applications: Where data integrity and reliability are paramount.

**Remember:** ACID isn't always the best fit. Evaluate your needs and consider alternatives like BASE for more flexible approaches in specific scenarios.

&nbsp;

## The Triad of Trade-offs: Scalability, Reliability, and Performance

Real-world storage design is an exercise in trade-offs. There is no “perfect” system that excels equally in scalability, reliability, and performance.

- **Scalability** ensures the system can handle growing data volumes and user requests without degradation.
- **Reliability** ensures the system remains operational even in the face of partial failures.
- **Performance** determines how quickly data can be read and written — directly affecting user experience.

Improving one dimension often compromises another. For instance, strong reliability through replication may introduce latency, while extreme performance optimization can reduce scalability. The role of a system designer is to make **informed, context-driven trade-offs** that align with both technical and business priorities

## CAP Theorem

Imagine a distributed database: data scattered across different servers. Network failure strikes! Can you access all your data (availability) or ensure it's always up-to-date (consistency)? The distributed system with replicated data can only offer two out of three: Consistency, Availability, and Partition Tolerance (dealing with network hiccups). So, you gotta choose!

### CAP Theorem says: pick two!

- **Consistency:** Latest data guaranteed, but might be unavailable during errors. (Think accurate bank balance.)

  
<br/>

- **Availability:** Always accessible, but data might be outdated. (Think online shopping during peak hours.)

  
<br/>

- **Partition Tolerance:** Must-have for distributed systems – handles network issues.

Think of it as a recipe: high consistency comes with a dash of reduced availability, and vice versa.

According to the theorem, a distributed system **cannot simultaneously guarantee all three**. In the presence of a network partition (which is inevitable at scale), the system must choose between **Consistency and Availability**.

CP Systems (Consistency + Partition Tolerance)  
These prioritize correctness over availability. For example, **HBase** refuses to serve outdated data during network failures, maintaining strict accuracy — ideal for financial or banking applications.

**AP Systems (Availability + Partition Tolerance)**  
These systems prioritize uptime over consistency. **DynamoDB** is a prime example, embracing eventual consistency to maintain responsiveness, suitable for use cases like social media feeds or product catalogs.

CA Systems (Consistency + Availability)  
These systems only exist in **non-distributed environments** — for example, a standalone PostgreSQL instance, which is consistent and available as long as no network partitions occur.

Understanding CAP trade-offs enables architects to design systems according to their tolerance for stale data, downtime, or temporary inconsistency.

**Choosing your flavour:**

- **SQL databases:** Prioritize consistency for accurate data (think finances).
- **NoSQL databases:** Offer high availability for always-on services (think online shopping).

So, next time you design a system, remember the CAP Theorem – it's the secret ingredient that keeps your data dancing between consistency and availability.

## Real-World Applications of Storage Models

Different types of systems demonstrate how these principles apply in practice:

- **E-Commerce Platforms:** Relational databases store structured data like product catalogs and inventory, while unstructured assets such as images or videos live in object storage.
- **Streaming Services (e.g., Netflix, Spotify):** Media files are stored in object storage for scalability and durability, while user preferences and playback data are kept in NoSQL databases for fast reads and flexible schemas.
- **Log Aggregation Systems:** These handle massive amounts of semi-structured data, often stored in time-series databases like **InfluxDB** or columnar stores like **ClickHouse** for fast analytics, or in object storage for batch processing and archiving.

Each use case requires a **hybrid storage strategy**, combining different models to balance cost, performance, and scale.

## Database Models: SQL vs NoSQL

Databases lie at the very heart of almost every modern software system. From storing user profiles and product catalogs to powering real-time analytics and transaction systems, databases form the backbone of digital infrastructure. In this chapter, we will explore the two dominant paradigms of data storage — **Relational (SQL)** and **Non-Relational (NoSQL)** databases. We will understand how they differ in design philosophy, architecture, and use cases. Along the way, we will revisit core concepts such as **ACID and BASE properties**, connect these ideas to the **CAP theorem**, and discuss when to use which approach in real-world system design.

### The Role of Databases in System Design

At its core, a **database** is a structured system for storing, retrieving, and managing data efficiently. It allows data to persist beyond the lifetime of a single process or system restart and ensures that the information remains consistent and retrievable across time.  
But a database is much more than just storage — it is a _query engine_, _transaction manager_, and _reliability mechanism_ rolled into one. Whether you are building a simple to-do application or an enterprise-scale e-commerce platform, you inevitably need a database to store user accounts, transactions, configurations, or analytics data.

The choice of database — and how you design its structure — will profoundly affect your system’s scalability, performance, and fault tolerance.

### Relational Databases (SQL)

Relational databases are the traditional and still widely used form of data management systems. Examples include **MySQL**, **PostgreSQL**, **Oracle**, and **Microsoft SQL Server**. They are based on a simple yet powerful principle: **data is stored in tables consisting of rows and columns**, much like a spreadsheet.

Each table represents an entity — such as a user, order, or product — and every column defines a specific attribute. The power of relational databases lies in the **relationships** between these tables, established using **foreign keys** and **joins**. This relational model allows complex queries that combine and analyze data across multiple entities using **Structured Query Language (SQL)** — a declarative, human-readable language that remains the industry standard for data manipulation and retrieval.

Core Building Blocks of Relational Databases

The first pillar of relational databases is the **schema**. A schema defines the structure of your data — specifying tables, columns, data types, and relationships upfront. This rigidity ensures **data integrity**, as every piece of information must conform to the defined structure.

The second major feature is **joins**, which allow linking data across tables. For example, a user’s order history can be obtained by joining the Users table with the Orders table using a shared key. This capability makes relational databases extremely powerful for analytical and reporting workloads.

And finally, relational databases are governed by the **ACID properties**, ensuring that every transaction is reliable and leaves the database in a valid state — even in the presence of failures.

- **Atomicity** guarantees that all operations within a transaction complete successfully or none do.
- **Consistency** ensures that all integrity rules are preserved after any transaction.
- **Isolation** prevents concurrent transactions from interfering with each other.
- **Durability** ensures that once a transaction is committed, it remains permanent even after a crash.

These characteristics make SQL databases ideal for mission-critical applications such as banking, accounting, and healthcare, where correctness is more important than speed or flexibility.

Limitations of Relational Databases

Despite their strengths, relational databases have certain limitations, especially in modern distributed environments.  
First, **rigid schemas** make it challenging to handle evolving or semi-structured data where new attributes are introduced frequently — such as dynamic product metadata or user-generated content.  
Second, **horizontal scalability** is not native to most relational systems. Scaling across multiple machines often requires complex sharding or replication mechanisms, which can introduce consistency challenges.  
Third, **nested or hierarchical data** such as JSON documents or arrays do not fit naturally into the tabular model, leading to cumbersome designs or performance issues.

These challenges opened the door for a more flexible and distributed approach to data management — the **NoSQL movement**.

### NoSQL Databases

The term **NoSQL** does not mean “no SQL” but rather “not only SQL.” NoSQL databases were designed to overcome the rigidity of relational systems, offering **flexibility**, **scalability**, and **performance** for modern, web-scale applications.

Unlike SQL databases, NoSQL systems are typically **schema-less** or **schema-flexible**, allowing developers to store data without defining its structure in advance. This makes them ideal for rapidly evolving applications and unstructured or semi-structured data formats.

NoSQL is not a single technology but a **family of data models**, each optimized for different use cases and access patterns. The four primary categories are **Document Stores**, **Key-Value Stores**, **Columnar Databases**, and **Graph Databases**.

**1\. Document Databases**

Document databases store data as **JSON-like documents**. Each document can have a unique structure with nested fields and arrays. Examples include **MongoDB** and **CouchDB**. These systems are perfect for applications like content management systems, user profiles, or product catalogs — where data objects can vary in structure and size. The ability to query documents based on nested fields gives developers great flexibility without compromising performance.

**2\. Key-Value Stores**

Key-value databases, such as **Redis**, **Riak**, and **Amazon DynamoDB**, represent the simplest form of NoSQL storage. They store data as a collection of **key-value pairs**, much like a large distributed hash map. The key is unique, and the value can be any blob of data. This model is ideal for caching systems, session management, or any scenario requiring **low-latency lookups** and **high write throughput**. The simplicity of this model makes it extremely fast and horizontally scalable.

**3\. Columnar Databases**

Column-oriented databases like **Apache Cassandra**, **HBase**, and **ScyllaDB** store data by **columns rather than rows**, making them ideal for analytical workloads and large-scale data aggregation. They are designed for high write performance and can efficiently handle petabytes of time-series or log data. This makes them popular in telemetry, monitoring, and large-scale analytics pipelines.

**4\. Graph Databases**

Graph databases, such as **Neo4j** or **Amazon Neptune**, are optimized for representing and querying **relationships** between data points. Data is stored as **nodes** (entities) and **edges** (relationships), allowing for efficient traversal and pattern matching. They are ideal for social networks, recommendation engines, and fraud detection systems — where relationships between entities are as important as the entities themselves.

BASE Properties in NoSQL Systems

While relational databases follow the ACID principles, NoSQL databases often adopt a more relaxed model known as **BASE**, which stands for **Basically Available, Soft state, and Eventually consistent**.

- **Basically Available** means the system will always respond to requests — even during partial failures. The response may contain stale data, but the system remains operational.
- **Soft State** implies that the system’s state may change over time, even without new inputs, due to background synchronization among distributed nodes.
- **Eventually Consistent** ensures that all replicas will converge to the same state over time, even if not immediately after a write.

The BASE model trades strict consistency for **high availability and partition tolerance**, aligning closely with the principles of the **CAP theorem**.

**When to Use SQL vs NoSQL**

Choosing between SQL and NoSQL depends entirely on your system’s requirements.  
Use **SQL** when:

- You need **complex queries and joins** across multiple datasets.
- **Strong consistency** is mandatory (e.g., banking, payments, inventory).
- Your data is **structured and predictable**, fitting neatly into tables and columns.

Use **NoSQL** when:

- You need to **scale horizontally** across many nodes.
- Your data is **semi-structured, nested, or constantly evolving**.
- You require **low-latency access** or **real-time analytics**.

Examples include caching layers, IoT platforms, recommendation systems, and large-scale social media backends.

### Polyglot Persistence: The Modern Reality

In practice, modern systems rarely use just one database type. Instead, they embrace a strategy known as **Polyglot Persistence** — using different databases for different parts of the application based on their strengths.  
For example, an e-commerce platform might use **PostgreSQL** for orders and payments (ensuring ACID compliance), **MongoDB** for storing dynamic product information, and **Redis** for caching frequently accessed data.

This hybrid approach allows architects to design systems that are both **scalable and reliable**, leveraging the best of both SQL and NoSQL worlds.

## Object Storage: The Backbone of Modern Unstructured Data Management

In today’s cloud-driven world, data is growing faster than ever before — not in neatly structured database tables, but as images, videos, documents, log files, backups, and endless streams of machine-generated content. To store and manage this massive volume of **unstructured data**, modern infrastructure relies on a powerful storage paradigm known as **Object Storage**. Whether it is uploading media to a cloud platform, streaming content from a video service, or archiving historical records for compliance, object storage has become a foundational element of large-scale architectures.

Object storage represents a shift away from traditional storage methods such as **file storage**, which organizes data in hierarchical folders, and **block storage**, which stores data in fixed-size blocks used for disks and databases. Instead, object storage treats data as discrete **objects** stored in a **flat** structure that can scale effortlessly across servers, regions, and even continents. This architecture enables virtually unlimited growth while providing high durability and accessibility, making cloud storage services such as **Amazon S3**, **Google Cloud Storage**, and **Azure Blob Storage** indispensable in modern systems.

### What is an Object?

Every stored item in object storage is called an **object**, and each object contains three essential components:

1.  **Data** — the actual content being stored, such as a video file or a PDF.
2.  **A Unique Identifier (Key)** — allowing the system to locate and retrieve the object efficiently.
3.  **Metadata** — descriptive information about the data, such as the file type, creation timestamp, user-generated tags, or even access permissions.

The power of object storage lies particularly in **metadata**. Unlike file systems, where metadata is limited to basic details, object storage supports rich, customizable metadata that enables indexing, categorization, lifecycle rules, and fine-grained security. As a result, objects become not only stored assets but intelligently managed data entities.

### Buckets: Logical Containers for Objects

Rather than organizing objects into nested folders, cloud platforms group them into **buckets** — high-level containers capable of holding millions or billions of objects. Buckets simplify global scalability and allow services to automatically manage distribution, replication, and durability behind the scenes.

This **flat namespace** eliminates hierarchical complexity and enables consistent access patterns across global infrastructure — one of the main reasons object storage can scale to handle Internet-level workloads.

### Cloud Platforms Leading Object Storage

Multiple cloud vendors have built robust object storage solutions that define today's industry standards:

- **Amazon S3** – The most mature and widely adopted service, known for extreme durability and seamless integration with AWS analytics, AI, and serverless ecosystems.
- **Google Cloud Storage (GCS)** – Designed for simplified tiering and strong performance in machine learning and data-intensive workloads.
- **Azure Blob Storage** – Tailored for Microsoft-centric environments and well-integrated with .NET solutions, Azure Functions, and SQL workloads.

For organizations requiring control within their own data centers, open-source implementations such as **MinIO** bring cloud-native object storage capabilities to hybrid and on-prem environments.

### Real-World Use Cases

Object storage is specifically optimized for the following scenarios:

1.  **Media Content Delivery**  
    Ideal for storing images, audio, and high-resolution videos used by streaming platforms and rich web applications.
2.  **Backup and Archival Data**  
    Durable storage tiers such as “cold” or “archive” classes provide low-cost retention for disaster recovery and compliance.
3.  **Data Lakes and Analytics**  
    Cloud object storage acts as the foundational layer for big data architectures, enabling ingestion of raw datasets and downstream analytics for AI and ML.
4.  **Static Website Hosting**  
    Services like S3 can directly host HTML, CSS, and JavaScript files, eliminating the need for traditional web servers.
5.  **IoT and Sensor Data Pipelines**  
    Highly scalable ingestion supports continuous data streams from connected devices and real-time processing systems.

If an application handles huge volumes of unstructured content or requires long-term secure durability, object storage is almost always the right architectural choice.

### Performance and Cost Trade-Offs

Object storage provides enormous benefits — but with important considerations:

**Performance**

- Excellent for large objects and parallel access patterns
- Higher latency than block or file storage
- Not ideal for small, frequently updated files

Most services follow **eventual consistency**, meaning updates may take a short time to become visible globally. Additionally, updates typically require rewriting the entire object, making **write-once-read-many** workloads a perfect fit.

**Cost**

Cloud pricing depends on:

- Storage capacity
- Data transfer
- Number of API requests (PUT, GET, DELETE, LIST)

To remain cost-efficient, lifecycle policies should automatically transition rarely accessed data to cheaper tiers or delete outdated content. Intelligent management — aided by monitoring and automation — ensures maximum value.

## Distributed File Systems

In this lecture, we shift our focus from object storage to the foundational layer that power many of the world’s most critical applications: **file systems**. Whether it is a traditional file server, a laptop hard disk, or a big data processing platform like Hadoop or Spark, everything relies on some form of file system underneath. We begin by understanding how file systems work at a basic level and then progress into the world of **Distributed File Systems (DFS)** — the backbone of large-scale data storage used in advanced analytics, machine learning, and modern cloud infrastructure. By the end of this discussion, you will not only understand how distributed file systems store data across multiple machines, but you will also be confident in evaluating their strengths, limitations, and ideal use cases in real-world system design.

### What is a File System?

A **file system** is the core software layer that determines how data is stored, organized, and accessed on a physical storage device such as a Hard Disk Drive (HDD), Solid-State Drive (SSD), or removable media. Beyond merely storing content, a file system manages **metadata** including file names, timestamps, ownership information, and access permissions. It maintains hierarchical folder structures, manages read/write operations, and ensures that security rules are enforced correctly.

Common examples include:

- **ext4** — widely used in Linux distributions
- **NTFS** — the default file system for Windows
- **ZFS** — known for data integrity and used in high-performance enterprise environments

Understanding file systems is crucial because they directly affect system **performance, durability, and compatibility**, especially when choosing storage for modern applications.

### Limitations of Traditional File Systems

Traditional file systems are designed primarily for **single-machine environments**. The data and metadata are stored and managed by one system, and all operations depend on that machine. While this design works well for personal computers and small servers, it becomes restrictive in large, distributed environments.

The key limitations include:  
• **Limited Scalability** — storage capacity and performance are bound to a single machine  
• **Single Point of Failure** — if the machine fails, data can become unavailable  
• **Not built for parallel processing** — struggles with massive workloads and concurrent access

As modern applications handle **petabytes of data and global user traffic**, a new storage approach is required — one that scales seamlessly and remains resilient to node failures. This need gave rise to **Distributed File Systems**.

### What is a Distributed File System (DFS)?

A **Distributed File System** allows files to be stored and accessed across **multiple networked machines** while presenting a **unified namespace** to users and applications. In other words, although data is physically spread across many servers, it **appears as one single logical file system**.

Key advantages include:

- **High Fault Tolerance** through redundancy and replication
- **Elastic Scalability** simply by adding new machines
- **High Throughput** for parallel data access
- **Seamless user experience** with transparent location management

A notable example is **HDFS (Hadoop Distributed File System)**, the primary storage layer in the Hadoop ecosystem, widely used for big data workloads.

Distributed file systems are critical in industries involving scientific data processing, backup and archival systems, video streaming, web applications, machine learning, and large-scale analytics.

### How Distributed File Systems Work — Architecture Overview

Most DFS systems, including HDFS, rely on two primary components:

**NameNode — The Master Metadata Manager**

The NameNode is the **brain** of the system. It keeps track of:

- File directory structure
- File-to-block mapping
- Access control and permissions
- Locations of blocks stored on nodes

It does **not** store the actual data — only metadata that helps locate and manage it.

**DataNodes — The Data Storage Workers**

These nodes physically store **file blocks**. When a file is uploaded, it is split into fixed-size chunks (for example, 128 MB each) and distributed across multiple DataNodes.

To ensure fault tolerance, each block is **replicated** on multiple machines — a setting known as the **replication factor**. In HDFS, the default replication factor is **3**, meaning each block has three copies stored on different nodes.

This architecture ensures that even if multiple nodes fail, data remains retrievable from surviving replicas — delivering strong **availability and reliability**.

### Strengths of Distributed File Systems

Distributed file systems enable modern infrastructure to operate with enormous scale and resiliency:

**Horizontal Scalability:** Add more machines to increase storage capacity and parallel throughput without re-architecting the system  
**Automatic Rebalancing:** Data is redistributed automatically when nodes join or leave the cluster  
**Fault Tolerance:** Failures are handled gracefully; systems continue running without downtime  
**Optimized for Big Data:** Supports parallel analytics workloads such as MapReduce, Spark jobs, and data streaming pipelines

DFS empowers organizations to manage **ever-growing datasets**, enabling efficient computation and uninterrupted service — even in failure-prone environments.

## Big Data Fundamentals

In today’s world, data powers everything from Netflix recommendations and autonomous driving to fraud detection, cybersecurity, and smart traffic systems. The volume, speed, and complexity of information generated every second have grown far beyond what traditional systems can handle. This chapter introduces the concept of **Big Data** — what makes data “big,” the challenges it creates, and how modern distributed architectures store and process data at scale. While this is not a deep dive into all technologies, it lays the foundation for understanding the infrastructure and processing models necessary to build scalable, data-driven systems.

### What is Big Data?

Big Data refers to datasets that are **too large, too fast, or too complex** for traditional processing tools such as relational databases or single-machine systems. The rise of the internet, smartphones, IoT sensors, social platforms, and connected devices has resulted in unprecedented data growth. For example, consider how much data a smartwatch generates every hour—heart rates, movement metrics, GPS tracking, and notifications. Traditional on-prem systems cannot support this scale or speed. This shift has driven the adoption of **distributed systems, big data frameworks**, and **cloud-native architectures** designed to store and process data efficiently across many machines.

### The Six V’s of Big Data

To truly understand Big Data, we evaluate it through six defining characteristics, known as the **Six V’s**:

**Volume — Massive Data Size**

Data is now produced in **terabytes to exabytes**, driven by social media, IoT devices, financial systems, and digital platforms. Single machines simply cannot store or compute such enormous scale.

**Velocity — High-Speed Data Flow**

Data arrives rapidly and continuously—clickstreams, stock market feeds, telemetry from sensors. Systems must be able to **ingest and act in real time**, without delays.

**Variety — Diverse Data Formats**

Big Data comes in multiple forms:

- **Structured**: tables in relational databases
- **Semi-structured**: JSON, logs, XML
- **Unstructured**: images, audio, videos, emails

Each category requires different storage, modeling, and processing strategies.

**Veracity — Data Quality Challenges**

Real-world data is often **incomplete, inconsistent, or noisy**. If quality is not managed properly, insights become misleading — resulting in costly business decisions.

**Value — Meaningful Insights**

Data has no purpose unless it **drives decisions, improves systems, or delivers measurable business outcomes**. Extracting value is the ultimate goal of Big Data engineering.

**Variability — Changing Meaning and Context**

Data behavior is not always consistent. A simple term like “cold” may refer to temperature, an infection, or a product status depending on context. Systems must adapt to **changing patterns**, especially in analytical and AI workloads.

Understanding these Six V’s is essential for designing scalable systems and demonstrating clarity in Big Data discussions during technical interviews.

### Why Traditional Storage Systems Fail

Traditional relational databases and file servers were engineered for **vertical scaling** — adding more CPU, memory, or disk to a single machine. However, Big Data requirements break these limitations:

| **Limitation** | **Problem Created** |
| --- | --- |
| **Scalability** | Cannot support petabytes of data; vertical scaling hits expensive hardware limits |
| **Performance** | Poor parallel access; slow high-volume reads and writes |
| **Cost** | Upgrading enterprise hardware becomes financially prohibitive |
| **Fault Tolerance** | Data easily lost if the server crashes; backups require heavy manual effort |

These systems simply cannot cope with modern demands for **high throughput, global access, and intelligent analytics**. Big Data requires platforms built for **horizontal scaling, distribution, and automated recovery** — such as Distributed File Systems.

### Common Big Data Workloads

Modern applications generate diverse data workloads, each requiring specialized infrastructure:

- **Logs and Monitoring Events**  
    Server metrics, application events, and security logs used for debugging and alerting
- **Clickstream Data**  
    Tracks how users navigate through websites and apps, essential for product analytics
- **IoT Sensor Streams**  
    Data from smart appliances, industrial machines, healthcare devices—constant and real time
- **Machine Learning Pipelines**  
    Feature extraction, training datasets, data versioning — often requiring **petabyte-scale** access

These workloads share common traits: massive scale, continuous generation, and a strong need for distributed, fault-tolerant storage and processing.

## Data Processing Paradigms: Batch vs Stream

Storing data alone is not enough — insights come from analyzing it. Big Data processing follows two primary models:

### Batch Processing

Processes data in **large collected chunks** at scheduled intervals.  
Suitable for high-throughput workloads such as:

- Daily business reports
- Historical analytics
- ETL pipelines (Extract–Transform–Load)

Latency is high, but performance is optimized for huge datasets.

### Stream Processing

Processes data **as it arrives**, reacting in near real time.  
Ideal for low-latency scenarios like:

- Fraud detection
- Live analytics and dashboards
- Online recommendation systems

Tools such as Kafka, Spark Streaming, and Flink implement this continuous processing approach.

Most enterprise systems use a **hybrid** model — streams for instant decisions and batch systems for deeper historical insights. Choosing the right approach depends on **latency requirements vs throughput efficiency**.

# Chapter 8 — Messaging, Event-Driven Architecture & Event Sourcing

This chapter explored how modern distributed systems communicate and remain resilient under high load using asynchronous messaging patterns. It explained why message queues and event streaming systems are essential in decoupled architectures—allowing services to work independently without waiting for each other. By processing tasks asynchronously, organizations improve scalability, reliability, and fault tolerance.

We introduced the fundamentals of **Event-Driven Architecture (EDA)**, where events act as the primary communication mechanism among services. The chapter covered key components such as event producers, consumers, brokers, and event logs. We examined how EDA enables real-time workflows, supports microservices, and improves system responsiveness while maintaining loose coupling.

Another major topic was **Event Sourcing**, an advanced persistence pattern where state is derived from a sequence of historical events rather than storing only the latest snapshot. Event sourcing provides full audit traceability, recovery from event history, temporal queries, and improved system consistency in distributed environments.

## Event-Driven Systems Overview

Event-Driven Systems are an architectural style where communication and processing are triggered by **events** — significant changes or actions that occur within a system. Instead of services directly calling each other synchronously, systems publish events that other services can react to independently. This results in **loosely coupled, scalable, and highly responsive applications**.

An **event** can be anything meaningful in a business workflow:

- A new user registers
- A payment is processed
- Inventory is updated
- A sensor sends a temperature reading

These events are published to a **message broker/event streaming platform** and consumed by services that care about them. The producer does not need to know who consumes the event, how many consumers exist, or whether they are online — making the system **flexible and decoupled**.

### How Event-Driven Systems Work

Event-Driven Architecture (EDA) typically consists of three components:

1️⃣ **Event Producers**  
Services that generate events when something meaningful occurs  
(e.g., Order Service emits OrderPlaced event)

2️⃣ **Event Broker / Event Stream**  
A mediator that routes, stores, or streams events  
(e.g., Kafka, RabbitMQ, AWS SNS/SQS, Azure Service Bus)

3️⃣ **Event Consumers**  
Services that listen and react to events asynchronously  
(e.g., Payment Service triggers billing after OrderPlaced)

### Benefits of Event-Driven Architecture

| **Benefit** | **Description** |
| --- | --- |
| **Loose Coupling** | Services are independent — changes in one do not force change in others |
| **Scalability** | Consumers process events at their own pace; parallel processing is easy |
| **Resilience** | If a consumer fails temporarily, events wait in the queue/stream |
| **Real-time Processing** | Enables immediate reactions to user actions or sensor data |
| **Extensibility** | New features can subscribe to existing events without modifying producers |

### Trade-Offs & Considerations

| **Challenge** | **Explanation** |
| --- | --- |
| **Event Ordering** | Ensuring events occur in sequence when processing across distributed components |
| **Eventual Consistency** | Data may not be instantly synchronized across all services |
| **Debugging Complexity** | More services and async workflows mean harder traceability |
| **Delivery Semantics** | Exact-once delivery is hard; systems usually rely on idempotency |

To manage these challenges, observability tools, correlation IDs, retry logic, and proper schema governance are essential.

### Event-Driven Systems in the Real World

This architecture powers many high-scale distributed platforms:

- **E-commerce** workflows (order → inventory → shipping → notifications)
- **Banking** transactions and ledger updates
- **IoT** and sensor-driven analytics
- **Streaming platforms** (video/watch events → recommendations → analytics)
- **Ride-sharing apps** (booking, driver tracking, fare estimation)

## Messaging Patterns (Queue vs Pub/Sub)

Messaging lies at the heart of event-driven systems. It allows distributed components to communicate **asynchronously** without direct dependency on each other. Two widely used messaging patterns are:

1️⃣ **Message Queues (Point-to-Point Communication)**  
2️⃣ **Publish–Subscribe (Pub/Sub) Event Distribution**

Each pattern serves different workflow requirements and solves different architectural challenges.

### Message Queue Pattern (Point-to-Point)

A **Message Queue** ensures that each message is delivered to **exactly one** consumer.  
The queue acts as a buffer — storing tasks until consumers process them.

Example workflow:  
User uploads a video → “ProcessVideo” task added to queue → Worker consumes and processes the video

**Characteristics:**

| **Property** | **Description** |
| --- | --- |
| Delivery | One message to one consumer (competing consumers) |
| Ordering | Usually FIFO (first-in-first-out), but depends on implementation |
| Backpressure | Queue absorbs load spikes when consumers are slow |
| State | Message removed once processed (acknowledged) |

**Best For:**

- Background job processing (e.g., image/video processing)
- Task distribution among worker pools
- Payment processing workflows
- Rate-limited or CPU-intensive operations

Technologies: **RabbitMQ**, AWS **SQS**, Azure Service Bus Queues, ActiveMQ

### Publish–Subscribe Pattern (Pub/Sub)

In **Pub/Sub**, a producer publishes an event once, and **multiple subscribers** can receive and react to it independently.

Example workflow:  
OrderPlaced event:

- Payment Service → initiates transaction
- Inventory Service → reduces stock
- Notification Service → sends confirmation email

**Characteristics:**

| **Property** | **Description** |
| --- | --- |
| Delivery | One message → broadcast to many subscribers |
| Consumers | Each consumer receives its own copy of the event |
| Independence | Subscribers can be added or removed anytime |
| Event Retention | Some brokers store events for replay later (streams) |

**Best For:**

- Real-time event propagation
- Microservices communication
- Analytics, monitoring, notifications
- IoT sensor data pipelines

Technologies: **Kafka**, AWS SNS, Google Pub/Sub, Azure Event Grid, Redis Streams

### Key Differences — Queue vs Pub/Sub

| **Feature** | **Message Queue** | **Pub/Sub** |
| --- | --- | --- |
| Consumer Model | Only one consumer per message | Multiple consumers receive each event |
| Use Case | Task execution | Event broadcasting |
| Coupling | Slightly more coupling due to expected processing | Loose coupling, subscribers unknown to producer |
| State Storage | Typically transient | Can store event history (especially event streams) |
| Processing Model | Pull-based by workers | Push or pull depending on broker |

### Choosing the Right Pattern

| **Requirement** | **Recommended Pattern** |
| --- | --- |
| Work must be done once only (e.g., email send) | Queue |
| Multiple services need same info (e.g., analytics + notifications) | Pub/Sub |
| Event playback or state reconstruction needed | Pub/Sub Event Streams |
| Load leveling & retry needed | Queue |

Often, systems **combine both patterns**:  
A Pub/Sub event triggers multiple workers that then process tasks via queues.  
Example: E-commerce order events → payment workers + shipping workers.

## Message Brokers — Kafka vs RabbitMQ vs Cloud Brokers

Message brokers act as intermediaries that route, store, and distribute messages between producers and consumers. They ensure reliable asynchronous communication, enabling distributed systems to scale effectively while remaining loosely coupled.

Different brokers solve different problems. In this section, we compare three major categories:

1️⃣ **Apache Kafka**  
2️⃣ **RabbitMQ**  
3️⃣ **Cloud-Native Brokers** (AWS SQS/SNS, Azure Service Bus, Google Pub/Sub)

### Apache Kafka — High-Throughput Event Streaming

Kafka is a **distributed event streaming platform** optimized for high-volume, high-velocity data streams.

**Key Features:**

- Event log storage (durable, persistent)
- Horizontal scalability with partitions
- High throughput — millions of messages per second
- Event replay capabilities
- Strong ordering within partitions

**Best Use Cases:**

- Real-time streaming (analytics, telemetry, fraud detection)
- Event sourcing and state reconstruction
- Data pipelines & log aggregation
- Large-scale microservices architectures

**Strengths:**

✔ Excellent for Pub/Sub streaming  
✔ Retains events for hours/days/months  
✔ Can act as a system’s **source of truth** event log

**Trade-offs:**

❌ Not ideal for simple task queues  
❌ Harder operational complexity  
❌ Exactly-once semantics possible but requires careful configuration

### RabbitMQ — Mature Message Queueing (AMQP)

RabbitMQ is a traditional **message queue broker** built on AMQP (Advanced Message Queuing Protocol).  
Focus: Reliability and flexible routing.

**Key Features:**

- Queue-based work distribution
- Ack, retry, dead-letter queue management
- Routing via exchanges (fanout, topic, direct)
- Supports request-response and transactional messaging

**Best Use Cases:**

- Task execution and job scheduling
- Email, billing, transactional workflows
- Systems requiring guaranteed “only-once” processing (idempotent logic required)

**Strengths:**

✔ Excellent queueing semantics  
✔ Easier to manage operationally  
✔ Very mature and widely adopted

**Trade-offs:**

❌ Limited throughput vs. Kafka  
❌ Not designed for long-term event storage  
❌ Replay not supported without additional overhead

### Cloud-Native Brokers (Managed Services)

Includes services like:

- **AWS SQS** (Queue), **AWS SNS** (Pub/Sub)
- **Azure Service Bus**
- **Google Pub/Sub**

These provide **fully managed infrastructure** — no need to operate clusters.

**Key Features:**

| **Service Type** | **Main Purpose** |
| --- | --- |
| SQS / Azure Queues | Point-to-point queues for background task processing |
| SNS / Event Grid / Pub/Sub | Broadcasting events to multiple receivers |
| Azure Service Bus | Hybrid Pub/Sub and Queue with advanced routing |

**Best Use Cases:**

- Event-driven serverless architectures (e.g., Lambda, Azure Functions)
- Backend queues without infrastructure overhead
- IoT, logs, notifications, workflow automation

**Strengths:**

✔ Zero maintenance and auto-scale  
✔ Tight integration with cloud ecosystems  
✔ Pay-as-you-go pricing model

**Trade-offs:**

❌ Vendor lock-in  
❌ Less control over internals and performance guarantees  
❌ Latency variability based on cloud region/service

## Delivery Guarantees

In distributed messaging systems, messages can be lost, delayed, duplicated, or processed out of order. To handle these real-world challenges, message brokers implement different **delivery guarantees**, which define how a message is delivered from a producer to a consumer. Choosing the right guarantee is a key architectural decision and directly affects system correctness, performance, and cost.

There are three primary delivery semantics:

### At-Least-Once Delivery

Messages are guaranteed to be delivered **one or more times**.

How it works:

- The broker stores the message until the consumer **acknowledges** successful processing
- If the ack is not received (due to crash, timeout, or network issues), the message is resent

✔ Guarantees no message loss  
✘ May result in **duplicate messages**, requiring idempotent processing

**Suitable for:**

- Payment status updates
- Notification systems
- Mission-critical workflows with retries

**Common with:** Kafka, RabbitMQ, Cloud Brokers

### At-Most-Once Delivery

Messages are delivered **zero or one time** — no retries.

How it works:

- Broker sends the message **without waiting** for acknowledgment
- If failure occurs during processing → message is lost

✔ Fastest delivery and lowest overhead  
✘ Risk of message loss (no durability guarantee)

**Suitable for:**

- Low-value telemetry
- Real-time analytics logs
- UI events where precision is not critical

**Common with:** UDP-based messaging, certain Kafka consumer configs

### Exactly-Once Delivery

Messages are delivered **once and only once**, without duplication.

The ideal semantics — but expensive and hard to achieve.

Challenges:

- Broker may send duplicates
- Consumers may crash after processing but before acknowledgment

Solution:

- Use **idempotency** + **transactional messaging** + **state management**

✔ Strong correctness guarantees  
✘ Higher complexity and performance trade-offs

**Common with:**

- Financial transactions
- Inventory updates
- Billing systems

**Kafka’s transactional API** and **cloud managed services** can support exactly-once semantics if designed correctly.

**Summary Comparison**

| **Delivery Model** | **Duplicates Possible** | **Message Loss** | **Performance** | **Best For** |
| --- | --- | --- | --- | --- |
| At-Least-Once | Yes | No  | Moderate | Reliable systems with retries |
| At-Most-Once | No  | Yes | High | Low-risk, real-time streams |
| Exactly-Once | No  | No  | Lower | Critical workflows w/ strong consistency |

## Dead Letter Queues (DLQ), Retry & Backoff

Even with retries, some messages **continuously fail** due to:

- Data corruption
- Upstream bugs
- Invalid business rules
- Schema mismatches

To prevent blocking the queue, these messages are redirected to a **Dead Letter Queue (DLQ)**.

### Dead Letter Queue (DLQ)

A secondary queue used to store permanently or repeatedly failing messages.

Purpose:

- Prevent stuck queues
- Enable debugging and manual recovery
- Maintain overall system health

Example:

- Invalid email address repeatedly causing failure → moved to DLQ for later inspection

**Metadata often stored in DLQ:**

- Error reason
- Retry attempt count
- Event timestamp
- Payload for replay or fix

### Retry & Backoff Mechanisms

Retries ensure temporary failures do not cause permanent message loss.

There are two primary retry patterns:

**Immediate Retries**

- Re-deliver the message quickly until success or retry limit reached
- Risk: **retry storm** under large outages

**Exponential Backoff Retries**

- Increases delay between retries: 1s → 2s → 4s → 8s ...
- Helps avoid network or service overload during failures

**Jitter** is often added to avoid synchronized retry spikes.

### Recommended Best Practices

| **Aspect** | **Best Practice** |
| --- | --- |
| Retry Count | Limit retries to avoid infinite loops |
| Backoff | Use exponential backoff + jitter |
| DLQ Processing | Automate monitoring and alerting |
| Observability | Store failure metadata for analysis |
| Idempotency | Ensure safe reprocessing when retries occur |

## Event-Driven Architecture Models

Event-driven architecture (EDA) allows services to operate independently by reacting to events instead of relying on direct synchronous calls. In EDA, services **emit**, **consume**, or **react** to events as the primary way to exchange information.

Two main coordination models exist:

### Choreography vs Orchestration

These patterns define **how multiple services participate** in a distributed business workflow.

#### Choreography — Decentralized Control

Each service listens for events and triggers the next event in the workflow.  
There is **no central coordinator** controlling the sequence.

Example Flow:

1.  Order Service emits **OrderPlaced**
2.  Payment Service processes → emits **PaymentCompleted**
3.  Inventory Service processes → emits **StockAdjusted**
4.  Notification Service processes → sends email

**Characteristics**

| **Strengths** | **Weaknesses** |
| --- | --- |
| No single point of failure/coordination | Harder to maintain global visibility |
| High flexibility and autonomy | Debugging and observability are complex |
| Easy to evolve and scale | Risk of cyclic dependencies |
| Loose coupling promotes microservices independence | Workflow becomes implicit, not documented centrally |

**Best For:**

- Highly distributed microservices
- Workflows likely to evolve frequently
- Systems requiring maximum independence between teams

### Orchestration — Centralized Control

A dedicated **orchestrator service** defines and controls the workflow.  
Each service receives explicit commands from the orchestrator.

Example Flow:

Orchestrator → Payment → Inventory → Shipping → Notification

**Characteristics**

| **Strengths** | **Weaknesses** |
| --- | --- |
| Clear workflow visibility | Orchestrator becomes a dependency |
| Easier to manage complex transitions | Can act as a bottleneck |
| Centralized error handling and retries | Less autonomy for services |
| Better monitoring & debugging | More upfront design work |

**Best For:**

- Complex long-running workflows
- Business processes requiring auditability
- Saga orchestration (e.g., distributed transactions)

#### Which one to choose?

| **Requirement** | **Best Model** |
| --- | --- |
| Maximum autonomy & loose coupling | Choreography |
| Central oversight & state tracking | Orchestration |
| Rapid iteration & evolutionary workflows | Choreography |
| Critical business workflows & compliance | Orchestration |

Most real-world architectures **use a hybrid approach** — choreographed microservices for flexibility, orchestrated sagas for transaction coordination.

## Event-Carried State vs Event Notification

These patterns define **what information** is transmitted in an event.

### Event Notification — “Something happened”

Events only signal that a change occurred.  
Consumers must **query the source** to get full context.

Example:

OrderCreated { orderId: 101 }

Pros:  
✔ Lightweight  
✔ Small payloads  
✔ Low network costs

Cons:  
✘ Coupling increases—consumer must make synchronous calls  
✘ More latency and load on source services

Used when:

- Data changes are large
- Consumers don’t always need full details

### Event-Carried State — “Something happened + full data”

Event includes the **complete state required** by consumers.

Example:

OrderCreated {

orderId: 101,

items: \[...\],

customer: {...},

amount: 250

}

Pros:  
✔ Consumers act without calling source system  
✔ Enables **local state storage**, improves latency  
✔ Better isolation in distributed environments

Cons:  
✘ More storage + network usage  
✘ Risk of stale/duplicated state → requires versioning

Used when:

- Systems operate autonomously
- Eventual consistency is acceptable
- Real-time performance matters

## Stream Processing (Kafka Streams, Flink, Kinesis)

Modern applications increasingly deal with **continuous flows of data** — user interactions, IoT device signals, transaction logs, and real-time analytics. Stream processing frameworks enable systems to **ingest, process, and analyze events in real time**, instead of waiting for batch jobs to run.

**What is Stream Processing?**

Stream processing allows processing data **as it arrives** with **low latency**, supporting real-time transformations like:

- Filtering (e.g., ignore invalid sensor data)
- Aggregation (e.g., total sales in last 5 minutes)
- Enrichment (e.g., merge event stream with user profile data)
- Complex event processing (e.g., fraud detection on transaction patterns)

It is widely used in high-throughput systems like financial trading, recommendation engines, cybersecurity analytics, and logistics tracking.

### Types of Stream Processing

| **Type** | **Description** | **Use Case Example** |
| --- | --- | --- |
| **Stateless** | Processes events independently | Simple filtering |
| **Stateful** | Maintains context across events | Windowing, joins, aggregations |
| **Windowed Processing** | Adds time boundaries | Count events in last 30 seconds |

Stateful processing often requires **fault-tolerant state storage** integrated into the framework.

### Popular Stream Processing Technologies

Below is a comparison of the most widely used stream processing tools:

**1️⃣ Kafka Streams**

A lightweight library built into **Apache Kafka** for processing Kafka topics directly.

**Key Characteristics:**

- Runs within your Java application — **no separate cluster required**
- Strong **stateful** support with RocksDB
- Distributed scaling through Kafka partitions
- **Exactly-once** processing support with Kafka

**Best Fit:**  
Microservices doing local real-time transformations on Kafka data.

**2️⃣ Apache Flink**

A high-performance **stream-first** distributed processing engine.

**Key Characteristics:**

- Designed for **unbounded streams**
- Extremely low-latency processing
- Flexible windowing and complex event processing
- Fault tolerance with **checkpointing**
- Supports both stream + batch workloads

**Best Fit:**  
Large-scale analytics systems, IoT, fraud detection, machine learning inference pipelines.

**3️⃣ AWS Kinesis (Managed Cloud Stream Processing)**

A fully managed service for real-time ingestion and analysis on AWS.

**Family of Services:**

- **Kinesis Data Streams** → Event ingestion (like Kafka)
- **Kinesis Data Analytics** → SQL/Apache Flink apps for processing
- **Kinesis Firehose** → Streaming ETL into S3, Redshift, OpenSearch

**Key Characteristics:**

- No infrastructure management
- Auto-scaling capabilities
- Deep AWS ecosystem integration

**Best Fit:**  
Cloud-native streaming applications without operational overhead.

## Event Sourcing & CQRS

Modern distributed applications often require detailed audit trails, flexible evolution of business rules, and the ability to reconstruct system state at any time. **Event Sourcing** and **CQRS (Command Query Responsibility Segregation)** are architectural patterns that address these needs by treating system events as the primary source of truth.

### Event Sourcing: Events as the Source of Truth

In Event Sourcing, instead of persisting the current state of a business entity, the system stores **all state-changing events** that have occurred:

Example: For a bank account  
Rather than only storing the final balance, the system records →  
AccountCreated, MoneyDeposited, MoneyWithdrawn, etc.

To obtain current state, events are **replayed** in strict order to reconstruct the entity.

**Key Benefits:**

- **Perfect auditability** — full history of everything that happened
- **Event replay** enables fixing state corruption or rebuilding models
- **Easy integration** — new consumers can subscribe to past events
- **Append-only log** improves integrity and reduces write contention

**Challenges:**

- State reconstruction overhead without optimizations
- Evolving event schemas over time requires strict versioning
- Developers must handle eventual consistency

### CQRS (Command Query Responsibility Segregation)

CQRS complements Event Sourcing by **splitting the write and read models**:

| **Operation** | **Model Type** | **Characteristics** |
| --- | --- | --- |
| **Commands (Writes)** | Domain entity + Event Store | Validates business rules and emits events |
| **Queries (Reads)** | Materialized Views | Optimized for fast querying |

Reads and writes scale independently and can use different databases.

**Example:**

- Commands store events in an Event Store (Kafka/EventStoreDB)
- Queries build read models in SQL/NoSQL optimized for reports and UI

Together, Event Sourcing + CQRS creates **high-performing and scalable** systems where historical integrity is never lost.

### Key Concepts in Event Sourcing

**1️⃣ Snapshots**

Replaying thousands or millions of events can slow reconstruction.  
A **snapshot** captures the state of an entity at a point in time:

Snapshot + Events (after snapshot) = Current State

**When used:**

- Large aggregates, highly active entities
- Performance optimization

Snapshots are often stored in a separate “snapshot store” for fast access.

**2️⃣ Replay**

Replay is the process of rebuilding state by processing historical events:

- Useful for bug fixes, regenerating read models, migrating systems, analytics
- Events are immutable → replay never changes history

Event replay enables time-travel debugging — a capability unavailable in traditional CRUD systems.

**3️⃣ Log Compaction**

Over time, event streams grow large. Compaction reduces size by:

- Removing obsolete or superseded events
- Keeping only the **latest useful state** or **compressed versions**

Different strategies:

| **Strategy** | **Purpose** |
| --- | --- |
| **Soft Compaction** | Group events into a single event (e.g., balance-adjusted) |
| **Kafka Log Compaction** | Retains latest event for each key |
| **Archival** | Moves older events to cold storage |

Compaction must **never break history** if events are part of business audits.

### Where Event Sourcing & CQRS Shine

| **Domain** | **Reason** |
| --- | --- |
| Banking, FinTech | Full transaction traceability is critical |
| E-commerce | Order lifecycle is easily tracked via events |
| Healthcare | Immutable logs essential for compliance |
| IoT & Monitoring | Massive real-time event streams |

Systems requiring heavy analysis, replay, version migration, and audit compliance benefit the most.

## Outbox Pattern + Change Data Capture (CDC)

In distributed systems, one of the biggest challenges is ensuring that **database operations and message publishing remain consistent**. If a service updates its local database but fails to publish an event to a message broker (or vice-versa), other services may operate with incorrect or stale information — leading to data integrity issues.

To solve this, two important reliability techniques are used:

- **Outbox Pattern**
- **Change Data Capture (CDC)**

Both ensure that **state changes in a database are correctly propagated as events** to downstream consumers.

### Outbox Pattern

The **Outbox Pattern** ensures atomicity between writing to the database and generating an event.  
When a business transaction occurs:

1.  The application writes the local state change to its main table
2.  Simultaneously stores the event into a dedicated **Outbox table** within the same transaction
3.  A background process reads the Outbox table and publishes events to the message broker
4.  After successful publishing, the event record is marked dispatched or deleted

**Because both DB state and event recording happen in a single transaction, they cannot become inconsistent.**

**Benefits:**

- **No lost events** — DB and messages stay in sync
- No distributed transactions needed (avoids 2PC overhead)
- Guaranteed delivery with retries
- Works well in microservices where each service owns its DB

**Limitations:**

- Requires an additional background dispatcher component
- Outbox table may grow large without cleanup/archival
- Event duplication must be handled with **idempotency**

### Change Data Capture (CDC)

**CDC** is a mechanism to detect and stream database changes (inserts/updates/deletes) in real time.  
Instead of a service generating events manually, CDC **listens to changes** at database storage level — often using transaction logs.

Popular CDC tools:

- **Debezium** (widely used with Kafka)
- AWS DMS (cloud-native)
- SQL Server Change Tracking
- Oracle GoldenGate
- MongoDB Change Streams

CDC is "non-intrusive" — it works _without modifying application code_ and is great for legacy modernization.

**Benefits:**

- Ideal for **event-enabling** older monolith databases
- Automatically captures every change
- High throughput and low latency
- Excellent for streaming analytics, ETL, materialized views

**Limitations:**

- Must manage **schema evolution** carefully
- Not all changes may represent meaningful business events
- Increased operational complexity

### Outbox Pattern vs CDC

| **Feature** | **Outbox Pattern** | **CDC** |
| --- | --- | --- |
| Change source | Application code writes event | DB transaction logs |
| Event granularity | Business events | Low-level DB operations |
| Legacy compatibility | Requires code changes | Works without code changes |
| Complexity | Moderate | Higher (DB log reading, connectors) |
| Ideal use cases | Microservices, message-driven workflows | Data sync, analytics, legacy modernization |

### Real-World Use Cases

| **Industry** | **Problem Solved** |
| --- | --- |
| E-commerce | Order, payment, and inventory synchronization |
| Banking | Exactly-once transaction events |
| Supply Chain | Real-time shipment status propagation |
| Streaming Data | Analytics pipelines synced with source-of-truth DB |

tell me and I’ll generate clear visuals to include in your chapter!

## Messaging Protocols (AMQP, MQTT, CloudEvents)

Messaging in distributed systems isn’t just about brokers and message delivery semantics—**protocols** define _how_ messages are formatted, transmitted, and interpreted across diverse systems. Standard messaging protocols ensure **interoperability**, **security**, and **reliability** across networks, devices, and cloud environments.

This section covers three widely adopted protocols:

- **AMQP** — for reliable enterprise messaging
- **MQTT** — for lightweight IoT device communication
- **CloudEvents** — for standardized event structure in cloud ecosystems

### AMQP (Advanced Message Queuing Protocol)

AMQP is a feature-rich, binary-level messaging protocol designed for **enterprise-grade messaging systems**.

**Key Features**

- Reliable delivery (supports at-least-once, acknowledgments)
- Message routing with exchanges (direct, topic, fanout)
- Security (TLS, SASL authentication)
- Queue-based messaging (Broker-centric)

**Common Use Cases**

| **Domain** | **Why AMQP?** |
| --- | --- |
| Banking, Finance | Strong consistency guarantees |
| Enterprise Microservices | Mature broker ecosystem |
| Transaction workflows | Confirmations and routing flexibility |

**Popular Implementations**

- **RabbitMQ**
- Azure Service Bus
- Apache Qpid

📌 AMQP focuses on **ensuring messages are delivered reliably even under failures**.

### MQTT (Message Queuing Telemetry Transport)

MQTT is an extremely lightweight publish/subscribe messaging protocol optimized for **IoT and low-bandwidth environments**.

**Key Features**

- Works with unreliable and constrained networks (2G, narrowband)
- Tiny message footprint (~2 bytes overhead)
- Supports QoS levels:
    - **QoS 0** — At-most-once
    - **QoS 1** — At-least-once
    - **QoS 2** — Exactly-once (higher overhead)
- Persistent sessions for intermittent connectivity

**Use Cases**

| **Domain** | **Example** |
| --- | --- |
| IoT Sensors | Temperature, location tracking |
| Automotive | Connected vehicles |
| Smart Home | Device telemetry & automation |

**Popular Brokers**

- Mosquitto
- HiveMQ
- AWS IoT Core

MQTT trades extensive features for **simple, efficient message delivery** in large device networks.

### CloudEvents

CloudEvents is a **vendor-neutral specification** designed to standardize **event representation** across cloud services and event brokers.

Instead of defining transport, CloudEvents standardizes **event metadata**, so systems can understand the:

- Event source
- Event type
- Timestamp
- Trace context
- Schema reference

Example metadata fields:

| **Field** | **Purpose** |
| --- | --- |
| id  | Globally unique event identifier |
| source | Where the event originated |
| type | What happened (event category) |
| specversion | CloudEvents version |
| data | Event payload |

**Transport Bindings (Supported Formats)**

- HTTP
- Kafka
- AMQP
- NATS
- gRPC

**Use Cases**

- SaaS integrations
- Multi-cloud event routing
- Standardizing internal microservice communication

CloudEvents simplifies **cross-platform event interoperability** — especially in cloud-native architectures.

### When to Use What?

| **Situation** | **Best Choice** |
| --- | --- |
| Mission-critical enterprise workflows | **AMQP** |
| Battery-powered sensors & unreliable networks | **MQTT** |
| Cloud services integration & portability | **CloudEvents** |

# Chapter 9 — System Performance Engineering

In modern software systems, delivering functionality is not enough — the system must perform well under real-world conditions. System performance is at the very heart of user experience, product reliability, and business success. In this chapter, we explore performance from a holistic perspective: how systems respond, how they scale, and how they maintain efficiency even during intense demand. We will introduce foundational performance concepts such as latency, throughput, scalability, SLAs, SLOs, and percentiles, along with performance testing and monitoring practices that keep systems healthy in production.

## What is System Performance?

System performance refers to how effectively a software system fulfills its functional responsibilities under varying load conditions. It is not merely a measure of speed — instead, it represents a balanced outcome across multiple dimensions:

• **Speed** — how fast a response reaches the user  
• **Capacity** — how much work the system can handle simultaneously  
• **Efficiency** — how optimally resources such as CPU, memory, and network are utilized

The true measure of performance lies in the ability to sustain responsiveness while scaling seamlessly as users and data grow.

## Latency vs Throughput — The Core Performance Metrics

Latency and throughput are two metrics that measure the performance of a computer network. Latency is the delay in network communication. It shows the time that data takes to transfer across the network. Networks with a longer delay or lag have high latency, while those with fast response times have lower latency. In contrast, throughput refers to the average volume of data that can actually pass through the network over a specific time. It indicates the number of data packets that arrive at their destinations successfully and the data packet loss. In other words, how much data a server can process within a given time frame. If server is able to process more data in than server has heigh throughput else low throughput.

### Bandwidth

Bandwidth refers to the amount of data that can be transmitted and received during a specific period of time.

### Bandwidth vs Throughput

While throughput and bandwidth may seem similar, there are some notable differences between them. If bandwidth is the pipe, then throughput is the water running through the pipe. The bigger the pipe, the higher the bandwidth, which means a greater amount of water can move through at any given time.

In a network, bandwidth availability determines the number of data packets that can be transmitted and received during a specific time period, while throughput informs you of the number of packets actually sent and received.

## Scalability vs Responsiveness — Understanding the Difference

Although related, scalability and responsiveness address different performance perspectives:

**Scalability**

A scalable system continues to function efficiently as load increases. This may involve:

- **Horizontal Scaling** — adding more machines
- **Vertical Scaling** — upgrading existing hardware

**Responsiveness**

Responsiveness ensures each user receives timely results, even when many users interact simultaneously.

A system might scale to thousands of users but feel slow to every individual — a clear sign of poor responsiveness.

## SLAs, SLOs, and SLIs — How Performance is Measured and Promised

Modern services operate based on formal performance expectations:

| **Term** | **Definition** | **Scope** |
| --- | --- | --- |
| **SLA** — Service Level Agreement | Contractual performance guarantees (e.g., uptime commitments) | External / Business |
| **SLO** — Service Level Objective | Internal operational target to achieve SLAs | Engineering |
| **SLI** — Service Level Indicator | The actual monitored performance measurement | Observability Systems |

Example:

- SLA: _99.9% monthly uptime_
- SLO: _95% of requests must complete in < 300ms_
- SLI: _Currently only 92% meet that target → degradation_

These measures help ensure reliability remains transparent and enforced.

### Percentiles — Why Averages Lie

Performance is rarely uniform across requests. Averages hide the most painful slow experiences. Instead, **percentile-based latency** reveals the distribution of delays:

| **Metric** | **Meaning** |
| --- | --- |
| **P50** | Median latency — half the requests are faster |
| **P95** | Worst 5% — good measure for typical high performance |
| **P99** | Tail latency — the slowest 1% that often hurt user experience |

The **tail** is where system failures, timeouts, and dissatisfaction originate.  
Real-time systems (e.g., finance, gaming) are often optimized specifically for P99 performance.

### Why Performance Matters — More Than a Technical Metric

Performance is a **business feature**:

• Faster systems retain more users  
• Each extra second delays checkout conversions and revenues  
• Poor latency creates memorable frustration — users rarely return

Optimizing performance leads to improved:

- Customer satisfaction
- Infrastructure cost efficiency
- Competitive positioning

Therefore, **performance must be a first-class design goal**, not an afterthought.

### Performance Testing — Preparing Systems for the Real World

Testing performance in controlled environments reveals architectural weaknesses early:

| **Type of Test** | **Purpose** |
| --- | --- |
| **Load Testing** | Validate performance under expected normal load |
| **Stress Testing** | Push beyond capacity to observe failure behavior |
| **Spike Testing** | Test sudden traffic surges and rapid recovery |
| **Endurance/Soak Testing** | Detect long-term degradation like memory leaks |

These tests uncover bottlenecks before users experience them.

### Performance Monitoring — Staying Reliable in Production

Unlike testing, monitoring continues after deployment. Visibility tools ensure system health is constantly measured and protected:

**Monitoring Focus Areas:**

- **Latency & Throughput**
- **Error Rates**
- **Resource Utilization** (CPU, memory, disk I/O)
- **Database & Network performance**

Popular monitoring solutions (conceptually explained):

- Application Performance Monitoring (APM) tools — end-to-end performance insights
- Centralized logs & metric dashboards — proactive issue detection

“You cannot improve what you do not measure.”

Monitoring builds **operational confidence** and prevents customer-facing failures.

## Caching in System Design

In modern distributed systems, performance is often the defining factor between a slow, frustrating user experience and a fast, delightful one. One of the most effective ways to boost performance is through **caching**. Caching significantly reduces latency, offloads heavy backend services, and enhances scalability by storing frequently accessed data in a fast-access storage layer. Whether it is search suggestions appearing instantly or product recommendations loading without delay, caching serves as the invisible engine powering responsive systems.

The primary benefit of caching lies in how quickly it returns data. Instead of repeatedly querying a slower data store such as a relational database, cached data can be retrieved directly from lightning-fast in-memory systems like **Redis** or **Memcached**. This rapid access is essential for real-time interaction and smooth user experiences. Additionally, caching reduces the workload on backend applications and databases, allowing them to handle more traffic with fewer resources. As systems scale and user demand surges, caching becomes a protective shield, preventing infrastructure from becoming overwhelmed. For this reason, caching is not a luxury—it is fundamental in high-throughput architectures.

### Type of Caching

Caching exists at multiple layers within a system, each designed to optimize performance at different points in the request flow. **Client-side caching**, for example, resides directly within a user’s browser through mechanisms like LocalStorage, IndexedDB, or Service Workers. This allows applications to operate with reduced network dependency, even enabling partial offline functionality. Moving inward, **server-side caching** stores frequently requested data close to the application layer, enabling quick access to session data or precomputed results. Additionally, **CDN caching** pushes static content such as images, CSS, and scripts to globally distributed servers, dramatically improving load speed regardless of user location. Finally, **database-level caching** stores results from frequently executed queries to avoid repeated expensive lookups or computations. Together, these layers form a performance pyramid that intercepts requests before reaching slower components.

### Caching Strategies

Effective caching depends heavily on selecting the correct strategy for reading and writing data. In the **write-through strategy**, write requests update both the database and the cache simultaneously. While this keeps the cache fresh and consistent, it adds latency to write operations. In contrast, **write-back (write-behind)** caching writes data only to the cache initially and later synchronizes with the database asynchronously. Although this improves write performance, it carries a risk of data loss if the cache fails before persistence. When it comes to reads, **lazy loading (cache-aside)** is commonly used: the application checks the cache first, and if data is missing, it retrieves it from the database and stores it in the cache for future access. There is also **manual or explicit caching**, where developers intentionally control what should be cached and when, offering flexibility at the cost of increased complexity.

### Cache Eviction Policies

Since memory is a limited resource, every cache requires a strategy to remove old or unused data. Various **cache eviction policies** are used to determine which items should be discarded when the cache reaches full capacity. The most common approach is **Least Recently Used (LRU)**, which assumes that recently accessed data is more likely to be useful again. **Least Frequently Used (LFU)** focuses on access frequency rather than recency, ideal for scenarios where some data is repeatedly accessed and should not be prematurely evicted. A simpler but less intelligent approach is **FIFO (First-In, First-Out)**, which removes items in the order they were inserted, regardless of their usefulness. Alongside these techniques, **Time-to-Live (TTL)** can be applied to automatically expire items after a specific duration—helping ensure freshness, especially for time-sensitive data such as session tokens or external API responses.

Among caching tools, **Redis** has emerged as a powerhouse solution. Redis is an in-memory key-value data store that provides exceptional read and write performance thanks to RAM-based storage. It supports advanced features such as TTL, Pub/Sub for real-time streaming, distributed locks, and optional disk persistence, enabling it to function not only as a cache but even as a primary database in certain architectures. Its reliability, high availability configuration options, and widespread adoption across cloud providers make it a top choice for performance-critical systems.

Caching is deeply ingrained in applications we use daily. Content Delivery Networks cache static assets, ensuring fast page rendering worldwide. Online shopping platforms store details of frequently viewed products to enable instant page loads. Authentication systems maintain user session data in memory for rapid verification. Search systems cache popular queries to reduce compute costs. In microservices architectures, caching API responses prevents unnecessary overload on downstream services. These real-world examples demonstrate how caching transforms slow, repetitive operations into fast and scalable experiences.

Ultimately, caching is one of the strongest performance enhancement tools in system design. Its role is not limited to optimization—it is foundational to building high-performance systems capable of scaling gracefully under heavy loads. By understanding the different caching layers, choosing the right read-write strategy, applying appropriate eviction policies, and leveraging tools like Redis, system designers ensure speed, resilience, and a superior user experience.

## Asynchronous Messaging and Message Queues in System Design

As modern systems grow to serve millions of users and perform increasingly complex tasks, building architectures that remain responsive, scalable, and fault-tolerant becomes essential. One of the most powerful techniques used in large-scale distributed systems is **asynchronous messaging**. Instead of services calling each other directly and waiting for responses, asynchronous communication allows a service to send a message to another service and immediately move on. This shift eliminates unnecessary waiting, improves throughput, and unlocks the ability to handle workloads that would otherwise overwhelm synchronous systems.

A major benefit of asynchronous messaging is the achievement of **loose coupling**. Services no longer need to know the identity or availability of other services. A producer simply sends a message to the system, and any consumer interested in that message can receive it whenever it is ready to process it. This decoupling not only boosts performance but also simplifies development, deployment, and scaling. Producers and consumers become independently manageable components that can be upgraded or scaled without affecting one another.

Scalability is another fundamental strength of message-driven design. If workload increases on a particular service — such as when high volumes of tasks arrive in a short time — additional consumers can be added to process messages faster. The queue absorbs sudden traffic spikes, enabling the system to maintain consistent performance even under unpredictable loads. Furthermore, queues enhance resilience because messages are durably stored by brokers. If a consumer temporarily fails, messages remain preserved in the system and can be processed later once consumers recover. This ensures fault tolerance and improves overall system stability. The architecture is also inherently flexible: new consumers can be introduced at any time without modifying existing producers, allowing systems to evolve rapidly as new business requirements emerge.

### Core Components of a Messaging System

Every messaging-based architecture is built on a few essential components. The **message** itself is simply a unit of data — often in formats like JSON, binary, or protocol-specific encoding — representing an event, task, or command that one service wants to share with another. The service that creates and sends a message is known as the **producer**, while the service that receives and acts on the message is called the **consumer**.

Between them lies the central piece of infrastructure: the **message broker**. Popular brokers such as **RabbitMQ** and **Apache Kafka** temporarily store messages and guarantee reliable delivery to consumers. Messages within the broker are organized into channels known as **queues** or **topics**, depending on the delivery model. Producers publish messages to specific topics, while consumers subscribe to the topics they care about. This publish–subscribe communication pattern allows multiple services to independently react to the same event. When a consumer successfully processes a message, it sends an **acknowledgment**, which signals to the broker that the message may be removed or marked as processed. If acknowledgments are not received, the broker can deliver the message again — a key factor in ensuring reliability.

### Real-World Example: Decoupled Microservice Communication

Consider an e-commerce platform with multiple microservices. When a user updates the price of a product, the action begins as a synchronous request handled by the **Catalog Service**, which updates its database. After a successful update, the Catalog Service publishes a **PriceUpdated event** to the message broker. At this point, rather than contacting other services directly, it simply moves on.

Other services — such as **Basket**, **Billing**, and **Analytics** — may subscribe to this event. The Basket Service, for example, updates stored prices in users’ shopping carts to ensure consistency. Meanwhile, Analytics may record pricing trends, and Billing may adjust financial rules if necessary. None of these services needs to know whether others exist or are currently online. If a subscriber is temporarily offline, the event remains buffered in the broker and is delivered later when the service becomes available again. This model exemplifies a fully **decoupled architecture**, which enhances fault tolerance and allows the platform to grow and evolve without introducing tightly bound dependencies.

### When Should We Use Message Queues?

Message queues are most valuable in situations where workloads are unpredictable or processing does not need to happen immediately. Workloads that exhibit sudden surges — such as flash sales, marketing campaigns, or seasonal spikes — are smoothed out because the queue acts as a buffer. They are a perfect solution for **background tasks** like sending emails, exporting data, generating reports, or video processing, where immediate completion is not necessary for the user experience.

Queues also provide protection against rate limits or resource-heavy operations. If a service interacts with external APIs that only allow a fixed number of requests per minute, the queue can pace message consumption accordingly. This prevents the system from overwhelming itself or downstream systems. In essence, whenever resilience, fault tolerance, and smooth scaling are priorities, queue-based design becomes a powerful architectural choice.

### RabbitMQ vs. Kafka: A High-Level Comparison

RabbitMQ and Kafka are two widely adopted message brokers, each suited for different use cases. **RabbitMQ** is built on the AMQP protocol and uses a **push-based** consumption model, delivering messages to consumers as they arrive. It supports complex routing, message retries, and acknowledgment handling, making it ideal for task distribution, notifications, and asynchronous workflows. However, once a message is consumed, it is typically removed from the queue.

**Kafka**, in contrast, is a **distributed event streaming platform** that follows a **pull-based** consumption model. Consumers decide when to read messages that are stored in a durable log. Kafka supports replaying messages and processing the same data stream multiple times, making it particularly effective for real-time analytics, stream processing, event sourcing, and high-throughput pipelines. It can retain data long after consumption, enabling historical analysis and fault recovery in ways traditional message brokers do not.

The general guideline is:

- Choose **RabbitMQ** for reliable task queues and flexible routing
- Choose **Kafka** for scalable event streaming and data-driven architectures

### Message Delivery Guarantees

Reliability in messaging systems is defined by delivery guarantees. The most common models are:

- **At least once** — Messages are retried until acknowledged. It protects against data loss but may result in duplicates. Consumers must be **idempotent**, meaning repeated processing should not cause incorrect results.
- **At most once** — Messages are delivered only once with no retries. It is faster but risks message loss if a failure occurs during delivery.
- **Exactly once** — The ideal state where each message is processed only once with no duplicates. However, this is difficult and resource-intensive to achieve. Kafka provides exactly-once behavior, but only under specific configurations.

Choosing the right strategy depends on business tolerance for **duplication versus loss**, as well as operational complexity requirements.

### Real-World Use Cases

Asynchronous messaging is found at the heart of many large-scale system workflows. **Order processing pipelines** benefit from decoupling user-facing interactions from downstream tasks like inventory checking, payment processing, and shipping. **Logging and monitoring** systems use messaging to aggregate data across distributed environments. **Rate limiting** ensures downstream services are protected from sudden bursts of traffic. **Notification services** handle emails, SMS alerts, and push messages without blocking users. And in **data engineering**, Kafka underpins real-time ETL and stream processing infrastructures that power modern analytics platforms.

### Best Practices for Messaging Systems

To build robust message-driven architectures, several best practices are essential. Consumers should always be **idempotent** to handle retries safely. **Dead-letter queues** allow problematic messages to be isolated rather than repeatedly blocking processing. Monitoring queue length and processing delays provides visibility into bottlenecks and helps identify when scaling is required. Failure handling mechanisms such as **exponential backoff** and **circuit breakers** prevent cascading outages. Security practices — including authentication, authorization, and payload encryption — must be in place to protect sensitive data moving between services. Finally, the chosen delivery model should reflect business requirements regarding reliability, consistency, and performance.

## Concurrency and Parallelism in System Design

In modern software architecture, systems must handle hundreds or even thousands of operations happening at the same time. This is a fundamental requirement for performance, scalability, and responsiveness. Whether we are designing a high-throughput web server, a background job processor, or a microservice handling simultaneous requests, we must understand how systems deal with multiple activities happening together. This brings us to two key concepts in system design: concurrency and parallelism.

### Concurrency

**Concurrency** refers to the ability of a system to manage multiple tasks in overlapping time periods, even if they are not executing simultaneously. It is mainly about how tasks are scheduled and organized. A single-core CPU can still provide concurrency by rapidly switching between tasks, giving the illusion that many operations are happening at once. The main goal of concurrency is responsiveness, allowing a system such as a web server using asynchronous I/O to handle many requests efficiently by switching between waiting tasks without blocking progress.

### Parallelism

**Parallelism**, in contrast, is about truly executing multiple tasks at the exact same time, which requires multiple CPU cores. The purpose of parallelism is to increase processing speed and throughput. For example, dividing a complex mathematical computation into smaller chunks and performing them simultaneously across multiple CPU cores dramatically improves performance. Where concurrency deals with managing tasks, parallelism deals with physically running them in parallel.

Understanding this difference helps engineers build systems that remain both fast and responsive under load. Concurrency improves capacity to handle many tasks, while parallelism improves the speed at which tasks complete.

To support these concepts, modern systems rely heavily on **processes and threads**. A process is an independent program with its own isolated memory space and resources. Because of their isolation, processes are safer — a failure in one does not affect others — but they are heavier to create and manage. In contrast, a thread is a lightweight unit of execution within a process that shares memory with other threads. Threads are faster and more efficient but bring the risk of race conditions when multiple threads attempt to modify shared data simultaneously without proper synchronization.

Efficient thread management is crucial in large-scale systems, which is why **thread pools** are extensively used. A thread pool maintains a set of reusable threads that execute tasks as they arrive. Instead of creating a new thread for every task — which is expensive — the system borrows a thread from the pool and returns it once the task finishes. This greatly improves scalability by reducing creation and destruction overhead.

### Worker Model

Another vital architectural concept is the **worker model**, where tasks are placed in a shared queue and picked up by available workers. Workers remain idle and lightweight until tasks arrive, enabling optimal utilization of CPU resources and smoother performance under fluctuating workloads. Together, thread pools and worker models are essential to high-performance software.

In addition to CPU-bound execution, modern systems benefit from **asynchronous processing**, particularly when dealing with I/O operations such as network calls or disk reads. In a synchronous system, a thread performing an I/O operation must wait until the operation completes, causing blocking and waste. Asynchronous systems initiate the I/O work and immediately free the thread to handle other tasks, allowing many more operations to be processed concurrently. Languages like C# and JavaScript provide primitives such as async/await and promises to make asynchronous programming accessible, while distributed systems often rely on message queues for background tasks.

The difference between traditional and modern web servers illustrates this shift clearly. Older servers like Apache would create a new thread or process for each incoming request, which quickly became inefficient at higher traffic volumes. Modern servers such as Nginx, Node.js, and ASP.NET Core use non-blocking I/O, event loops, and thread pools so that a small number of threads can handle thousands of simultaneous requests, dramatically improving scalability.

### Race Condition

However, concurrency introduces challenges as well. A **race condition** occurs when multiple threads modify shared data simultaneously without coordination, resulting in unpredictable and incorrect behavior. Similarly, a **deadlock** occurs when two or more threads wait indefinitely for each other to release resources, causing the system to freeze. Engineers must use synchronization mechanisms such as locks or mutexes, consistent lock ordering, and timeout strategies to prevent these issues.

Concurrency and parallelism best practices guide engineers in building robust systems. Asynchronous I/O should be the default for I/O-bound workloads to avoid unnecessary blocking. Thread pools should be preferred over manually created threads for CPU-bound tasks. Access to shared mutable data must always be synchronized to avoid corruption. Deadlock prevention techniques must be proactively applied to ensure uninterrupted system operation.

Real-world systems depend heavily on these principles. High-traffic web servers rely on asynchronous processing to remain responsive. Background workers and task queues allow distributed systems to process millions of events efficiently. Applications like video rendering and large-scale data analytics use parallelism to divide workloads and compute faster. Together, these approaches enable software to scale gracefully as demand grows.

## Database Performance Optimization

In this lecture, we will explore various strategies and best practices for optimizing database performance. Since the database lies at the core of most modern systems, ensuring fast and efficient performance is essential for building scalable and reliable applications. By the end of this lecture, you will have a strong understanding of how to tune and optimize databases for real-world performance needs. Let us begin our discussion with a concept we have already encountered earlier: replication.

### Data Replication

Data replication also known as database replication, is a method of copying data to ensure that all information stays identical in real-time between all data resources.

Data replication is like a safety net for your information, ensuring identical copies across multiple locations. Think of it as a real-time mirror for your data, constantly reflecting updates, whether across on-prem servers or to the cloud.

  

&nbsp;

Why is it important?

- **Instantaneous updates:** Say goodbye to refresh buttons and lag. Data replication keeps everyone in sync, boosting user experience and productivity.
- **Disaster recovery:** If your primary server fails, a replica seamlessly takes over, minimizing downtime and protecting critical data.
- **Performance boost:** Spread the workload across multiple instances for faster reads and writes, especially with data geographically distributed.
- **Reduced IT effort:** Automate data replication and focus on more strategic tasks.

Types of Replication

- **Full vs. Partial:** Full replicates everything, while partial focuses on specific data, like financial data in a specific office.
- **Transactional:** Real-time mirroring of changes, ideal for consistency but demanding on resources.
- **Snapshot:** Captures data at a specific point, useful for backups and recoveries.
- **Merge:** Allows independent edits on each node, then merges them all.
- **Key-Based:** Efficiently updates only changed data but doesn't replicate deletions.
- **Active-Active Geo-Distribution:** Real-time, global data syncing for geographically dispersed centers.

Synchronous vs. Asynchronous Replication

- **Synchronous:** Writes happen on both primary and replica simultaneously, maximizing consistency but impacting performance.
- **Asynchronous:** Writes on primary first, copied to replica later, faster but prone to data loss in case of failure.

Challenges to Consider

- **Cost:** Maintaining multiple instances requires significant resources.
- **Expertise:** Skilled professionals are needed to manage and troubleshoot.
- **Network bandwidth:** Heavy replication traffic can overload networks.

&nbsp;

### Data Redundancy

Data redundancy is when multiple copies of the same information are stored in more than one place at a time on same system. This can be helpful for backups and security, but it can also cause problems like increased storage costs, errors, and inaccurate data.

&nbsp;

**How it happens**

Unintentional redundancy can occur through various ways, like duplicate forms, multiple backups, or outdated versions.

**Types**

- **Database vs. File-based:** Redundancy can happen in both, but structured databases typically offer better control.
- **Data replication vs. redundancy:** Replication is intentional (for accessibility), while redundancy can be intentional or unintentional.

**Benefits**

- **Backups:** Provides extra copies in case of data loss.
- **Disaster recovery:** Ensures quick restoration after system failures.
- **Data accuracy:** Enables cross-checking for discrepancies.
- **Improved data protection:** Minimizes attack surface and data access points.
- **Increased availability:** Makes data accessible from multiple locations.
- **Business continuity:** Protects against data loss from internal issues or malware.

**Disadvantages**

- **Data corruption:** Errors during storage or transfer can corrupt copies.
- **Increased maintenance costs:** Requires managing multiple copies.
- **Data discrepancies:** Updates may not be applied to all copies.
- **Slow performance:** Database functions can be hindered.
- **Storage waste:** Duplicate data takes up unnecessary space.

**Reducing redundancy**

- **Delete unused data:** Implement data lifecycle rules and monitoring.
- **Design efficient databases:** Use common fields and architectures.
- **Set goals and plans:** Aim for reduction, not complete elimination.
- **Use data management systems:** Identify and address redundancy issues.
- **Implement master data strategy:** Integrate data from various sources for better management and quality.
- **Standardize data:** Makes redundancy and errors easier to detect.

**Remember:** Data redundancy can be both friend and foe. Use it strategically for backups and security, but actively manage it to avoid the pitfalls.

&nbsp;

### Database Scaling

When your application becomes popular, it needs to scale to meet the demand. Nobody sticks around if an application is slow — not willingly, anyway.

  

&nbsp;

Scaling Approaches

- **Vertical Scaling:** Increase resources on one node (like upgrading your computer). Simple, but limited growth.
- **Horizontal Scaling:** Add more nodes to share the workload (like adding more computers). More complex, but scales further.

&nbsp;

Horizontal Scaling Techniques

- **Sharding:** Split data across multiple nodes. Easy to implement, but requires managing the shard selector and can have imbalance issues.
- **Read Replicas:** Dedicated nodes for read requests, improving read performance without affecting writes. Simple and improves availability, but doesn't improve write performance.
- **Active-Active:** All nodes handle both reads and writes, maximizing performance. Most complex, requires conflict resolution logic in your application.
- **Active-Active Geo-Distribution:** Active-Active across geographically distributed clusters, for global reach and improved latency. Advanced solution, managed by Redis Enterprise.

Choosing the Right Option

- Consider your **performance needs, data size, budget, and technical expertise**.
- Start with **simple options like vertical scaling or read replicas** if complexity is a concern.
- **Sharding and Active-Active** offer more scalability, but require careful planning and implementation.
- **Active-Active Geo-Distribution** is for global deployments with high demands.

**Remember:** Scaling is a powerful tool, but choose wisely based on your specific needs and capabilities.

###  Database Indexes

An index is a database structure that you can use to improve the performance of database activity. A database table can have one or more indexes associated with it.

  

&nbsp;

**What are indexes?**

- Database structures for faster record retrieval.
- Think of them as bookmarks in a book, quickly directing you to specific pages.

**Benefits**

- **Boosts search speed:** Especially for large tables.
- **Improves select queries:** Particularly effective for conditions matching the index expression.

**Trade-offs**

- **Slower inserts/updates/deletes:** Maintaining indexes adds processing overhead.
- **Increased disk space:** Indexes consume additional storage.

**Choosing the right indexes**

- **Consider how you use the table:** More retrievals? Create indexes for search criteria.
- **One field queries:** Simple indexes on individual fields.
- **Multi-field queries:** Concatenated indexes for frequently combined conditions.
- **AND vs. OR:** Indexes work well for AND conditions, not OR.

**Tips for optimal indexing**

- **Match index expression to selection conditions.**
- **Use concatenated indexes for frequent multi-field searches.**
- **Prioritize AND conditions over OR in the Where clause.**

**Joins & indexes**

- Indexes on second table's join field significantly improve performance.
- Create indexes on join fields for subsequent tables in the From clause.

**Remember:**

- Indexes aren't a magic bullet. Analyze your database usage and create indexes strategically.
- Too many indexes can be counterproductive. Find the balance for optimal performance.

&nbsp;

&nbsp;

### Strong vs Eventual Consistency

&nbsp;

**Imagine your laptop notes like data in a distributed system.**

  

- **Master-Slave:** This is like **copying your notes to an external drive**. Both versions are consistent, but updating the drive takes time. You might read stale notes if it hasn't been updated recently.
- **Eventual:** Think of this as **sending your notes to Dropbox**. Updates happen eventually, but not instantly. Reading before an update reaches Dropbox could give you outdated information.
- **Strong:** This is like **typing directly on your notes in Dropbox**. Updates are immediate and everyone sees the latest version. But writing takes longer as Dropbox syncs with all devices.

**Choosing the right model depends on your needs**

- **High availability:** Eventual wins for fast reads and uptime, even if data might be stale sometimes.
- **Data consistency:** Strong guarantees the freshest data, but reading/writing might be slower.
- **Simple application logic:** Strong keeps things predictable, but eventual can be easier to manage.

  

  
<br/>

**Remember:** Each model has its trade-offs. Choose the one that best balances your needs for availability, consistency, and performance.

**Bonus:** Linearizability and Causal Consistency are stricter cousins of Strong and Eventual, respectively. They offer finer control over data ordering for specific situations.

&nbsp;

### Database Sharding

**Your database is struggling under the weight of your application's rapid growth.** More users, features, and data mean bottlenecks and slow performance. Sharding might be the answer, but **understanding its pros, cons, and use cases is crucial before diving in.**

What is Database Sharding?

Sharding splits your database across multiple servers, distributing the data load and increasing capacity. Imagine slicing a pizza: each shard (slice) holds a portion of the data, spread across different servers.

|     |
| --- |
|     |
|     |

  

&nbsp;

Do You Need Sharding?

Consider alternatives before sharding:

- **Vertical scaling:** Upgrade your existing server's hardware like RAM or CPU.
- **Specialized services:** Offload specific tasks like file storage or analytics to dedicated services.
- **Replication:** Make read-heavy data available on multiple servers for faster access.

**When Sharding Shines**

- **High read/write volume:** Sharding handles both reads and writes effectively, especially when confined to specific shards.
- **Large storage needs:** Increase total storage capacity by adding more shards as needed.
- **High availability:** Replica sets within each shard ensure data remains accessible even if a shard fails.

**The Downsides of Sharding**

- **Query overhead:** Routing queries across shards adds latency, especially for queries spanning multiple shards.
- **Administrative complexity:** Managing multiple servers and shard distribution increases upkeep requirements.
- **Infrastructure costs:** Sharding requires more computing power, pushing up expenses.

How Does Sharding Work?

  

&nbsp;

- **Data distribution:** Define how data is spread across shards. Popular methods include range-based (data ranges assigned to shards), hashed (hash function determines shard), and entity/relationship-based (keeps related data together).
- **Query routing:** Determine how queries are routed to the appropriate shards.
- **Shard maintenance:** Plan for redistributing data and adding new shards over time.

Sharding Architectures

- **Ranged/dynamic sharding:** Easy to understand, relies on a suitable shard key and well-defined ranges.
- **Algorithmic/hashed sharding:** Evenly distributes data but may require rebalancing and hinder multi-record queries.
- **Entity-/relationship-based sharding:** Improves performance for related data access but can limit flexibility.
- **Geography-based sharding:** Ideal for geographically distributed data, improves performance and reduces latency.

**Remember:** Sharding is a powerful tool for large applications with demanding data needs. But weigh the complexity and costs against alternative solutions before making the leap. Choose the right sharding architecture based on your specific data distribution and query patterns.

### Normalization and Denormalization

Normalization is a database design technique focused on eliminating redundant data by dividing large tables into smaller, related structures. This improves data integrity while reducing storage usage and eliminating update anomalies. However, normalized designs typically require multiple joins when querying data, which may slow down read performance.

Denormalization reintroduces redundancy to reduce the number of joins needed for query execution. This approach greatly benefits reporting and analytics systems that must fetch large datasets quickly. While denormalization improves read performance, it increases storage usage and raises the risk of inconsistencies when data changes. Therefore, normalization is most suitable for transactional systems where correctness is paramount, while denormalization aligns better with analytical and read-heavy workloads.

### Connection Pooling

Connection pooling enhances performance by maintaining a set of open and reusable database connections that applications can draw from. Creating new database connections is expensive and time-consuming, especially at scale. By reusing existing connections, connection pooling reduces overhead and enables applications to handle high levels of concurrent traffic more efficiently. This technique is crucial for scalable systems such as microservices and cloud-native applications.

### Query Optimization

Query optimization involves improving SQL execution performance to reduce response time and computational load. Awareness of indexing strategies plays a major role here, but other improvements include avoiding the **N+1 query problem**, minimizing unnecessary joins, and writing queries that take advantage of existing indexes. Efficiently written queries ensure databases can support larger workloads without experiencing degradation in performance.

### Materialized Views

A materialized view stores the result of a precomputed query as a physical table. Unlike regular views, which compute data on demand, materialized views allow applications to retrieve pre-aggregated or pre-joined data instantly. This technique is highly useful in reporting and analytical workflows where queries execute repeatedly on large datasets. Although materialized views require periodic refresh and additional storage, they significantly improve the responsiveness of read-heavy systems.

### Batching and Pagination

Batching improves performance by grouping multiple database operations into a single transaction. Instead of executing one insert or update at a time, batching sends them together, reducing communication overhead and improving throughput—especially during bulk processing.

Pagination enhances performance by retrieving limited chunks of a large dataset at a time. Rather than attempting to load an entire data table in a single request, pagination divides data into manageable pages, preserving responsiveness and preventing memory overload. Pagination is essential in user-facing applications such as e-commerce product listings or search platforms.

# Chapter 10 — Reliability, High Availability & Disaster Recovery

Modern software systems operate at global scale, serving millions of users across distributed and cloud-native environments. To ensure stability, business continuity, and uninterrupted service, reliability becomes one of the most critical pillars of system design. In this section, we explore how production-grade systems maintain resilience, recover from failures, and continue functioning under pressure. These concepts form the foundation for designing trustworthy, scalable, and fault-tolerant systems.

## Introduction to System Reliability

System reliability represents the ability of a system to operate continuously without unplanned interruptions. It not only ensures that services remain online, but also that they behave correctly and consistently over time. Reliability is essential because any downtime — whether in a banking application, e-commerce platform, or communication service — directly impacts customer trust, revenue, and brand reputation. While failures are inevitable, reliable systems are defined by how quickly and gracefully they recover from those failures. In engineering terms: _Systems will fail — reliability determines how well they handle those failures._

### Understanding Reliability in System Design

When evaluating reliability, we consider several key factors that together define how dependable a system is. Correctness ensures that requests produce the correct results every time. Consistency ensures that behavior remains predictable across requests and users. Fault tolerance allows a system to continue running even when individual components fail. Availability describes how much time the system remains operational without disruption. These qualities collectively help determine whether a system can truly be classified as reliable under production workloads.

### Measuring Reliability: MTBF and MTTR

Reliability must be measurable to guide engineering decisions. Two primary performance indicators help quantify it effectively.  
**MTBF — Mean Time Between Failures** measures the average duration that a system runs smoothly without encountering any failure. A higher MTBF reflects stronger stability and robustness.  
**MTTR — Mean Time to Recovery** captures how long it takes to restore normal functionality after a failure occurs. A lower MTTR signifies faster recovery and resilience.  
An ideal system therefore achieves a high MTBF and a low MTTR: it rarely fails, and when it does, recovery is rapid.

### Service-Level Agreements (SLAs)

Service-Level Agreements are formal contracts that define expected performance standards such as uptime percentage, response time, and operational accuracy. SLAs define exactly how reliable a service must be. For example, a promise of **99.9% uptime** appears highly reliable but still allows **over eight hours of downtime per year**. SLAs create accountability between providers, internal teams, and customers, ensuring that reliability expectations are clearly defined and measured.

### Availability vs. Durability

Availability and durability are often mentioned together but represent different dimensions of reliability.  
**Availability** refers to the system being accessible and responsive whenever users attempt to interact with it.  
**Durability** ensures that stored data remains correct, secure, and never lost — even if hardware or services fail.  
In short, availability protects service uptime, while durability protects the integrity of user data. Both are essential in designing reliable production systems.

## Reliability in System Architecture

Architects make numerous design choices that directly influence system reliability. Redundancy ensures backup components can immediately take over if one fails. Continuous health checks and monitoring detect anomalies early and trigger automatic healing responses. Retry strategies allow recovery from temporary failures, while circuit breakers prevent cascading outages by blocking requests to unhealthy dependencies. Distributed design patterns such as replication and quorum-based consistency improve reliability by ensuring that services continue functioning even when individual nodes become unavailable. All these practices support the principle of designing systems that remain graceful under failure.

### Reliability Challenges in Distributed Systems

As most modern systems are distributed by nature, maintaining reliability becomes more complex. Network partitions may interrupt communication among nodes, causing temporary unavailability or inconsistencies if not properly managed. Individual node failures may degrade performance or cause partial outages without effective redundancy. Strong consistency becomes challenging because updates may take time to propagate across distributed services, requiring many systems to adopt **eventual consistency** instead. These realities demand careful planning and sophisticated engineering techniques.

### Improving Reliability in Distributed Environments

The CAP Theorem helps engineers make informed trade-offs by recognizing that distributed systems cannot simultaneously guarantee consistency, availability, and partition tolerance. The priority depends on system needs — banking systems lean toward consistency while social networks favor availability. Fault isolation ensures that failures in one subsystem do not impair the entire platform. Replication and consensus algorithms ensure that data remains accessible and correct even in adverse conditions. These strategies collectively build systems that can withstand failures while maintaining essential functionality.

### Reliability in Cloud-Native Systems

Although cloud platforms provide high availability infrastructure, they cannot guarantee that every underlying component will always remain operational. Therefore, cloud-native architectures must **assume failure** as a constant and be designed for rapid recovery. Transient errors frequently occur due to network instability or resource contention, so retry logic, circuit breaking, and timeout strategies are mandatory for resilient cloud behavior. Auto-scaling allows systems to continue performing under heavy demand, while self-healing features automatically restart unhealthy services without human intervention.

To validate resilience, organizations also adopt **chaos engineering**, intentionally introducing failures to observe how the system behaves. By regularly testing the unknown, hidden reliability weaknesses are discovered and addressed before they affect real users. This embodies the core philosophy of reliability engineering: never prevent all failures — instead, _design for failure_ and ensure graceful recovery.

## High Availability, Redundancy, and Fault Tolerance in System Design

In large-scale systems where reliability is of utmost importance, the ability to remain operational during failures defines the success of the system. High availability ensures that services are continuously accessible, even when some components fail. Fault tolerance allows the system to absorb unexpected failures while still functioning correctly. These two goals are foundational in system design, especially when building applications that serve millions of users and must guarantee consistent performance without downtime.

### Redundancy

To achieve high availability, **redundancy** plays a central role. Redundancy refers to incorporating additional components, systems, or processes so that the failure of any single part does not lead to a full system outage. Without redundancy, a single point of failure can disrupt the entire service, damaging business continuity and the user experience. By adding backup systems that can seamlessly take over when primary components fail, redundancy ensures operational continuity and resilience.

There are multiple ways to implement redundancy. **Hardware redundancy** ensures that multiple servers, disks, or storage devices are available so that if one device fails, another continues serving the workload. Similarly, **network redundancy** involves having multiple network routes, routers, or even geographically separated data centers to prevent connectivity failures from bringing down the system. In modern microservices environments, **service redundancy** is essential, using replicated services or database instances so failures do not halt request processing.

Redundancy strategies differ in design and efficiency. **N+1 redundancy** ensures that for every required set of instances, one additional standby instance exists to take over when needed. In **Active-Active architectures**, multiple nodes handle traffic simultaneously—improving both load distribution and fault tolerance. However, this model introduces greater operational complexity and requires state synchronization. In contrast, an **Active-Passive setup** has only one active node handling traffic while passive nodes remain on standby, ready to take over during failures. This approach is simpler and cost-effective but does not help with load balancing and introduces brief delays during failover.

Beyond redundancy, modern systems often adopt **graceful degradation**, meaning the service continues to function even when a component fails—though with reduced functionality instead of a complete outage. For example, if an e-commerce website’s recommendation engine fails during peak shopping hours, disabling recommendations temporarily still allows customers to browse and complete purchases. This protects user trust and prevents revenue loss while failures are addressed.

High availability in real-world systems relies on a combination of architectural patterns. **Load balancers** distribute incoming traffic across multiple backend instances, ensuring that no server becomes a bottleneck and automatically routing traffic away from unhealthy instances. **Data replication**, whether synchronous for strong consistency or asynchronous for better performance, ensures copies of data exist in multiple servers or locations, offering reliability during component failure. Additionally, **automated failover** mechanisms detect failures and switch traffic to healthy standby resources without requiring human intervention, enabling rapid recovery and uninterrupted service.

Designing truly resilient distributed systems means planning for every type of failure. Organizations must implement **redundant components** across all critical systems such as databases, web services, caches, and message brokers so that the loss of any one instance does not cause downtime. They must also adopt **geographical redundancy**, distributing workloads across multiple cloud regions to withstand regional outages or disasters. Finally, failover must be automated through continuous **health monitoring**, where metrics like error rates, response times, and resource usage are evaluated to detect anomalies early.

Health monitoring pairs naturally with **self-healing systems**, where infrastructure can automatically respond to problems without manual intervention. If an application instance becomes unresponsive, the system may restart it or provision new servers dynamically. In distributed clusters and cloud-native platforms like Kubernetes, such automation is built in, allowing the system not just to detect failures but to recover from them. The goal is not to eliminate failures—because in distributed environments, failures are inevitable—but to ensure rapid recovery with minimal user impact.

### Consistent Hashing

Consistent hashing is a hashing technique that performs really well when operated in a dynamic environment where the distributed system scales up and scales down frequently.

Consistent hashing is a specific kind of hashing in which when a hash table is re-sized i.e when the number of servers in the server pool change, only k/n keys need to be remapped on an average, where k is the number of keys, and n is the number of servers.

&nbsp;

  

&nbsp;

**Problem:** Efficiently store and retrieve data in a dynamic distributed system (scales up/down frequently).

**Solution:** Consistent hashing - maps data and servers to a virtual ring, minimizing data movement and load imbalance during server changes.

**How does consistent hashing work ?**

It has two main components- **Hash Space** and **Hash Ring**. Hash space is the range of the output of the hash function. Those outputs are assigned a position on the hash ring. It operates independently of the number of servers or objects in a distributed hash table by assigning them a position on a hash ring. If we map the hash output range onto the edge of a circle, it would mean that the minimum possible hash value, zero, would correspond to an angle of zero and the maximum possible value 360 degrees, and all other hash values would linearly fit somewhere in between.

**Benefits:**

- **Minimal remapping:** Adding/removing servers affects only nearby data items.
- **Balanced load:** Data evenly distributed, preventing hotspots.
- **Scalability:** System handles server changes seamlessly.

**Key Concepts:**

- **Hash functions:** Map data/servers to positions on the ring. Choose a good function (e.g., SHA-1) for randomness and collision resistance.
- **Virtual nodes:** Create multiple per server for finer data distribution and server failure resilience.
- **Rendezvous hashing:** Uses two-dimensional space for mapping, simplifying data locality checks.

**High-Level Design Considerations:**

- **Replication:** Define data redundancy strategy for availability and fault tolerance.
- **Load balancing:** Adjust data distribution based on server load/performance.
- **Monitoring:** Track the hash ring for potential issues (hotspots, server failures).

**Real-world examples:** BitTorrent (peer-to-peer networks), Akamai (web caches).

&nbsp;

&nbsp;

&nbsp;

&nbsp;

&nbsp;

### Distributed Consensus

In a distributed system, multiple computers (known as nodes) are mutually connected with each other and collaborate with each other through message passing. Now, during computation, they need to agree upon a common value to coordinate among multiple processes. This phenomenon is known as Distributed Consensus.

  

&nbsp;

**Imagine this:** Maya and Akash were feeling sporty. Akash proposed a game of cricket, his favorite pastime. Maya, a big cricket fan herself, immediately agreed. Without needing anything further, they both grabbed their gear and headed to the park – united in their enthusiasm for the common activity. This mutual agreement on a shared choice, in this case, cricket, is what we call consensus.

- **What it is:** Multiple computers (nodes) agree on a single value during computations, ensuring coordination and consistency.
- **Why it's needed:** When nodes perform distributed tasks, they need a common reference point to stay in sync.
- **How it works:** Nodes communicate using protocols (like voting or proof-based approaches) to reach agreement.
- **Challenges:** Faulty nodes (crashed or behaving abnormally) can disrupt the process, requiring robust protocols.

**Key points:**

- **Agreement:** All non-faulty nodes must agree on the same value.
- **Validity:** The agreed value must come from a non-faulty node.
- **Termination:** Every non-faulty node eventually agrees on a value.
- **Crash vs. Byzantine failures:** Crash failures are easier to handle than Byzantine failures, where faulty nodes actively mislead others.

**Examples:**

- **Blockchain:** Nodes agree on the state of the ledger (transaction history).
- **Google PageRank:** Nodes agree on the ranking of web pages.
- **Load balancing:** Nodes agree on how to distribute workloads effectively.

**Consensus algorithms:**

- **Voting-based:** Like democratic elections, nodes vote on a value. (e.g., Paxos, Raft)
- **Proof-based:** Nodes provide proof (e.g., work done) to contribute to decisions. (e.g., Proof of Work, Proof of Stake)

**Distributed consensus is a critical building block for reliable and coordinated operation in decentralized systems.**

&nbsp; 

### Distributed Locking

Imagine multiple applications sharing a resource, like a shared file or database record. To avoid collisions and data corruption, we need **Distributed Locking**. It's like taking a ticket at a theme park before riding a popular attraction, but for applications instead of people.

&nbsp;

  

&nbsp;

Here's how it works:

1.     **Application requests a lock:** An application asks a "lock manager" (like a ticket booth) for exclusive access to the resource.

2.     **Lock manager grants or denies:** The manager checks if the resource is locked. If free, it grants the lock to the requesting application.

3.     **Application uses the resource:** The application safely accesses and modifies the resource, knowing no other application can do the same.

4.     **Application releases the lock:** When done, the application releases the lock, freeing it for others.

This ensures:

- **Mutual exclusion:** Only one application can access the resource at a time, preventing data conflicts.
- **Correctness:** Applications can rely on consistent data without worrying about concurrent modifications.

**Benefits of Distributed Locking**

- **Scalability:** Handles many applications accessing resources concurrently.
- **Performance:** Prevents wasted effort from applications trying to access locked resources.
- **Reliability:** Even if some components fail, locks remain secure.

**Examples of Distributed Locking**

- Coordinating updates to inventory levels in an online store.
- Preventing double-booking of appointments in a scheduling system.
- Ensuring consistent processing of financial transactions.

**Different implementations exist**

- **Redis with Redlock algorithm:** Lightweight but might have limitations for strict correctness.
- **ZooKeeper:** Robust consensus system for highly secure locking.
- **Database-level locking:** Built-in locking mechanisms in databases like MySQL or PostgreSQL.

**Choosing the right locking approach depends on your specific needs.** Consider factors like:

- **Required level of correctness:** Are occasional lock failures acceptable, or is absolute accuracy crucial?
- **Performance needs:** How many applications need to access the resource concurrently?
- **Complexity and overhead:** Can you handle the setup and maintenance of a more complex locking system?

**Redlock's flaws:**

- **Unnecessarily complex:** For **efficiency-based locks**, simpler single-node Redis locking suffices. Redlock's heavier setup isn't worth the benefit.
- **Unsafe for correctness:** When **lock accuracy matters**, Redlock fails due to:
    - **Timing assumptions:** It relies on unrealistic expectations like bounded network delays and clock accuracy, failing if violated (e.g., network delays exceeding lock expiry).
    - **Lack of fencing tokens:** It lacks a mechanism to prevent concurrent modifications after delays or pauses, causing data corruption.

**Alternatives:**

- **Efficiency-only locks:** Use single-node Redis with clear documentation highlighting the approximate nature of the locks.
- **Correctness-critical locks:** Avoid Redlock.
    - Use a proper consensus system like ZooKeeper with fencing tokens enforced.
    - Consider databases with strong transactional guarantees.

**Remember:**

- Redis, when used appropriately, is a valuable tool.
- Choose the right tool for the job: Redlock isn't suitable for everything.

&nbsp;

### Gossip Protocol

Gossip protocol is like the grapevine for your computer network, spreading information quickly and efficiently like rumors through small towns. Here's the lowdown:

**What it does:**

- Imagine messages hopping from node to node in your network, whispering the latest news to each other.
- Each node randomly picks a few neighbors and shares the messages it knows.
- These neighbors repeat the process, spreading the messages further like ripples in a pond.
- Eventually, everyone in the network gets the news, even if it takes a few whispers.

**Why it's useful:**

- **Fast updates:** Information spreads quickly without a central hub, keeping everyone in the loop.
- **Resilient to failures:** Even if some nodes go down, the gossip continues through other paths.
- **Scalable:** Works well for large networks with many nodes, just like gossip thrives in big communities.
- **Simple to implement:** No complex infrastructure needed, just nodes talking to each other.

**Real-world examples:**

- **Service discovery:** Nodes learn about each other's availability and capabilities.
- **Data replication:** Updates reach all nodes, keeping everyone's data consistent.
- **Distributed consensus:** Nodes agree on a common state even without a central authority.

**Challenges to consider:**

- **False rumors:** Inaccuracy can spread alongside rumors, requiring verification mechanisms.
- **Overload:** Too much gossip can overwhelm nodes, affecting network performance.
- **Inefficiency:** Redundant transmissions can occur, especially in dense networks.

**Overall, gossip protocol is a powerful tool for information dissemination in decentralized networks, offering speed, resilience, and scalability with inherent challenges to manage.**

### Failover

Failover is a fundamental concept in system design that ensures high availability and reliability of software systems, particularly in distributed architectures and mission-critical environments. In simple terms, failover refers to the automatic process of transferring control from a failed component or system to a redundant or standby component that can continue performing the same operations without interruption. The primary goal of failover is to maintain service continuity even when a hardware failure, software crash, or network disruption occurs.

In a well-architected system, failover is achieved through redundancy—by deploying multiple instances of critical components such as servers, databases, or network nodes. When the primary instance fails or becomes unresponsive, a monitoring mechanism such as a health check service or heartbeat signal detects the failure. Once detected, the system automatically promotes a secondary (or backup) instance to take over the operations of the primary node. This transition happens either instantly or within a short recovery window, ensuring minimal downtime and seamless user experience.

Failover can be classified into two types: active-passive and active-active. In an active-passive setup, only one node is active at a time while the other remains idle, waiting to take over in case of a failure. This approach is simpler to manage but may lead to underutilized resources. In contrast, an active-active configuration allows all nodes to actively process requests simultaneously, distributing the load evenly. If one node fails, the remaining nodes automatically absorb the traffic, thus maintaining full service availability. Active-active systems are typically used in large-scale applications where both performance and availability are critical.

Implementing failover effectively requires careful consideration of data consistency and synchronization between nodes. For example, in database systems, a replication mechanism ensures that the standby node always holds an up-to-date copy of the data from the primary. Techniques such as synchronous or asynchronous replication are used based on the system’s tolerance for data loss (measured as Recovery Point Objective, or RPO) and downtime (measured as Recovery Time Objective, or RTO).

Failover mechanisms are commonly integrated into load balancers, clustered databases, cloud environments, and container orchestration systems like Kubernetes. In cloud infrastructures, failover can extend across regions or availability zones, offering geo-redundancy to protect against large-scale outages.

In essence, failover is the safety net of modern distributed systems—it transforms unpredictable failures into manageable events. By ensuring that services remain available even when components fail, failover enhances user trust, reduces operational risk, and fulfils the core promise of high availability that defines resilient system design.

### Checksum

**Checksums:** like digital fingerprints for files, ensuring authenticity and completeness.

**How they work:** a complex algorithm (hash function) creates a unique string (checksum) from your file. Any change, even tiny, results in a completely different checksum.

**Use cases**

- **Verifying downloads:** compare downloaded file's checksum to source's (provided alongside the file) to ensure no errors during transfer.
- **Checking file integrity:** compare checksums over time to detect accidental or malicious changes.

**Benefits**

- **Peace of mind:** knowing your files are genuine and error-free.
- **Security:** detecting corrupted or tampered files.
- **Efficiency:** avoid wasting time installing or running corrupted programs.

**Getting started**

- **Checksum calculators:** free tools like FCIV, IgorWare Hasher, or JDigest generate checksums for your files.
- **Online tools:** upload your file to websites like MD5 file checksum tool to get its checksum.

**Remember:** checksums are a simple yet powerful way to protect your data and avoid trouble. Use them!

&nbsp;

## Resiliency Patterns

In distributed systems, failures are inevitable. **Resiliency patterns** are design strategies that allow a system to **gracefully handle failures, prevent cascading issues, and maintain availability**. Implementing these patterns ensures that even when parts of the system fail, the overall system continues to function correctly.

### Rate Limiting

Rate limiting is a technique to limit network traffic to prevent users from exhausting system resources. Rate limiting makes it harder for malicious actors to overburden the system and cause attacks like Denial of Service (DoS). This involves attackers flooding a target system with requests and consuming too much network capacity, storage, and memory.

APIs that use rate limiting can throttle or temporarily block any client that tries to make too many API calls. It might slow down a throttled user’s requests for a specified time or deny them altogether. Rate limiting ensures that legitimate requests can reach the system and access information without impacting the overall application’s performance.

**Problem:** Malicious actors flood systems with requests, causing outages and resource exhaustion.

**Solution:** Rate limiting throttles requests to protect services and ensure fair access.

**Benefits:**

- **Prevents DoS attacks:** Blocks attackers from overwhelming the system.
- **Stops account takeovers:** Limits bot activity and credential stuffing.
- **Saves resources:** Optimizes resource usage for legitimate requests.

**How it Works:**

- Tracks IP addresses and request times.
- Sets limits on requests per user/region/server in a timeframe.
- Throttles or blocks exceeding requests.

**Types of Rate Limits:**

- **User:** Based on individual users (IP address, API key).
- **Geographic:** Specific rate limits for different regions.
- **Server:** Different limits for different servers within an application.

**Rate Limiting Algorithms:**

- **Fixed-window:** Allows a set number of requests within a defined time window.
- **Leaky bucket:** Limits requests based on queue size, not time.
- **Sliding-window:** Tracks requests within a moving time window starting from the last request.

**Why Choose Imperva:**

- **Comprehensive protection:** Secures websites, apps, APIs, and microservices.
- **Advanced bot protection:** Stops account takeovers and data scraping.
- **Multiple security layers:** Web Application Firewall, RASP, API Security, DDoS Protection.

**Remember:** Rate limiting is a crucial security measure for protecting your systems and ensuring optimal performance.

&nbsp;

### Heart Beat

Show a server is available by periodically sending a message to all the other servers.

**Problem**

When multiple servers form a cluster, each server is responsible for storing some portion of the data, based on the partitioning and replication schemes used. Timely detection of server failures is important for taking corrective actions by making some other server responsible for handling requests for the data on a failed server.

**Solution**

Periodically send a request to all the other servers indicating liveness of the sending server. Select the request interval to be more than the network round trip time between the servers. All the listening servers wait for the timeout interval, which is a multiple of the request interval.

&nbsp;

**Purpose:**

- **Maintain connections:** Prevent idle connections from being terminated, ensuring availability for real-time data exchange or long-running operations.
- **Monitor health:** Detect inactive or unresponsive servers, enabling proactive actions to maintain service uptime.
- **Coordinate tasks:** Synchronize actions between servers or services in distributed systems.

**Mechanism:**

- Server sends periodic "heartbeat" signals (often simple pings) to clients.
- Clients respond to confirm their presence and responsiveness.
- If a client fails to respond within a specified timeout, server takes action (e.g., connection closure, recovery attempts).

**Implementation:**

- **Transport-level heartbeats:** Embedded within network protocols (e.g., TCP Keep-Alive, WebSocket ping/pong).
- **Application-level heartbeats:** Custom-built into the API logic using timers, threads, or asynchronous mechanisms.
- **Third-party libraries or frameworks:** Available to simplify implementation (e.g., SignalR for ASP.NET).

**Considerations:**

- **Frequency:** Balance overhead with responsiveness (typically every few seconds to minutes).
- **Timeouts:** Set appropriate thresholds to detect failures without false positives.
- **Actions:** Define appropriate responses to missed heartbeats (e.g., reconnection, failover, notifications).
- **Security:** Protect heartbeat signals from unauthorized access or manipulation.

**Common Use Cases:**

- Long-polling for real-time updates in web applications.
- Maintaining persistent connections in chat or messaging apps.
- Monitoring server health in load-balanced environments.
- Coordinating tasks in distributed systems.
- Detecting failed services or clients in microservice architectures.

&nbsp;

### Circuit Breaker Pattern

The Circuit Breaker design pattern is used to stop the request and response process if a service is not working, as the name suggests. When the number of failures reaches a certain threshold, the circuit breaker trips for a defined duration of time.

&nbsp;

  

&nbsp;

**Problem:** Services in microservices architecture can fail, causing cascading failures and resource exhaustion.

**Solution:** Circuit Breaker pattern acts as a proxy, protecting other services by monitoring and controlling calls to a potentially failing service.

**Benefits:**

- **Prevents cascading failures:** Isolates the failing service, stopping it from affecting others.
- **Improves resilience:** Allows the failing service to recover without impacting other services.
- **Optimizes resource usage:** Limits calls to the failing service, preventing resource exhaustion.

**Key Concepts:**

- **States:** Closed (normal operation), Open (blocks requests), Half-Open (allows few test calls).
- **Thresholds:** Define failure and recovery criteria (e.g., number of failures, timeout).
- **Fallback:** Handles failed requests gracefully (e.g., error message, default value).

**Use Cases:**

- Protecting downstream services from a slow or unresponsive service.
- Preventing overload and resource exhaustion on the failing service.
- Implementing graceful service degradation during outages.

**Main Example:**

- Mercantile Finance employee microservice with aggregation pattern calls various backend services.
- Circuit breaker protects the aggregator and other services from a failing backend service.

**How it Works:**

1.     **Closed:** Normal operation, requests flow through to the service.

2.     **Failure threshold reached:** Circuit opens, requests fail immediately.

3.     **Timeout period:** Service sends test calls during this period.

4.     **Test calls succeed:** Circuit closes, normal operation resumes.

5.     **Test calls fail:** Circuit remains open, timeout restarts.

**Additional Notes:**

- Choose appropriate thresholds and timeouts based on service behavior and dependencies.
- Implement monitoring and alerting for circuit breaker states and service health.
- Consider fallback strategies for different failure scenarios.

**Remember:** While some requests might fail during an outage, the Circuit Breaker pattern prevents catastrophic system failures and enables faster recovery.

&nbsp;

&nbsp;

## Backup and Recovery in System Design

In modern system design, achieving resilience is not only about maintaining uptime—it is equally about how effectively a system can recover when failures occur. Backup and recovery mechanisms ensure that data remains safe and that systems can be restored to a functional state after disruptions. A strong recovery strategy allows organizations to withstand unexpected incidents while minimizing business impact. This chapter explores backup methods, recovery models, essential performance objectives, and the critical trade-offs that shape an effective recovery strategy.

### Understanding Backup and Recovery

Backup is the process of creating secure copies of data to protect it from loss due to accidental deletion, corruption, failures, or cyberattacks. Recovery refers to the restoration of this data when such incidents occur, enabling the system and its users to come back online. Together, they form a core defense layer against data loss, complementing—rather than replacing—redundancy and replication strategies. While redundancy keeps systems operational during failures, backups ensure that data can be restored even in catastrophic scenarios such as ransomware attacks or physical data center loss.

Backups are not optional—they are a fundamental requirement. From legal compliance obligations to the prevention of financial loss, maintaining a robust backup plan protects organizations from operational breakdowns and reputational damage.

### Types of Backup Strategies

Backup systems vary in how much data they capture and how efficiently they store it. The choice determines how fast and costly recovery will be.

A **full backup** makes a complete copy of all data. It offers simple, fast restoration but demands large storage space and long processing time as data grows. An **incremental backup** captures only the data changes since the last backup—whether full or incremental. It saves storage efficiently and runs quickly but may delay recovery because multiple backup files are needed to rebuild the full dataset. A **differential backup** strikes a balance by storing all changes since the last full backup, requiring more storage than incremental backups but enabling faster recovery.

In real-world systems, organizations often combine these approaches—such as weekly full backups complemented by daily incremental backups—to balance speed, resiliency, and cost.

### Recovery Models

Recovery models determine how quickly a system becomes operational after a failure. The choice depends largely on the criticality of the application.

A **cold recovery** strategy relies on offline backups with no pre-provisioned infrastructure. This keeps costs low but results in long downtime, sometimes lasting hours or days. A **warm recovery** approach keeps some resources—like idle but preconfigured servers—ready for activation, enabling faster but still noticeable downtime. In contrast, **hot recovery** offers the highest availability. Fully redundant systems operate in parallel, allowing recovery to occur almost instantly. This ensures minimal disruption but requires the highest investment.

Not all systems justify hot recovery—cost must be proportional to business impact.

### Recovery Objectives: RTO and RPO

Two key metrics govern backup and recovery planning: **Recovery Time Objective (RTO)** and **Recovery Point Objective (RPO)**.

RTO defines the maximum acceptable downtime—the time within which services must be restored after failure. A lower RTO requires more automation, redundancy, and expense. RPO defines how much data loss is tolerable, based on the point in time to which data can be restored. A system with an RPO of 1 hour should never lose more than one hour of data.

Shorter RTO and RPO targets demand greater infrastructure maturity and higher operational costs. The strategy must therefore align with business priorities rather than purely technical ambitions.

### Trade-Offs in Backup Strategy Design

Backup strategies require careful decision-making to achieve balance:

- **Cost vs. Recovery Speed**: Faster recovery requires more replication, more frequent backups, and greater automation—each increasing costs.
- **Backup Frequency vs. Storage Growth**: Excessive backups lead to inflated storage usage, while infrequent backups increase data loss risk.
- **Compliance Requirements vs. Operational Complexity**: Industries with strict retention rules force organizations to store and protect data longer.

Ultimately, backup planning should reflect business criticality, legal obligations, and the organization's ability to manage operational complexity.

### Best Practices for Backup and Recovery

Reliable and secure backups do not happen accidentally. They must be planned and continuously validated. Automated processes reduce human error, while frequent restoration testing ensures confidence in the recovery path. All backups must be **encrypted both in transit and at rest** to protect against unauthorized access, especially during cyberattacks.

Monitoring backup success and failures is essential—silent failures leave organizations exposed. A widely accepted guideline, the **3-2-1 Rule**, strengthens resilience: maintain three copies of data, on two different storage media, with one copy stored offsite. This protects against localized disasters, software corruption, and infrastructure failure.

## Disaster Recovery in System Design

As systems become mission-critical and globally accessible, the importance of disaster recovery increases significantly. Disaster recovery (DR) focuses on the resilience of the entire system, ensuring that applications, services, and infrastructure can continue to operate even when unexpected failures occur. While backups protect data, disaster recovery protects business continuity. Industries such as finance, healthcare, and e-commerce cannot afford downtime because even a few minutes of outage can lead to major financial loss, customer dissatisfaction, and regulatory breaches. Therefore, DR isn't a luxury—it is a mandatory architectural requirement to maintain trust, compliance, and operational stability.

For mission-critical architectures, disaster recovery must be closely aligned with business goals and strict service availability commitments. Organizations define RTO (Recovery Time Objective) and RPO (Recovery Point Objective) as measurable targets for acceptable downtime and data loss. Achieving these targets requires redundancy across compute, storage, networking, and even geographical regions. Merely having backups is not enough. Failover strategies must be in place so the system can continue running during an outage, ensuring that applications remain accessible with minimal disruption.

A comprehensive disaster recovery plan combines reliable backup processes with automated failover mechanisms. Backups ensure that data can be restored, while failover ensures that services continue to operate even if the primary environment becomes unavailable. For instance, if an entire region goes offline, traffic should seamlessly be redirected to another region where the necessary infrastructure and data replicas are already available. When both backup and failover strategies are implemented together, systems become resilient not only to data corruption or human errors but also to large-scale infrastructure failures.

However, designing a disaster recovery plan is not enough on its own—it must be tested regularly. A plan that has never been validated cannot be trusted in a real emergency. Automated procedures are essential for switching from primary to secondary systems, validating data integrity after recovery, notifying teams, and maintaining logs of the recovery process. Conducting DR drills and simulated outages allows organizations to uncover hidden gaps, strengthen the recovery process, and ensure that teams are fully prepared to respond effectively when disaster strikes.

As systems expand across multiple geographic regions, disaster recovery becomes more complex. Data consistency must be carefully managed so that updates in one region are accurately synchronized across all others. Latency increases due to physical distance, especially during failover events, and must be considered in the design. Regulations such as data residency laws may restrict where customer information can be stored or processed, adding further complexity. Additionally, coordinating failover between regions must prevent conflicting states—a challenge known as split-brain. To manage this safely, multi-region systems rely on orchestration logic and consensus algorithms.

To build resilience at scale, two architectural strategies are particularly valuable: geo-redundancy and quorum-based design. Geo-redundancy ensures that services are distributed across multiple data centers or cloud regions, so if one location fails, another location can immediately take over. Quorum-based design is used in distributed systems to maintain data correctness. It requires a majority of nodes to agree before confirming any write operation. This prevents inconsistent states and ensures that even during partial failures, decisions are made only when enough nodes are healthy to safely validate the operation.

In summary, disaster recovery is a crucial component of system design, ensuring that businesses remain operational during unexpected failures. True resilience combines both backups and failover mechanisms, supported by automation and regular testing. When systems span across regions, architects must handle additional complexity through strategies such as geo-redundancy and quorum-based consistency. By applying these principles, organizations can build systems that not only protect data but also ensure seamless continuity—even when disaster strikes.

# Chapter 11 — Security & Threat Modeling

This section establishes the fundamental pillars of system security, beginning with strong **Authentication** mechanisms, including password hashing, Multi-Factor Authentication (MFA), and the principles of OAuth and Single Sign-On (SSO). It then covers fine-grained **Authorization** using models like Role-Based Access Control (RBAC) and Attribute-Based Access Control (ABAC). The chapter details strategies for **Data Protection**, such as end-to-end encryption (TLS/SSL) for data in transit and various forms of encryption for data at rest. Finally, it explores common system-level threats like DDoS and bot attacks, and introduces preventative measures such as Rate Limiting, Auditing, and Web Application Firewalls (WAF).

## Introduction to Security in System Design

Security is one of the most critical yet frequently overlooked pillars of modern system architecture. In this section, we explore why security must be treated not as an optional enhancement but as a fundamental design requirement. We begin by understanding the role of security in distributed systems—how it builds user trust, protects sensitive information, and ensures a system remains reliable even under attack. Unlike monolithic systems, distributed architectures expose multiple components, nodes, and interfaces, increasing potential vulnerabilities and demanding protection at every layer.

To navigate this complexity, we examine the CIA triad—Confidentiality, Integrity, and Availability—which forms the foundational framework for secure design.

We also introduce the concept of threat modeling and tools like the STRIDE model to help identify adversaries, anticipate risks, and strengthen system defenses. From insecure APIs and misconfigured servers to weak authentication and exposed open ports, we uncover the common attack vectors that compromise real-world systems. Next, we walk through major attack types, including DDoS, man-in-the-middle interference, injection attacks, and spoofing, along with proven mitigation strategies such as TLS encryption, rate limiting, parameterized queries, MFA, and token-based authentication.

Recognizing that security is a continuous process, we break down how it integrates into every phase of the Software Development Life Cycle—requirements, design, development, testing, deployment, and maintenance—through practices like threat modeling, secure coding, secret management, and patching.

We also highlight key best practices such as adopting security by design, validating all inputs, hardening infrastructure, encrypting data in transit and at rest, and implementing effective monitoring and logging. Together, these principles equip architects to build systems that are not only functional but resilient, trustworthy, and prepared for evolving threats. With this foundation in place, the next lecture takes us deeper into two essential components of system security: authentication and authorization.

## Authentication

Authentication and identity management form the backbone of secure system design, enabling platforms to correctly verify users and safely control access. As modern architectures evolve toward distributed systems, microservices, and cloud-native environments, authentication techniques must ensure not only security but also scalability, interoperability, and smooth user experience.

### Basic Authentication

Basic Authentication represents one of the earliest and simplest mechanisms for validating user credentials. It works by transmitting a Base64-encoded string containing a username and password inside the Authorization header. Although compatible with all HTTP clients, its simplicity also exposes limitations.

**How It Works:**  
The client sends **Authorization:** **Basic &lt;base64(username:password)&gt;** with every request. The server decodes the header and validates the credentials against its user store.

**Pros:**

- Extremely simple to implement
- Works with virtually any HTTP client or tool

**Cons:**

- Credentials are sent with every request
- No session management, token expiration, or revocation
- Weak security even when paired with HTTPS
- Not suitable for production-grade APIs

**Use Case:**  
Very limited today—mostly used for internal services or quick testing across secure environments.

### Bearer Token Authentication (Opaque Tokens)

Opaque tokens introduce server-issued access tokens that carry no embedded information. Instead, the token is simply a random string referencing session data stored on the server side.

**How It Works:**  
The server generates an opaque access token and stores its metadata in a database or cache like Redis. Clients send it via **Authorization:** **Bearer &lt;token&gt;.** The server validates the token on each request.

**Pros:**

- Server-side storage allows immediate revocation
- Simpler and safer than handling raw credentials
- Validates access centrally

**Cons:**

- Requires a lookup for every request
- Performance bottlenecks possible without caching
- Less scalable for very high-traffic APIs

**Use Case:**  
Ideal for enterprise platforms requiring immediate session invalidation and strong central control.

### JWT (JSON Web Token) Authentication

JWTs are self-contained, cryptographically signed tokens that carry claims such as user ID, role, and expiration. They are widely used in modern distributed systems due to their stateless nature.

**How It Works:**  
A server issues a signed **JWT (header.payload.signature)** and returns it to the client. The client sends the token with each request. The server verifies the signature and trusts the embedded claims—no database lookup required.

**Pros:**

- Stateless and highly scalable
- Strong integrity via HMAC or RSA signatures
- Supports custom claims and flexible expiry

**Cons:**

- Cannot be revoked until expiration, unless additional strategies are used
- Larger size compared to opaque tokens
- Requires refresh token rotation to maintain security

**Use Case:**  
Modern APIs, mobile apps, and microservices where performance and horizontal scalability are crucial.  
Use token versioning or a refresh-token store to support revocation and secure rotation.

### OAuth 2.0

OAuth 2.0 is not an authentication protocol but an authorization framework that enables secure delegated access. It allows users to grant third-party applications controlled access to their data without sharing credentials.

**Common Flows:**

- **Client Credentials Flow:** Machine-to-machine communication
- **Authorization Code + PKCE:** Recommended for web, SPA, and mobile apps
- **Implicit (deprecated):** Older SPAs

**How It Works:**  
Users authenticate with an authorization server, grant consent, and the third-party receives scoped tokens to access selected resources.

**Pros:**

- Industry-standard for delegated access
- Secure with scopes and PKCE
- Supports refresh tokens and fine-grained permissions

**Cons:**

- Complex to implement
- OAuth alone does not authenticate users

**Use Case:**  
“Sign in with Google,” API integrations, and secure third-party data access.

### OpenID Connect (OIDC)

**OpenID Connect builds on OAuth 2.0 by adding an identity layer.** It introduces an **ID token**, usually a JWT, that contains verified information about the user.

**How It Works:**  
Through OAuth2 flows, the system receives:

- **Access Token** – for accessing resources
- **ID Token** – proving who the user is
- **Refresh Token** – for renewing access

**Pros:**

- Supports both authentication and authorization
- Secure, widely adopted SSO standard
- Prevents token misuse through audience and nonce validation

**Cons:**

- Slightly more complex
- Requires strict validation logic

**Use Case:**  
Modern authentication systems using identity providers like Google, Microsoft, Okta, or Auth0.

### Single Sign-On (SSO)

SSO allows a user to authenticate once and access multiple applications without repeating the login process.

**Flavors:**

- **SAML:** XML-based, popular in enterprises
- **OIDC-based SSO:** JSON-based, modern web & mobile

**Pros:**

- Greatly improves user experience
- Centralized authentication & logout
- Reduces password fatigue and attack surface

**Cons:**

- Setup complexity
- Dependency on the identity provider’s availability

**Use Case:**  
Enterprise ecosystems, SaaS suites, cross-product platforms.

### SCIM (System for Cross-domain Identity Management)

SCIM is not an authentication mechanism; it is a protocol for **automating identity lifecycle management** across systems.

**How It Works:**  
When a user is created, updated, or removed in an identity provider, SCIM synchronizes the change across all connected applications.

**Pros:**

- Prevents orphaned accounts
- Automates provisioning & de-provisioning
- Reduces security risks and admin overhead

**Cons:**

- Additional integration effort
- Not part of the authentication flow

**Use Case:**  
Large organizations using platforms such as Okta or Azure AD to manage thousands of users.

### Security and Implementation Best Practices

- Always enforce **HTTPS**
- Prefer **HttpOnly cookies** over localStorage for token storage
- Use **short-lived access tokens + refresh tokens**
- Apply **PKCE** for mobile and SPA apps
- Revoke refresh tokens on logout
- Never expose sensitive claims inside JWT payloads

### IdentityServer Token Storage and Revocation

Modern identity frameworks like **Duende IdentityServer** combine flexibility with strong security by using persistent storage for managing token lifecycles.

**Access Token Options**

IdentityServer supports:

1.  **JWT Access Tokens (default):**
    - Stateless
    - Verified by signature
    - Not stored server-side
    - Not directly revocable
2.  **Reference (Opaque) Access Tokens:**
    - Stored in DB
    - Validated through introspection
    - Immediately revocable

**Refresh Token Storage**

Refresh tokens are always stored because they must be tracked, rotated, or revoked. Stored fields include token ID, subject, client, expiration, and scope.

**Token Revocation**

IdentityServer provides a /connect/revocation endpoint for revoking:

- Refresh tokens
- Reference access tokens

JWT access tokens cannot be revoked directly; instead, revocation prevents new tokens from being issued by invalidating the refresh token.

**Persisted Grant Tables**

Typical IdentityServer storage includes:

- **PersistedGrants** – refresh tokens, reference tokens, device codes
- **DeviceCodes** – support for device flow
- **Keys** – signing keys

## Authorization

Authorization is the process of determining **what a user is allowed to do** after they have been authenticated (i.e., identity verified).

➡️ **Authentication:** Who are you?  
➡️ **Authorization:** What can you access/do?

Example:

- Authentication: You log into Gmail → identity confirmed.
- Authorization: You can read your emails but not access the admin console.

There are several authorization models used to control what users can do within a system. Each model has its own use case depending on the level of security, flexibility, and administrative ease required.

### Role-Based Access Control (RBAC)

Access is granted based on **roles** assigned to users.

Example:

| **Role** | **Permissions** |
| --- | --- |
| Admin | Create/Read/Update/Delete |
| User | Read Only |

✔ Easy to manage for large systems  
❌ Can become rigid when permissions grow

How it works:

1.  User → assigned a role
2.  Role → mapped to permissions
3.  System checks role before allowing action

Used in: Kubernetes, Windows AD, Azure RBAC, JWT Claims

### Attribute-Based Access Control (ABAC)

Decisions based on **attributes** of user, resource, or environment.

Attributes include:

- User (department, age, job title)
- Resource (file type, classification)
- Environment (time, location, device)

Example policy:

Allow “Finance” department users to access “Payroll” documents only during business hours.

✔ Very flexible  
❌ More complex configuration

Used in: Google Cloud IAM, AWS S3 bucket policies

### Policy-Based Access Control (PBAC)

Uses **centralized authorization rules** written as policies.

Often used with ABAC:

- Example: OPA (Open Policy Agent), Azure Policy

✔ Fine-grained & dynamic control  
❌ Requires governance and policy writing

### Rule-Based Access Control

Access is based on **predefined rules** like firewall rules or IP restrictions.

Example:

Allow access only from corporate network

✔ Good for environmental restrictions  
❌ Not user-specific enough by itself

### Discretionary Access Control (DAC)

The **owner** of a resource decides permissions.

Example:

- Google Drive: Owner shares file with others

✔ Easy to understand  
❌ Less secure — depends on owners’ decisions

### Mandatory Access Control (MAC)

Strict access rules enforced by a **central authority**, usually in government/military security.

Example:

- “Top Secret” classified documents

✔ Very secure  
❌ Not flexible for everyday systems

### Summary Table

| **Model** | **Best Use Case** | **Flexibility** | **Complexity** |
| --- | --- | --- | --- |
| RBAC | Enterprise apps with clear roles | Medium | Low |
| ABAC | Fine-grained access | High | High |
| PBAC | Cloud governance + automation | High | Medium-High |
| DAC | File sharing apps | Medium | Low |
| MAC | High-security systems | Very Low | Very High |

## Data Protection and Secure Communication

In today's distributed, cloud-driven world, data continuously moves across networks, rests in databases, flows through APIs, and gets processed by countless systems. This makes protecting data—whether stored or transmitted—absolutely essential. Threats continue to evolve, regulations grow stricter, and user expectations for privacy are at an all-time high. Whether you are designing backend systems, microservices, cloud architectures, or preparing for high-level interviews, a strong grasp of data protection is non-negotiable.

### Why Data Protection Matters

Data protection is more than just a backend concern—it is the foundation for user trust and legal compliance.

**Growing Threat Landscape:**  
From large-scale breaches to **man-in-the-middle** attacks, sensitive data is constantly at risk. A single vulnerable endpoint can expose personal information, financial records, and intellectual property.

**Regulatory Pressures:**  
Frameworks like **GDPR**, **HIPAA**, and local privacy laws mandate strict controls around how data is collected, stored, processed, and transmitted. Failing to comply can result in severe penalties.

**User Trust:**  
If users cannot trust your platform, they will not use it. Data protection is a core ingredient in building reliable and credible systems.

### Understanding Encryption

Encryption is the process of converting readable data (plaintext) into unreadable form (ciphertext) using a key. Only someone possessing the correct key can decrypt and read the data again.

**Encryption Flow:**  
Plaintext → Encrypt (with key) → Ciphertext  
Ciphertext → Decrypt (with same or paired key) → Plaintext

Encryption ensures that even if unauthorized parties intercept data, they cannot understand it without the key.

### Encryption at Rest and In Transit

**Encryption at Rest**

This protects stored data, such as:

- Database entries (e.g., customer details)
- Disk files
- Backups
- Cloud storage objects

Common techniques include:

- **Full Disk Encryption (FDE)**
- **Database-level encryption** for sensitive fields
- **Cloud storage encryption** (AWS S3, GCP Storage, Azure Blob)

**Encryption in Transit**

This protects data traveling across networks using **TLS/SSL**.

Examples:

- User login requests
- API calls between services
- Microservice-to-microservice communication

This prevents eavesdropping and man-in-the-middle attacks.  
For all production systems, **plaintext HTTP must never be used**—always enforce HTTPS.

### Symmetric vs Asymmetric Encryption

**Symmetric Encryption**

- One key for both encryption and decryption
- Extremely fast and efficient
- Ideal for large data volumes (files, backups, databases)

**Challenge:**  
Both sender and receiver must securely share the key.

**Asymmetric Encryption**

- Uses a **public key** (encrypt) and a **private key** (decrypt)
- Enables secure key exchange without revealing secrets
- Used for:
    - TLS handshake
    - Digital signatures
    - Identity verification

Although slower, it solves the key distribution problem.

**Hybrid Approach (Real-World Use)**

Modern systems combine both:

- Use **asymmetric encryption** to securely exchange a symmetric key
- Use **symmetric encryption** for the rest of the session (faster)

This is how TLS works under the hood.

### TLS/SSL and HTTPS: Securing Communication Channels

HTTPS is simply **HTTP over TLS**.  
TLS ensures the three core pillars of secure communication (CIA):

- **Confidentiality:** Data is encrypted
- **Integrity:** Data cannot be altered in transit
- **Authenticity:** Client communicates with the real server

**TLS Handshake Overview**

1.  Client initiates a secure connection
2.  Client and server exchange keys using asymmetric encryption
3.  They negotiate a cipher suite
4.  A shared symmetric key is generated
5.  All further communication uses fast symmetric encryption

Without TLS, HTTP is fully exposed—no encryption, no verification, no protection.

### Password Protection: Hashing and Salting

Passwords must **never** be stored in plaintext or even encrypted form.

**Hashing**

Hashing transforms data into a fixed-length value using a one-way function.  
It **cannot** be reversed.

Why encryption is not enough:

- Encrypted data can be decrypted
- Hashed data cannot
- That’s why passwords are always hashed

**Salting**

A **salt** is a random string added to the password before hashing.

Benefits:

- Prevents identical passwords from producing identical hashes
- Protects against rainbow table attacks
- Makes bulk cracking significantly harder

Modern hashing algorithms like **bcrypt**, **scrypt**, and **Argon2** include salts automatically and are intentionally slow to resist brute-force attacks.

### Public Key Infrastructure (PKI)

Public Key Infrastructure (PKI) is the system that manages digital certificates and validates the identity of servers, users, and services on the internet.

**How PKI Works**

Every HTTPS website presents a **digital certificate** containing:

- Public key
- Identity information

A trusted **Certificate Authority (CA)** verifies and signs this certificate.

Your browser checks:

1.  Is the certificate issued by a trusted CA?
2.  Is it valid?
3.  Does the signature match?

Certificates form a **chain of trust**:  
Website cert → Intermediate CA → Root CA

**Why PKI Matters**

PKI powers:

- HTTPS
- Secure email
- Software update verification
- Digital signatures
- Secure communication in distributed systems

Without PKI, secure communication on the internet would collapse.

### API Security and Hardening

APIs are prime targets because they expose core data and functionality. Securing them is critical.

**Core API Security Practices**

- Always use **HTTPS**
- Enforce **authentication & authorization** (JWT, OAuth, API keys)
- Validate tokens on every request
- Apply **rate limiting** to prevent abuse
- Use **IP whitelisting** for internal or sensitive APIs

**Mutual TLS (mTLS)**

For highly sensitive systems, both the client and server present certificates to verify each other.  
This is common in:

- Zero-trust networks
- Financial systems
- Internal microservices requiring strict identity

## Security Integration Across the Software Development Life Cycle (SDLC)

Security is not a one-time effort but a continuous process that must be embedded into every stage of the Software Development Life Cycle. By integrating security early and consistently, organizations can proactively prevent vulnerabilities rather than fixing them after deployment.

### Requirements Phase

Security begins with defining compliance needs, access controls, data protection rules, and regulatory requirements. Clear security expectations help ensure the design and development teams build with protection in mind from the start.

### Design Phase

Practices such as **threat modeling**, secure architecture patterns, and risk assessment help identify and mitigate potential security issues before any code is written. This ensures that systems are **secure by design**.

### Development Phase

Developers follow **secure coding standards**, incorporate static code analysis, and avoid common vulnerabilities like injection attacks, insecure authentication, and data leaks. Security controls are built into the code, not bolted on later.

### Testing Phase

Security testing validates that the application can withstand malicious activity. Techniques like **penetration testing**, vulnerability scanning, and security test automation help detect flaws before release.

### Deployment Phase

Secure deployment involves **secret management**, secure configuration, infrastructure hardening, and enforcing least-privilege access. This protects the application in production environments.

### Maintenance Phase

Security continues post-release with continuous monitoring, **patching**, incident response, and updating configurations as threats evolve. Ongoing improvements keep the system resilient over time.

## Understanding Threats, Attack Vectors, and Mitigation Strategies

To build secure systems, it is essential to first understand how they may be attacked. Threat modeling plays a key role in this process by helping teams identify adversaries, analyze potential weaknesses, and proactively strengthen defenses. Tools like the **STRIDE model** guide this analysis by categorizing threats such as spoofing, tampering, information disclosure, and denial of service, ensuring that common risks are not overlooked.

In the real world, attacks often exploit **insecure APIs**, **misconfigured servers**, **weak authentication**, and **exposed open ports**. These vulnerabilities provide attackers with entry points into systems, making it critical to evaluate and protect all interfaces in the environment.

We also explore major cyberattack types, including:

- **Distributed Denial of Service (DDoS)** attacks that overwhelm systems with traffic
- **Man-in-the-Middle (MitM)** interference that alters or eavesdrops on communications
- **Injection attacks** such as SQL or command injection that manipulate back-end processes
- **Spoofing** attacks that impersonate trusted identities to gain unauthorized access

For each risk, we highlight **proven mitigation techniques** such as **TLS encryption** for secure communication, **rate limiting** to reduce abuse, **parameterized queries** to prevent injection, and **MFA + token-based authentication** to strengthen identity security.

By understanding threats and proactively defending against them, organizations can significantly reduce exploit opportunities and build systems that are resilient against evolving cyberattacks.

### Injection Attacks

Injection attacks occur when untrusted input is sent into a program in a way that alters its intended behavior. Attackers exploit insecure input handling to execute malicious commands, access data, or compromise the underlying system.

How it Works

Injection occurs when:

- User input is not validated or sanitized.
- The application directly incorporates input into commands, queries, or scripts.
- The backend system interprets this input as executable instructions.

Common targets include:

- SQL queries
- Operating system commands
- LDAP queries
- NoSQL queries
- ORM frameworks
- Shell scripts

Types of Injection Attacks

- **SQL Injection (SQLi):** Attacker manipulates SQL queries to access or modify database data.
- **Command Injection:** Attacker injects OS-level commands through input fields.
- **NoSQL Injection:** Exploits dynamic queries in NoSQL databases like MongoDB.
- **LDAP Injection:** Alters directory service queries.

Impact

- Unauthorized data access
- Data modification or deletion
- Full system compromise
- Credential disclosure
- Remote code execution

Prevention

- Always use **parameterized queries / prepared statements**
- Avoid dynamic query construction
- Validate and sanitize user input
- Implement least-privilege database accounts
- Use ORM safely and avoid raw queries

### Cross-Site Scripting (XSS)

XSS enables attackers to inject malicious JavaScript into web pages viewed by other users. This script runs in the victim’s browser, giving attackers access to sensitive user data or control over user interactions.

How it Works

The attacker injects JavaScript through:

- Input fields
- URLs
- Comments or user-generated content
- Third-party scripts

If the application does not sanitize or encode the input properly, the script gets executed on the user’s browser.

Types of XSS

- **Stored XSS:** Malicious script is permanently stored (e.g., database, CMS) and executed when users load the page.
- **Reflected XSS:** Script is injected in a request (e.g., URL) and reflected immediately in the response.
- **DOM-based XSS:** Injection occurs through unsafe manipulation of the DOM on the client side.

Impact

- Session hijacking
- Account takeover
- Credential theft
- Fake UI overlays for phishing
- Unauthorized actions on behalf of the user

Prevention

- Output encoding (HTML, JS, CSS context-specific encoding)
- Escaping user input
- Content Security Policy (CSP)
- Validating and sanitizing input
- Avoid using innerHTML or unsafe DOM APIs

### Cross-Site Request Forgery (CSRF)

CSRF tricks authenticated users into performing unwanted actions on a web application without their knowledge. It exploits the trust a site places in a user’s browser.

How it Works

1.  A victim is logged into a legitimate application (e.g., bank account).
2.  The attacker tricks the victim into clicking a malicious link or loading an image/script.
3.  The browser automatically includes cookies/session tokens with the request.
4.  The application processes the request because it appears authenticated.

Impact

- Funds transfer
- Password changes
- Deleting accounts
- Unwanted configuration updates
- Any action that relies solely on cookies for authentication

Prevention

- Use **CSRF tokens** (synchronizer tokens)
- Require **SameSite cookies** (Lax or Strict)
- Implement **re-authentication** for sensitive actions
- Validate origin and referer headers
- Use CAPTCHAs where appropriate

### CORS (Cross-Origin Resource Sharing)

CORS is not a vulnerability by itself, but **misconfigured CORS** opens serious security risks. CORS controls how web browsers allow different origins to access resources.

What CORS Does

Browsers block cross-origin requests by default.  
CORS explicitly defines which domains can access API resources.

**Common CORS Misconfigurations**

- Allowing Access-Control-Allow-Origin: \* on authenticated endpoints
- Allowing all origins and methods
- Enabling credentials (Access-Control-Allow-Credentials: true) with wildcard origins
- Trusting unverified dynamic origins

Impact of Insecure CORS

- Sensitive data exposure
- Account takeover through malicious websites
- Unauthorized cross-origin requests
- Ability for attackers to perform privileged actions via another origin

Best Practices

- Never use \* with credentials enabled
- Whitelist only trusted domains
- Avoid dynamically reflecting request origins
- Use strict HTTP methods and allowed headers
- Limit CORS access to public and non-sensitive endpoints

### Server-Side Request Forgery (SSRF)

SSRF occurs when an attacker manipulates a server to make unauthorized internal or external requests on their behalf. It exploits applications that fetch URLs or external resources based on user input.

How SSRF Works

An attacker supplies a crafted URL for the server to fetch, such as:

- Internal services (http://localhost:8080/admin)
- Cloud metadata endpoints (e.g., AWS 169.254.169.254)
- Private APIs
- Internal load balancer or database endpoints

Because the request originates from the server itself, it typically bypasses perimeter defenses.

Impact

- Accessing internal services
- Retrieving cloud credentials
- Port scanning internal networks
- Remote code execution in extreme cases
- Pivoting deeper into the network

Prevention

- Whitelist allowed URLs/domains
- Block access to internal IP ranges (169.254/16, 127.0.0.1, 10.0.0.0/8, etc.)
- Validate and sanitize user input
- Disable redirects when unnecessary
- Use network-level segmentation to isolate internal services
- Avoid using server-side fetches based on raw user input

### DDoS Attacks (Distributed Denial of Service)

A Distributed Denial of Service (DDoS) attack is an attempt to overwhelm a system, network, or application with massive volumes of traffic coming from multiple compromised sources. The goal is simple: make the service slow, unstable, or completely unavailable to legitimate users.

How DDoS Attacks Work

A DDoS attack usually involves:

1.  **Botnets:** Attackers infect thousands of computers or IoT devices with malware.
2.  **Command & Control (C2):** All infected devices receive instructions simultaneously.
3.  **Traffic Flooding:** These devices generate enormous volumes of requests to the target server.
4.  **Resource Exhaustion:** The service cannot handle the load and becomes unresponsive.

Common targets include:

- Web servers
- Payment gateways
- Authentication systems
- Gaming/streaming platforms
- APIs and load balancers

Types of DDoS Attacks

DDoS attacks fall into three main categories:

**1\. Volumetric Attacks (Bandwidth Flooding)**

Aim: Saturate the network’s bandwidth.  
Examples:

- UDP Floods
- ICMP Floods (Ping Floods)
- Amplification attacks (DNS, NTP, Memcached)

These attacks often exceed **hundreds of Gbps to multiple Tbps**.

**2\. Protocol Attacks (Network Resource Exhaustion)**

Aim: Exploit weaknesses in network protocols.  
Examples:

- SYN Flood
- ACK Flood
- Ping of Death
- Fragmentation attacks

These attacks overwhelm firewalls, routers, and load balancers.

**3\. Application Layer Attacks (L7 Attacks)**

Aim: Exhaust the application/server itself.  
Examples:

- HTTP GET/POST flood
- Slowloris (keeps connections open indefinitely)
- API abuse attacks

These are harder to detect because the requests appear “legitimate.”

**Impact**

- Severe downtime
- Loss of revenue
- Service degradation
- Increased infrastructure costs
- Damage to reputation
- Breach opportunities during distraction

Prevention and Mitigation

**1\. Rate Limiting**

Restricts requests per IP/user → prevents basic request floods.  
(Not enough alone for large-scale attacks.)

**2\. Web Application Firewall (WAF)**

Blocks malicious patterns, bot traffic, and abusive API calls.

**3\. CDN & Edge Networks**

Use providers like Cloudflare/Akamai/Fastly to absorb traffic at the edge.

**4\. Traffic Filtering and Scrubbing**

Dedicated DDoS mitigation providers clean traffic before it hits your origin server.

**5\. Auto Scaling**

Automatically spins up more resources during high load.

**6\. SYN Cookies**

Helps defend against SYN flood attacks by deferring connection allocation.

**7\. Anycast Network Routing**

Distributes traffic across global servers to avoid a single point of failure.

**8\. Reverse Proxies**

Hides your actual server and absorbs malicious requests.

**Best Practices**

- Never expose origin servers directly to public internet
- Use Https + WAF for all endpoints
- Apply strict rate limits and throttling
- Use API keys or mTLS for internal systems
- Keep infrastructure patched
- Implement health checks and failover strategies

## Network and Infrastructure Security

Modern systems are increasingly distributed, cloud-native, and globally accessible. This makes the underlying network and infrastructure more exposed than ever before. Because of this expanded attack surface, securing these foundational layers is critical—not only for protecting data and services, but also for ensuring reliability, continuity, and user trust.

### Why Network Security Matters

Network security is essential because threats today come from both outside and inside your system. Understanding these risks helps you build resilient architectures capable of defending against modern attack patterns.

**External Threats**

External risks originate from attackers on the internet attempting to compromise your systems. Common examples include:

- **DDoS Attacks:** Massive volumes of traffic designed to overwhelm services and cause downtime.
- **Intrusion Attempts:** Unauthorized attempts to break into your network to steal data or disrupt operations.
- **IP Spoofing:** Attackers forge IP addresses to masquerade as trusted clients and bypass security controls.

**Internal Threats**

Internal risks can be just as dangerous as external ones:

- **Misconfiguration:** Incorrect firewall rules, open ports, and weak access controls introduce vulnerabilities.
- **Lateral Movement:** Once attackers gain entry to one part of your network, they attempt to move deeper into other systems.
- **Expanded Cloud Attack Surface:** Cloud-native environments create more entry points and require securing not just the perimeter but also internal communication and data flows.

A secure network maintains uptime, protects critical systems, and sustains user confidence. Ultimately, network security is about defending infrastructure, ensuring continuity, and safeguarding trust.

### Firewalls and Reverse Proxies

Firewalls and reverse proxies are foundational components for securing network traffic. Although they serve different roles, together they provide strong perimeter protection.

**Firewalls**

Firewalls filter incoming and outgoing traffic based on IPs, ports, and protocols.

Types of firewalls include:

- **Network-based Firewalls:** Protect entire networks at the entry point.
- **Host-based Firewalls:** Secure individual servers or devices.
- **Cloud-based Firewalls:** Native tools provided by cloud platforms to protect cloud resources.

Firewalls ensure that only legitimate traffic reaches internal systems and prevent malicious traffic from entering the network.

**Reverse Proxies**

Reverse proxies sit between users and backend servers. They route incoming requests to the correct backend services while masking the identity of those services.

Key benefits include:

- Protecting backend servers from direct exposure
- Mitigating DDoS attacks
- Providing load balancing
- Supporting SSL/TLS termination
- Offering caching capabilities

Tools like **Nginx** or **HAProxy** are common choices.

### Protecting APIs and Backend Systems

APIs form the backbone of modern architectures, making them prime targets for abuse. To secure them effectively, three essential techniques are commonly used.

**Rate Limiting**

Rate limiting controls the number of requests a client can make within a specific time window (e.g., 100 requests per minute). It protects against:

- DDoS attacks
- Brute-force attempts
- Bot abuse

**Throttling**

Throttling slows down request processing during heavy load rather than blocking it entirely. This helps systems remain available during traffic spikes by distributing load more gracefully.

**IP Filtering**

IP filtering allows or denies access based on source IP addresses through whitelists and blacklists. Only trusted IPs are permitted, which is especially useful for internal or administrative APIs.

Together, these techniques protect APIs from misuse, stabilize system performance during high-traffic events, and strengthen overall security.

### Network Segmentation and Isolation

Segmentation is one of the most effective ways to limit the impact of a breach. It divides your infrastructure into smaller, isolated zones that restrict an attacker’s ability to move laterally.

**Segmentation in Traditional Networks**

Segmentation can be implemented through:

- **DMZ (Demilitarized Zones):** For public-facing services such as web servers.
- **Internal Private Networks:** Hosting critical business applications.
- **Database Subnets:** Containing sensitive data stores.

Communication between these zones is allowed only via strict firewall rules, reducing exposure and stopping attackers from freely navigating through the network.

**Segmentation in Cloud Environments**

Cloud providers offer specialized tools for segmentation:

- **VPC (Virtual Private Cloud):** Isolated virtual networks.
- **Security Groups:** Instance-level firewalls.
- **Network ACLs:** Subnet-level traffic control.

Regardless of environment, segmentation disrupts lateral movement and increases resilience against attacks.

### The Zero Trust Security Model

Zero Trust is rapidly becoming a standard security model. Its core principle is simple:

**Never trust. Always verify.**

No user, device, or request is trusted automatically—even if it originates from inside the network.

**How Zero Trust Works**

- **Continuous Authentication and Authorization:** Every request must be verified.
- **Least Privilege Access:** Users and systems get only the permissions they absolutely need.
- **Microservices Security with mTLS:** Services authenticate each other using mutual TLS, ensuring all service-to-service communication is encrypted and verified.
- **Ongoing Validation:** Access is evaluated continuously, not just once at login.

Zero Trust applies across on-premises, cloud environments, and hybrid architectures, reducing unauthorized access and limiting the blast radius of breaches.

### Securing Cloud Environments

As organizations migrate to the cloud, understanding cloud-specific security models becomes crucial.

**Shared Responsibility Model**

Cloud security is a partnership:

- **Cloud Provider:** Secures the physical hardware, network, and infrastructure.
- **Customer:** Secures data, applications, identities, and configurations.

**Key Cloud Security Practices**

- **IAM (Identity and Access Management):** Assign roles, permissions, and enforce MFA and least privilege.
- **Encryption:** Encrypt data at rest, in transit, and even logs when necessary.
- **Audit Logging:** Track all actions for monitoring and incident analysis.
- **CSPM Tools:** Cloud Security Posture Management tools continuously scan for misconfigurations and vulnerabilities.

Strong cloud security requires constant monitoring and adherence to best practices.

### Securing Serverless and Containerized Workloads

Both serverless functions and containers have unique security needs.

**Serverless Security Practices**

- Assign **IAM roles** with minimal permissions.
- Set appropriate **timeouts and execution limits**.
- Use **API Gateways** to enforce authentication, authorization, rate limiting, and IP filtering.

**Container Security Practices**

- **Image Scanning:** Detect vulnerabilities before deployment.
- **Runtime Hardening:** Use non-root users, restrict privileges, secure filesystems.
- **Least Privilege Containers:** Provide only the minimal access required for operation.

These measures minimize risk and make compromise more difficult.

### Security in Microservices Architecture

Microservices require strong protection at the communication layer.

- **Service-to-Service Authentication:** Using JWTs or mutual TLS to verify identity.
- **API Gateways:** Handle authentication, validation, rate limiting, and routing.
- **Service Meshes:** Provide encryption, distributed policy control, and traffic monitoring.

Microservices involve many moving parts, and securing inter-service exchanges is essential for system safety.

# Chapter 12 — Observability & Monitoring

Modern distributed systems are highly dynamic and complex. Components are deployed across multiple regions, run in containers, autoscale in response to workload changes, and communicate asynchronously. In such environments, system visibility becomes essential — engineers must understand not only _what_ is happening, but _why_ it’s happening.

**Observability** is the ability to infer the internal state of a system by examining its externally measurable outputs such as logs, metrics, and traces. **Monitoring** focuses on continuously collecting and analyzing these signals to ensure system health and performance.

Together, they provide deep insight into:

- System performance and bottlenecks
- User experience and application responsiveness
- Failures, anomalies, and unexpected behaviors
- Root cause diagnosis and prevention

A well-designed observability strategy improves reliability, reduces downtime, and accelerates development velocity.

## Logging

Logging captures detailed, time-ordered records of events occurring inside a system. Logs provide diagnostic information that helps engineers understand behavior during normal operations and failures.

There are several types of logs:

- **Application Logs:** Business logic visibility, user requests, errors
- **System Logs:** OS-level activities, memory or disk errors
- **Audit Logs:** Security tracking, access records
- **Event Logs:** Operational milestones like deployment and scaling

Key logging best practices include:

- Use **structured logs** (JSON format) for easier search and parsing
- Include **contextual metadata** such as user ID, request ID, service name
- Standardize log levels: Debug, Info, Warning, Error, Critical
- Avoid sensitive data leakage (compliance: GDPR, PCI-DSS)

Logs should be centralized using tools such as:

- ELK Stack (Elasticsearch, Logstash, Kibana)
- Splunk
- Cloud-native logging services

Proper logging helps identify issues quickly and understand the execution path leading to failures.

## Metrics

Metrics represent **numerical measurements** collected over time — ideal for tracking performance trends and alerting.

Common categories:

- **System Metrics:** CPU, memory, network, disk I/O
- **Application Metrics:** Request rate (RPS), error rate (5xx), latency (p50/p90/p99)
- **Business Metrics:** Daily active users, revenue, retention

Metrics are lightweight, aggregate data streams that support:

- Capacity planning
- SLO/SLA compliance measurement
- Performance benchmarking
- Automated alerting

Popular tools include:

- Prometheus (pull-based metric scraping)
- Grafana (visualization dashboards)
- CloudWatch, Stackdriver, Datadog

High-quality metrics help maintain reliability before issues impact users.

## Tracing

Distributed tracing follows a single request as it flows through multiple services in a complex system. It enables engineers to identify precisely **where latency or failure** occurs across microservice boundaries.

Key elements include:

- **Trace:** Entire journey of a request
- **Span:** Single operation or service call within the trace
- **Correlation Id / Trace Id:** Unique identifier linking logs & metrics

## Distributed Debugging

Distributed debugging brings together logs, metrics, traces, and configuration information to diagnose issues across multiple interconnected services.

Core techniques:

- Correlating logs using trace IDs across service boundaries
- Using heatmaps and service dependency graphs
- Replay and inspection of problematic transactions
- Leveraging APM (Application Performance Monitoring) tools

Challenges addressed:

- Requests crossing dozens of microservices
- Failures triggered by remote dependencies
- Latency caused by network hops or retries

Distributed debugging transforms troubleshooting from guesswork into a **systematic process**, reducing Mean Time To Resolution (MTTR).

### Distributed Tracing

Distributed tracing is a tool for understanding how requests travel through your application in complex, cloud-native environments like microservices. Imagine it like following a detective trail for a single user request as it winds through different services and servers.

  

**What it does:**

- Tracks a single request (think detective following footprints) as it interacts with various services (think different rooms in a building).
- Tags each request with a unique identifier (think suspect photo) so you can follow its path.
- Records details like timestamps and performance metrics (think notes and clues) at each step.
- Connects the dots (analyzes the clues) to show you the complete journey of the request and identify any issues.

**Why it's important**

- **Troubleshooting:** When your app runs slow or crashes, distributed tracing helps you pinpoint the exact service causing the problem, saving you time and frustration.
- **Performance optimization:** You can see where bottlenecks are slowing down your requests and optimize your code or infrastructure accordingly.
- **Better user experience:** By understanding how user requests flow, you can ensure smooth performance and avoid frustrating delays.
- **Improved collaboration:** Different teams working on different services can see how their work affects the overall user experience, enabling better communication and teamwork.

**Think of it this way**

- Traditional monitoring is like looking at a city from afar – you see traffic jams but not the cause.
- Distributed tracing is like going down to street level and following the traffic jam to its source, allowing you to fix it.

**Benefits**

- **Reduced MTTR (mean time to repair):** Faster identification and resolution of performance issues.
- **Improved SLAs:** Consistent user experience and better compliance with service-level agreements.
- **Faster time to market:** Quicker innovation and release cycles due to efficient troubleshooting.
- **Enhanced collaboration:** Clear visibility into performance bottlenecks fosters better communication and teamwork across teams.

**Challenges:**

- **Manual instrumentation:** Some tools require code changes, adding complexity.
- **Limited coverage:** Some tools only focus on backend, omitting frontend interactions.
- **Sampling limitations:** Random sampling might miss crucial traces.

**When to use it**

- **Microservices architectures:** Essential for understanding complex interactions between services.
- **Troubleshooting performance issues:** Quickly identify bottlenecks and root causes.
- **Optimizing code:** Proactively improve performance by analyzing problematic microservices.

**Alternatives**

- **Logging:** Provides valuable data but lacks the comprehensive view of distributed tracing.
- **Centralized logging:** Aggregates logs from multiple services, but requires careful management.
- **Distributed logging:** Stores logs across the environment, reducing network load but increasing complexity.

&nbsp; 

|     |
| --- |
|     |
|     |

  

**Overall, distributed tracing is a crucial tool for observability in modern cloud-native environments. It empowers teams to troubleshoot issues faster, optimize performance, and deliver a consistent, high-quality user experience.**

OpenTelemetry has emerged as the **industry standard** for collecting traces, offering vendor-neutral instrumentation.

Tracing helps answer:

- Which service introduced latency?
- What is the slowest step in request processing?
- How do failures propagate?

Visualization tools:

- Jaeger
- Zipkin
- Tempo
- New Relic / Dynatrace

Tracing enhances debugging efficiency and improves user experience insights.

### Alerting & Dashboards

Alerting notifies the team when system behavior deviates from expected performance or reliability thresholds (SLO violations).

Effective alerts must:

- Focus on **user impact**
- Minimize noise and false alarms
- Include actionable messages

Alert types:

- **Threshold-based**: Triggered when metrics exceed limits (e.g., error rate > 2%)
- **Anomaly detection**: ML-driven pattern analysis to detect unusual spikes

Dashboards provide real-time visualization of:

- API latency
- Traffic load
- Error trends
- Resource utilization

With tools like Grafana, Datadog, and Kibana, dashboards help engineering teams maintain **operational awareness** and rapidly locate issues.

## Health Checks

Health checks verify whether components of a system are functioning properly.

Two primary types exist:

- **Liveness Check:** Is the service running?  
    Prevents deadlocks by triggering restarts.
- **Readiness Check:** Is the service ready to serve traffic?  
    Prevents routing requests to an unavailable service.

Examples:

- Database connectivity check
- Cache availability
- Dependency service responses

Health endpoints typically return lightweight HTTP status codes (200 / 500). They integrate seamlessly with orchestration platforms like Kubernetes for automated recovery.

Health checks are crucial for achieving **zero-downtime deployments** and minimizing cascading failures.

# Chapter 13 — Distributed Transactions & Idempotency

In monolithic systems, transactions were simple — a single relational database controlled operations with ACID guarantees. However, in modern distributed applications where multiple microservices and databases participate in a single business operation, maintaining correctness becomes challenging. Network delays, service failures, data replication, eventual consistency, and asynchronous messaging all introduce complexity.

Distributed transactions aim to ensure that **either all changes succeed**, or **the system gracefully recovers to a valid state** — even in the face of failure. Achieving correctness without compromising scalability is a core architectural challenge in modern system design.

This chapter explores foundational patterns that help engineering teams handle multi-service data integrity while delivering reliable, idempotent operations at scale.

## Why Distributed Transactions Are Hard

As software systems evolve from monolithic architectures to distributed microservices, the complexity of ensuring reliable business operations multiplies. In monolithic systems, a single database transaction can guarantee that all changes either succeed or fail together. However, in distributed environments, a single user action—such as placing an order—may involve multiple independent services, each with its own data store, technology stack, and failure modes.

This transition leads to a fundamental shift: **the reliability of the whole system now depends on coordination over unreliable networks**. Services must communicate across machines that can crash, timeout, or become temporarily unreachable. Even when services complete successfully, their communication channels may drop messages or deliver them multiple times. These are the laws of distributed systems, and software must be designed to tolerate these imperfections.

Because of this, **traditional ACID transactions are no longer feasible across multiple services**. There is no global lock manager, no shared transaction coordinator, and no guarantee that all participants are reachable at the same time. Instead, distributed systems must embrace _eventual consistency_: a state where data across services gradually becomes synchronized through asynchronous updates and compensating actions.

In simple terms, **distributed transactions are hard because the system cannot rely on everything working correctly at the same moment**. Failures are normal, and success must be engineered despite them.

To better understand the challenge, we must drill down into the major sources of difficulty.

### Core Challenges in Distributed Transactions

**Unreliable Networks**

Networks introduce uncertainty:

- Messages can arrive late, arrive out of order, or be duplicated.
- Sometimes a service may perform an action, but the response is lost — should the caller retry or assume success?

This leads to contradictions such as:

- “Did the action fail, or did the acknowledgment fail?”

**Independent Data Ownership**

Each microservice:

- Has its own database
- Controls its own data
- Cannot be forced into ACID compliance by another service

This eliminates the ability to enforce **global atomicity**.

**Partial Failures**

Some services may complete their part of the transaction while others fail:

1.  Payment Success
2.  Inventory Failure: Customer charged but order impossible

This can create **business correctness issues**, not just technical ones.

**Latency and Performance Constraints**

Locking resources across services (as in 2PC):

- Blocks ongoing operations
- Increases wait time and user frustration
- Doesn’t scale in high-traffic environments

Users expect instant responses — distributed coordination slows things down.

**CAP Theorem Trade-offs**

When network issues occur (which is guaranteed at scale):

- A system must choose between **consistency** or **availability**
- It cannot provide both at the same time

This means strict consistency must sometimes be sacrificed.

Distributed transactions attempt to guarantee **all or nothing** outcomes across unreliable boundaries — where **nothing is guaranteed by default**.

To succeed, modern architectures rely on:

- Compensation instead of rollback
- Asynchronous event-driven actions
- Idempotency to tolerate retries
- Durable messaging to prevent lost events

A distributed system must be designed to fail and recover continuously — without harming the business.

## Two-Phase Commit (2PC)

Two-Phase Commit (2PC) is the classical approach to ensuring atomicity across multiple databases or services. It originated from enterprise transaction systems long before microservices existed. The central principle is simple: **either every participant commits the transaction, or all of them abort**—maintaining strict consistency.

To achieve this, 2PC introduces a **transaction coordinator**, a special component responsible for orchestrating and confirming the outcome. The coordinator communicates with all involved systems and ensures that no participant commits until the entire group agrees.

2PC retains the ACID properties of traditional databases across a distributed boundary. But like all strong-consistency solutions, it comes with trade-offs in performance, scalability, and availability.

### How 2PC Works

2PC executes in two distinct steps:

**Phase 1 — Prepare (Voting Phase)**

The coordinator sends a Prepare request to each participant:

1.  Each service performs all required changes but does **not commit** them yet
2.  They lock resources involved in the transaction
3.  They respond with:
    - **YES** (if ready to commit)
    - **NO** (if something went wrong or cannot proceed)

Until the verdict arrives:

- Data remains locked
- No other transaction can modify the affected records

**Phase 2 — Commit (Decision Phase)**

Based on the responses:

- If **all say YES**, a **Commit** command is issued
- If **any says NO**, a **Rollback** command is sent
- Participants follow the final instruction and release their locks

### Real-World Use Case

Imagine a bank needs to:

- Debit **Account A** (Service A)
- Credit **Account B** (Service B)

A failure in either step must cancel the entire transaction to avoid money loss.

2PC ensures:

- Either **both accounts update**
- Or **none of them do**

### Advantages of 2PC

| **Benefit** | **Why It Matters** |
| --- | --- |
| Strong consistency | Guarantees data correctness across services |
| Atomic operations | “All or nothing” behavior preserved |
| Familiar transaction model | Useful for legacy enterprise environments |

It is still widely used in:

- Banking systems
- ERP systems
- Distributed relational DB clusters

### Limitations of 2PC

Despite its strengths, 2PC introduces critical challenges in distributed environments:

**Blocking Locks**

Participants must **hold locks** until the coordinator finalizes the decision  
→ Serious performance bottlenecks under load

**Coordinator is a Single Point of Failure**

If the coordinator crashes during commit:

- Participants remain locked
- Transaction state becomes unknown (aka **the in-doubt state**)

**Doesn’t Scale Well**

More services → More waiting → Higher latency

**Violation of Availability (CAP Theorem)**

When the network is unreliable:

- System must choose consistency over availability
- Users may see delays or failures

### Three-Phase Commit: An Improvement?

3PC extends 2PC with a timeout-based recovery mechanism.  
However:

- Still suffers in real-world failure scenarios
- Rarely used in modern cloud architectures

### Why 2PC is Rare in Microservices

Modern distributed systems prioritize:

- Availability
- Scalability
- Loose coupling

2PC:

- Couples services tightly together
- Assumes synchronous success
- Contradicts the **event-driven, eventually consistent** model

As a result:

Most microservice architectures avoid 2PC in favor of **Sagas** and **Outbox** patterns.

### When 2PC Still Makes Sense

2PC remains appropriate if:

- Number of participating services is small
- Network is fast and highly reliable
- Strong consistency outweighs performance
- All participants support XA transactions (e.g., Oracle, MS SQL clusters)

But as soon as the system spans:

- Cloud boundaries
- Mixed storage technologies
- High traffic environments

2PC becomes cost-prohibitive.

## Sagas (Choreography & Orchestration)

As distributed systems scale, **relying on a single coordinator (as in 2PC) becomes impractical. Services must operate independently, each owning its own data and success path.** To maintain correctness while embracing autonomy, modern architectures use the **Saga pattern**.

A Saga breaks a long-lived business transaction into a sequence of smaller, **local transactions**. Each step updates its service’s data and then triggers the next step, usually via events. If a step fails, the Saga does not roll everything back atomically—instead, it executes **compensating transactions** to undo the effects of previous actions.

Sagas embrace **eventual consistency**, allowing the system to remain highly available and scalable without global locks.

A Saga guarantees: **Every business process must either reach a correct final state or be actively compensated.**

### Why Sagas Exist

Microservices demand:

- Loose coupling
- Independent scaling
- Autonomous deployments
- Asynchronous communication

These benefits come at a cost: **no global transaction manager**. Sagas fill this gap by providing a **reliable coordination mechanism** without sacrificing distributed design principles.

### How a Saga Works

Example — An e-commerce order process:

1.  Create Order
2.  Reserve Inventory
3.  Charge Payment
4.  Confirm Order

If payment fails:

- Release reserved inventory
- Cancel the order
- Notify the customer

There is **no rollback** in the database sense — instead, compensation corrects business state.

### Saga Execution Models

Sagas can be executed using either **Choreography** or **Orchestration**, each with distinct trade-offs.

**Choreography (Event-Driven Sagas)**

In choreography, services collaborate using events without centralized control.

Order Service → “OrderCreated” event

↓

Inventory Service → Reserve stock → emit “StockReserved”

↓

Payment Service → Charge customer → emit “PaymentApproved”

↓

Order Service → Mark as Complete

If failure occurs:

- Services emit counter-events to run compensations  
    (e.g., PaymentFailed, ReleaseStock)

**Strengths**

- No central controller → highly resilient
- Naturally fits event-driven systems
- Simple for small transaction flows

**Weaknesses**

- Hard to understand the full workflow
- Risk of “event spaghetti”
- Debugging requires full distributed trace analysis

Best fit:

- Small teams building simple workflows
- Systems already heavily event-driven

**Orchestration (Command-Driven Sagas)**

Here, a dedicated **orchestrator** controls the flow:

Orchestrator:

1️⃣ Command → Order Service: Create order

2️⃣ Command → Inventory Service: Reserve stock

3️⃣ Command → Payment Service: Charge payment

...

The orchestrator:

- Maintains the state machine
- Handles retries
- Triggers compensations when failures occur

Popular orchestrators:

- Temporal / Uber Cadence
- Camunda
- AWS Step Functions
- Microsoft Dapr Workflows

**Strengths**

- Clear visibility into the entire transaction
- Easier monitoring, auditing, and debugging
- Central authority ensures deterministic flow

**Weaknesses**

- Orchestrator becomes critical infrastructure
- Some tight coupling to the workflow engine

Best fit:

- Complex business processes
- Regulated domains requiring auditability

### Compensation: The Core of Sagas

Compensation is more than just “undo”. It ensures **business correctness**, even when state has changed:

Example:  
Refunding a payment is not the opposite of charging — a refund may create **additional accounting events**.

Compensation requires careful design:

- Must be idempotent
- Must not assume original state exists
- Must consider external side effects

This is why understanding the domain deeply is essential when implementing Sagas.

### Saga Failure Handling

Failures are expected. Strategies include:

| **Failure Mode** | **Recovery Strategy** |
| --- | --- |
| Event not delivered | Retries + dead-letter queues |
| Partial update left behind | Compensation workflow |
| Orchestrator crash | Durable state machine storage |
| Out-of-order events | Event versioning + state guards |

Sagas don’t avoid failure —  
**they convert failure into recoverable steps**.

### When Should You Use Sagas?

Use Sagas if your system:

- Involves **multiple independent services**
- Is built around **event-driven messaging**
- Requires **eventual consistency**, not locks
- Needs **scalable, highly available** workflows

Avoid Sagas if:

- A single DB transaction can solve the problem
- Workflow is too simple to justify distributed overhead

## Outbox Pattern

In distributed and event-driven systems, data changes in a service often need to trigger messages that will be consumed by other services. A product being added to inventory may need to notify pricing services, recommendation systems, and search indexes. A user payment may need to notify order services and fraud detection.

But in a distributed world, two actions must succeed together:

1.  Persist data changes in local storage
2.  Publish an event to a message broker

If the first action succeeds and the second fails, the system breaks consistency. Conversely, if an event is published but the database write fails, downstream systems act on something that does not exist — a false reality.

This challenge is known as the **dual-write problem**.

Outbox Pattern provides an atomic solution:  
**Write changes and events together in the same transaction**, ensuring no message is ever lost.

**The Dual-Write Problem (Illustrated)**

Without Outbox:

Save Order → Success

Publish OrderCreated event → Failed

\-----------------------------------

Order is in database but other services never learn about it

System becomes inconsistent and recovery is uncertain.

Because:

- Retry might send duplicate updates
- Humans cannot detect silent failures
- Event brokers may never reconstruct lost events

This is unacceptable in reliable distributed systems.

### How the Outbox Pattern Works

The idea is straightforward:

- Store the event **inside the same database** as the business data
- Commit both modifications **atomically** as a single transaction
- A separate process later **publishes the event reliably** to messaging infrastructure

Once an event is successfully delivered, the processor marks it as **sent**.

### Key Characteristics

| **Feature** | **Value** |
| --- | --- |
| Atomicity | Business data + event stored together |
| Reliability | No event can be lost |
| Recoverability | Processor retries failed deliveries |
| Traceability | Outbox logs event history |
| Message Deduplication | Prevents duplicates on consumer |

### Outbox with Change Data Capture (CDC)

Outbox processing can happen in two ways:

| **Model** | **Description** | **Tools** |
| --- | --- | --- |
| Polling-based | Background job queries Outbox table repeatedly | Cron, worker services |
| CDC-based | Database logs tracked for inserts/updates | Debezium, Kafka Connect |

CDC-based is more efficient at scale, reducing DB polling overhead.

**Example Scenario**

**Order Service**

1.  Write order to DB
2.  Write OrderCreated event into Outbox
3.  Commit transaction

**Outbox Processor**

- Reads Outbox table
- Publishes event to Kafka
- Marks record as processed

If Kafka is temporarily unavailable:

- Event remains safely in Outbox
- Processor retries later  
    → No message is lost  
    → No data is corrupted

### Supporting Idempotency

Even reliable delivery systems occasionally retry processing. Therefore:

- Events are stored with **unique IDs**
- Consumers record processed event IDs to avoid duplicates

Example:  
Payment events must never be processed twice — Outbox supports that guarantee.

### Benefits of the Outbox Pattern

| **Benefit** | **Why it matters** |
| --- | --- |
| Event and state always in sync | Prevents ghost messages & missing data |
| Works with existing DB tech | No special distributed transaction engine |
| Makes eventual consistency reliable | No human intervention during outages |

Outbox aligns strongly with Saga execution and microservice autonomy.

### Operational Considerations

| **Consideration** | **Resolution** |
| --- | --- |
| Outbox table growth | Archival & TTL cleanup |
| Ordering guarantees | Sequence column or Kafka partitioning |
| Performance | Indexes & efficient polling |
| At-least-once delivery | Required for reliable processing |

### When to Use Outbox Pattern

Use the Outbox Pattern if:

- A service updates local data **and emits events**
- Message delivery failures cannot be tolerated
- You want **event-driven architecture without global transactions**

Avoid if:

- System is not event-driven
- Centralized database already supports atomic triggers (rare at scale)

## Idempotent APIs

Idempotent APIs are a critical design principle in distributed systems that ensures **reliability**, **consistency**, and **fault tolerance**. An operation is considered _idempotent_ when performing it multiple times produces the **same result** as performing it once.

In simple terms:

_Even if a request is sent repeatedly (due to retries, timeouts, or network issues), the outcome must not change after the initial successful execution._

### Why Idempotency Matters in Distributed Systems?

Distributed systems are inherently unreliable. Messages can:

- Arrive late
- Be duplicated
- Be processed more than once
- Fail midway due to network or server crashes

Retries are inevitable — and without idempotency, retries can lead to:

| **Problem** | **Example** |
| --- | --- |
| Duplicate operations | Customer charged twice |
| Multiple resource creation | Same order created with multiple references |
| Data corruption | Quantity or balance repeatedly decremented |
| Inconsistent state | Eventual failure of downstream services |

Idempotency ensures that **operations remain safe under retries**, providing **exactly-once effect** at the API contract level.

### Idempotent vs. Non-Idempotent HTTP Methods

| **HTTP Method** | **Idempotent?** | **Why** |
| --- | --- | --- |
| **GET** | Yes | Reads do not change state |
| **PUT** | Yes | Replaces a resource with the same value always results in same state |
| **DELETE** | Yes | Deleting the same resource repeatedly is still “deleted” |
| **POST** | No (by default) | Creates new resources → duplicates possible |
| **PATCH** | Usually No | Partial modifications may stack on retries |

**POST needs special handling** if retries are allowed.

### How API Requests Get Duplicated?

Common scenarios:

- Client retry logic due to timeouts
- Network instability causing retransmissions
- Message brokers delivering duplicate messages
- API gateway retry policies
- Human behavior (double clicks on UI)

### Idempotency Strategies

**1️⃣ Idempotency Keys**

Client sends a **unique key** with the request (e.g., Idempotency-Key: 9df91ab3-...)

Server:

- Stores key + response result
- If the same key appears again → return **stored response**

Ideal for **payment, order creation, and booking systems**.

**Example:**

POST /orders

Idempotency-Key: 12345

{ "productId": "P1", "qty": 1 }

Second retry returns:

HTTP 200 OK

{ "orderId": "O9876", "status": "Confirmed" }

**2️⃣ De-duplication in Database**

Use unique constraints:

- Unique primary key (e.g., Order ID)
- Unique index on business identifier

Duplicate insert → fails safely.

**3️⃣ Operation Status Tracking**

Maintain **state transition logs** to avoid applying same updates twice.

Example: updating order status only if current state allows transition.

**4️⃣ Token-based or Version-based Idempotency**

Optimistic concurrency control using:

- ETags
- Row version numbers
- Conditional updates

Example:

PUT /inventory/10

If-Match: "v3"

Ensures only **one** valid successful update.

### Idempotency in Event-Driven Architecture

When events are processed by asynchronous consumers:

- Use an **Outbox table** with deduplication
- Maintain a **processed events store** keyed by event ID
- Consumers check before replaying operations

Ensures **at-least-once delivery** does not cause **at-least-twice execution**.

**Example: Idempotent Payment Service**

| **Event** | **Result** |
| --- | --- |
| First charge request arrives | Customer charged once |
| Retry due to timeout | Return previous response — **no extra charge** |

Banking regulations make idempotency **mandatory** to prevent double-charging.

**Benefits**

| **Advantage** |
| --- |
| Protects against duplicate operations |
| Ensures correctness under retries |
| Enhances user trust |
| Simplifies recovery from failures |
| Makes services safe for distributed systems |

### When to Use Idempotency?

✔ Recommended for:

- Payments / Charges
- Order/Reservation creation
- Shipping & logistics tracking
- Inventory deduction
- Email or notification sending
- Workflow state transitions

✖ Not required for:

- Analytics logs
- Stream processing without state modification

## Exactly-Once Processing Strategies

One of the greatest challenges in distributed systems is ensuring that messages or operations are processed **exactly once** — no duplicates, no omissions. While “exactly-once” sounds simple, achieving it is extremely complex because distributed systems behave unpredictably:

- Messages may be delivered **more than once**
- Operations may partially execute and fail
- Network failures cause retries
- Consumers may crash after processing but before acknowledgment

Due to these realities, messaging systems like Kafka, RabbitMQ, and Azure Service Bus typically guarantee:

- **At-Most-Once delivery** → no duplicates, but loss is possible
- **At-Least-Once delivery** → no loss, but duplicates are possible

Achieving **Exactly-Once Processing** means ensuring:

_Duplicates may arrive, but only one processing attempt will have an effect on the final system state._

**🔹 Key Challenges**

| **Challenge** | **Example** |
| --- | --- |
| Duplicate message redelivery | Service retries after timeout |
| Consumer crash after execution | Order placed but acknowledgment lost |
| Side-effects applied before commit | Inventory reduced but no event logged |
| Lack of atomic operations across services | Split writes cause inconsistencies |

Exactly-once guarantees require **coordination** between message brokers, processing logic, and state storage.

### Common Exactly-Once Processing Strategies

**1️⃣ Idempotent Operations**

Ensure processing the same operation multiple times produces **no side effects** after the first execution.

Examples:

- Payment service using idempotency keys
- Inventory system only deducting once per unique order ID

“Exactly-once” becomes “At-least-once + Idempotency”.

**2️⃣ Message De-duplication**

Track processed messages using a **deduplication store**.

Implementation Approaches:

| **Dedup Method** | **How It Works** |
| --- | --- |
| Message ID Store | Store unique message IDs in DB/Cache and reject duplicates |
| Unique Key Constraint | DB prevents repeated inserts (e.g., same order ID) |
| Hashing Payload | Detect duplicate data payloads |

Storage TTL helps avoid infinite growth.

**3️⃣ Outbox Pattern (Transactional Messaging)**

Ensures database write and message publication are **atomic**.

Steps:

1.  Write business data + event record in the **same DB transaction**.
2.  A separate **outbox processor** publishes events to the broker.
3.  Consumers deduplicate based on **event ID**.

Guarantees:

- No message loss
- No duplicate side-effects

This is the most **widely adopted** strategy.

**4️⃣ Consume-Transform-Produce Pattern with Atomic Commit**

Used in Kafka Streams & transactional event processing:

- Consume from topic A
- Process transformation
- Produce results to topic B
- Commit offset only when **all writes succeed**

Ensures:

Event processing and offset commit happen **as one atomic action**

Supported by:

- Kafka Transactions: **EOS (Exactly-Once Semantics)**
- Flink, Spark Structured Streaming

**5️⃣ Two-Phase Commit (2PC) _(Not recommended today)_**

Coordinator ensures all participants commit or rollback together.

Why it’s rarely used:

- Complex
- Slow (blocking)
- Coordinator is a single point of failure
- Not cloud-native

Used only when **strong consistency overrides availability**.

### Combining Strategies for Strong Guarantees

In practice, **multiple techniques** are combined:

| **Technique** | **Prevents** |
| --- | --- |
| At-Least-Once Delivery | Message loss |
| Idempotency | Side-effect duplication |
| Deduplication Store | Double execution of logic |
| Outbox Pattern | Missing or duplicated event publication |

Exactly-Once Processing =  
**At-Least-Once Delivery + Idempotent Handlers + Deduplication Logic**

**✨ Example: Exactly-Once Payment Processing**

Workflow:

1.  User pays → message sent to queue
2.  Payment service processes message
3.  Use **Idempotency Key** to ensure only one debit
4.  Store key in DB (**Dedup store**)
5.  Generate PaymentSuccess event into **Outbox**
6.  Publish event once outbox processing succeeds

Even with retries:

- Only **one debit**
- Only **one PaymentSuccess event**
- Downstream systems remain consistent

# Chapter 14 — Deployment, DevOps & CI/CD

The chapter begins by exploring **deployment challenges** in distributed systems — such as dependency management, configuration drift, and environment inconsistencies. It then introduces **Continuous Integration (CI)** as the foundation for automated building and testing of every change before integration. CI reduces merge conflicts, increases code quality, and delivers faster feedback to developers.

We then expand into **Continuous Delivery and Deployment (CD)**, enabling software to always remain in a deployable state. Automation pipelines orchestrate compilation, containerization, security scanning, artifact management, infrastructure provisioning, and staged rollout strategies — ensuring smooth and safe promotions from development to production environments.

Furthermore, the chapter highlights how **Infrastructure as Code (IaC)** tools like Terraform, Ansible, Helm, and Kubernetes redefine deployment — treating infrastructure as version-controlled software. This greatly improves reproducibility, disaster recovery capability, and operational agility.

The chapter also covers **progressive delivery techniques** including canary releases, blue-green deployments, and feature flags, all designed to minimize risk when rolling out new functionality. Finally, we consolidate all concepts into real-world DevOps architecture patterns — integrating monitoring, rollback logic, automated remediation, and secure supply-chain workflows.

## Containers

Modern software systems demand environments that are portable, fast to deploy, and consistent across machines — from a developer’s laptop to cloud production clusters. Traditional deployment models using virtual machines struggled with resource waste, configuration drift, and slow provisioning. **Containers** emerged as the solution.

### The bad old days

&nbsp;Applications run businesses. If applications break, businesses break. Sometimes they even go bust. These statements get truer every day! Most applications run on servers. And in the past, we could only run one application per server. **The open-systems world of Windows and Linux just didn’t have the technologies to safely and securely run multiple applications on the same server.** Every time the business needed a new application, IT would go out and buy a new server. And most of the time nobody knew the performance requirements of the new application! This meant IT had to make guesses when choosing the model and size of servers to buy. As a result, IT did the only thing it could do — it bought big fast servers with lots of resiliency. After all, the last thing anyone wanted, including the business, was under-powered servers. Under-powered servers might be unable to execute transactions, which might result in lost customers and lost revenue. So, IT usually bought big. This resulted in huge numbers of servers operating as low as 5-10% of their potential capacity. A tragic waste of company capital and resources.

### VMware

Amid all of this, VMware, Inc. gave the world a gift — the virtual machine (VM). And almost overnight, the world changed into a much better place! **We finally had a technology that would let us safely and securely run multiple business applications on a single server.** Cue wild celebrations! This was a game changer! IT no longer needed to procure a brand new oversized server every time the business asked for a new application. More often than not, they could run new apps on existing servers that were sitting around with spare capacity. All of a sudden, we could squeeze massive amounts of value out of existing corporate assets, such as servers, resulting in a lot more bang for the company’s buck ($).

But… and there’s always a but! As great as VMs are, they’re far from perfect! The fact that **every VM requires its own dedicated OS is a major flaw**. Every OS consumes CPU, RAM and storage that could otherwise be used to power more applications. Every OS needs patching and monitoring. And in some cases, every OS requires a license. All of this is a waste of op-ex and cap-ex. The VM model has other challenges too. VMs are slow to boot, and portability isn’t great — migrating and moving VM workloads between hypervisors and cloud platforms is harder than it needs to be.

### Containers

A **container** is a lightweight, isolated runtime environment that packages an application along with its dependencies — libraries, runtime, configuration — ensuring that software behaves **exactly the same** regardless of where it runs. Unlike virtual machines, containers do not bundle an entire operating system; they share the host OS kernel, making them faster, smaller, and significantly more efficient. **The Container is a wrapper of system process.**

##### Windows containers vs Linux containers

&nbsp;It’s vital to understand that a running **container shares the kernel of the host machine it is running on. This means that a containerized app designed to run on a host with a Windows kernel will not run on a Linux host.** This means that you can think of it like this at a high level — Windows containers require a Windows Host, and Linux containers require a Linux host. However, it’s not that simple… At the time of writing, it is possible to run Linux containers on Windows machines. For example, Docker for Windows (a product offering from Docker, Inc. designed for Windows 10) can switch modes between Windows containers and Linux containers. This is an area that is developing fast and you should consult the Docker documentation for the latest. 

## Docker

**Docker is software that runs on Linux and Windows kernels. It creates, manages and orchestrates containers.** The software is developed in the open as part of the Moby open-source project on GitHub.

**Docker uses a client-server architecture.** The Docker client talks to the Docker daemon, which does the heavy lifting of building, running, and distributing your Docker containers. The Docker client and daemon can run on the same system, or you can connect a Docker client to a remote Docker daemon.

  

When you install Docker, you get two major components:

- The Docker client.
- The Docker daemon (sometimes called “server” or “engine”).

The Docker Engine is the infrastructure plumbing software that runs and orchestrates containers. **The Docker Engine is the core container runtime that runs containers.**

### Docker Architecture

Docker’s architecture is composed of several core components:

| **Component** | **Purpose** |
| --- | --- |
| **Docker Engine** | Core runtime that builds and runs containers |
| **Docker Daemon** | Background service managing containers |
| **Docker CLI** | Developer interaction layer |
| **Docker Images** | Immutable templates for creating containers |
| **Docker Containers** | Running instances of images |
| **Docker Registry** | Stores and distributes images (e.g., Docker Hub, ECR, ACR) |

By separating **immutable images** from **ephemeral containers**, Docker enables predictable deployments and easy rollback strategies.

### Images

&nbsp;It’s useful to think of a **Docker image as an object that contains an OS filesystem and an application**. If you work in operations, it’s like a virtual machine template. An image contains enough of an operating system (OS), as well as all the code and dependencies to run whatever application it’s designed for.

Images are made up of multiple layers that get stacked on top of each other and represented as a single object. Inside of the image is a cut-down operating system (OS) and all of the files and dependencies required to run an application. Because containers are intended to be fast and lightweight, images tend to be small. As a result, images and layers are immutable, and we can easily identify any changes made to either.

#### Dockerfile

**Dockerfile containing instructions on how to build the app into a Docker image.** Use the **_docker image build_** command to create a new image using the instructions in the Dockerfile.

The build process used by Docker has the concept of a cache. The best way to see the impact of the cache is to build a new image on a clean Docker host, then repeat the same build immediately after. The first build will pull images and take time building layers. The second build will complete almost instantaneously. This is because artefacts form the first build, such as layers, are cached and leveraged by later builds.

s we know, the docker image build process iterates through a Dockerfile one-line at-a-time starting from the top. For each instruction, Docker looks to see if it already has an image layer for that instruction in its cache. If it does, this is a cache hit and it uses that layer. If it doesn’t, this is a cache miss and it builds a new layer from the instruction. Getting cache hits can hugely speed up the build process.

#### Lifecycle of a Container

1.  Developer writes Dockerfile
2.  Docker **builds** an image
3.  Image is **pushed** to a registry
4.  Environments **pull** the image during deployment
5.  **Containers** are launched from that image

The result: **immutable deployments**, eliminating configuration drift.

### Docker Compose

Deploying and managing lots of services can be hard. This is where Docker Compose comes in to play. Instead of gluing everything together with scripts and long docker commands, Docker Compose lets you describe an entire app in a single declarative configuration file. You then deploy it with a single command. Once the app is deployed, you can manage its entire lifecycle with a simple set of commands. You can even store and manage the configuration file in a version control system! 

Compose uses YAML files to define multi-service applications. YAML is a subset of JSON, so you can also use JSON. However, all of the examples in this chapter will be YAML. The default name for the Compose YAML file is docker-compose.yml. However, you can use the -f flag to specify custom filenames.

**Using docker compose, we can deploy multiple isolated environments like dev and test into docker.**

## Kubernetes Basics

As software scales into dozens or hundreds of microservices, managing containers manually becomes error-prone and operationally expensive. **Kubernetes** (often abbreviated as _K8s_) is the industry-standard **container orchestration platform** designed to automate:

- Deployment
- Scaling
- Networking
- Self-healing
- Configuration and secrets management

Kubernetes shifts infrastructure management to **Declarative Desired State**:

“Tell Kubernetes _what_ state you want — it figures out _how_ to maintain it.”

### Kubernetes Core Building Blocks

| **Concept** | **Description** |
| --- | --- |
| **Pod** | Smallest deployable unit; one or more tightly-coupled containers |
| **Deployment** | Manages Pod lifecycle, scaling, rolling updates |
| **Service** | Stable network endpoint exposing Pods |
| **ConfigMap** | Stores non-secret configuration |
| **Secret** | Stores credentials, tokens — base64-encoded |
| **Ingress** | External HTTP/S routing to internal Services |
| **Node** | Worker host (VM or physical) running Pods |
| **Cluster** | Group of Nodes managed by a control plane |

### Key Self-Healing Capabilities

- Automatically restarts failed containers.
- Reschedules workloads if Nodes crash.
- Removes unhealthy Pods from load balancing.

This makes Kubernetes foundational to **Cloud-Native Reliability Engineering**.

Companies use K8s for:

- Auto-scaling based on CPU/memory/custom metrics.
- Rolling upgrades without downtime.
- Efficient and secure multi-tenancy using namespaces and RBAC.
- Hybrid and multi-cloud flexibility.
- Managing and distributing workloads across multiple Nodes in a cluster.

## CI/CD Pipelines

**Continuous Integration and Continuous Delivery/Deployment** (CI/CD) automate software delivery from code commit to production release.

### Continuous Integration (CI)

Focuses on _integrating changes quickly and safely_:

- Every commit triggers automatic builds.
- Automated testing enforces quality.
- Prevents merge hell and environment drift.

CI establishes that code is **always in a workable state**.

### Continuous Delivery / Deployment (CD)

Not just integration — **automated promotion** to environments:

| **Practice** | **Deployment Trigger** | **Target** |
| --- | --- | --- |
| **Continuous Delivery** | Manual approval | Staging/Prod |
| **Continuous Deployment** | Fully automated | Direct to Production |

CD pipelines typically include:

- Build → Test → Security Scans → Containerization
- Push artifacts to registries
- Deploy to Kubernetes or cloud environments
- Progressive delivery + auto rollback

**Benefits**

| **Category** | **Gain** |
| --- | --- |
| Speed | Faster release cycles |
| Safety | Fewer human errors |
| Confidence | Automatic testing + rollback |
| Collaboration | Dev + Ops feedback loop |

CI/CD is the backbone of modern DevOps — turning deployments into **routine events**, not emergencies.

### Blue-Green & Canary Deployments

Deployments historically involved taking systems offline, leading to downtime and rollback complexity. **Progressive delivery** techniques solve this elegantly.

Blue-Green Deployment

Two identical environments:

- **Blue** → Current production
- **Green** → New version

Switch traffic from Blue → Green instantly once validated.

- Near-zero downtime.
- Instant rollback (just switch back)

Canary Deployment

Traffic is shifted gradually:

1.  Deploy new version to small % (canary)
2.  Monitor performance metrics
3.  If healthy → Increase traffic
4.  If issues → Roll back automatically

- Lower risk.
- Real user traffic testing.
- Faster issue detection.

Choosing Strategy

| **Factor** | **Blue-Green** | **Canary** |
| --- | --- | --- |
| Risk | Medium | Very Low |
| Rollback | Instant | Instant |
| Infra Cost | High | Medium |
| Traffic Levels | Full switch | Gradual |

Canary = Continuous improvement  
Blue-Green = Rapid safe replacement

### Infrastructure as Code (Terraform, CloudFormation)

Running systems manually using cloud consoles leads to:

- Configuration drift
- Unreliable recovery
- Environment inconsistencies

**Infrastructure as Code (IaC)** solves this by managing infrastructure using **version-controlled code**.

Benefits:

- Repeatability
- Disaster recovery
- Peer review + automated checks
- Faster provisioning
- Parameterized environments (Dev, QA, Prod)

Terraform

A **multi-cloud IaC** tool from HashiCorp:

- Works with AWS, Azure, GCP, Kubernetes, databases, SaaS, etc.
- Desired-state model (Declarative)
- Maintains a **state file** to track resources

Terraform == Cloud-Agnostic Portability

AWS CloudFormation

A native AWS IaC service:

- Deep integration with AWS services
- YAML/JSON templates
- Automated rollback & drift detection

CloudFormation == AWS-Optimized Control

# **Section 2:** System Design Challenges and Solutions

This section focuses on real-world system design problems that arise when building scalable, reliable, and secure applications. We explore key architectural decisions, trade-offs, and patterns used to design systems that handle millions of users while maintaining high performance. Topics include distributed system challenges such as load balancing, data consistency, caching strategies, fault tolerance, and microservices communication. Through practical scenarios and design walkthroughs, we examine how to identify bottlenecks, choose the right technologies, and structure systems that can scale effectively. This section equips you with the skills to approach system design questions confidently in both engineering and interview environments.

# Chapter 15 — Distributed Counter System

In large-scale digital applications, the ability to track user interactions in real time is critical to delivering personalized experiences, maintaining system integrity, and analyzing product performance. Whether counting page views, video watch time, likes, rate-limit tokens, quota usage, or feature-flag exposures—counters form the backbone of many essential platform capabilities.

However, tracking counters appears deceptively simple — increment a value when an event occurs. At internet scale, this becomes a complex distributed system problem. Modern applications generate billions of events across globally distributed clients, each requiring low-latency writes and high availability. Maintaining consistency, accuracy, and durability across these events introduces several engineering challenges.

The **Distributed Counter Problem** emerges from this need — how to design a highly available, fault-tolerant system that can handle extreme write throughput while preserving correctness guarantees appropriate for the use case.

## Overview

Modern applications generate massive amounts of real-time activity—views, likes, clicks, impressions, purchases, sensor readings, and API calls. Tracking these interactions requires a counting system that can keep up with millions of updates per second across globally distributed users. Traditional single-node counters cannot handle this scale due to write bottlenecks, high contention, and latency.

Additionally, businesses need accurate, up-to-date counts for analytics, rate limiting, billing, personalization, leaderboards, and usage monitoring.

Different counters require different guarantees:

|     |     |     |     |
| --- | --- | --- | --- |
| Counter Type | Use Case | Consistency Model | Example |
| Exact Counter | Quotas, billing, inventory | Strong | Remaining SMS credits |
| High-Precision Real-time | Engagement metrics | Strong/Efficient Conflict-Free | Video watch count |
| Approximate Counter | Analytics, rate-limits | Eventual | Page view count |
| Windowed Counter | Sliding rate limits | Bucketed time windows | API usage per minute |

They also often retain event data for audits or reporting (e.g., 90-day retention), which demands scalable storage and efficient aggregation.

These needs collectively drive the requirement for a **distributed counter system** that can scale horizontally, handle high concurrency, and support global workloads.

## Requirements

The requirements for the Distributed Counter System are divided into two major categories: Functional Requirements and Non-Functional Requirements.

### Functional Requirements

- The system must allow clients to create counters dynamically with unique counter IDs.
- Counters may represent metrics such as views, likes, quotas, rate-limit tokens, etc.
- Counters must support increment, decrement (optional for some types), and get current count operations.
- The read operations must return the latest counter value.
- Support querying historical windows for analytics (optional based on business plan).

**Out of Scope Requirements**

- Authentication and Authorization for users.
- Analytics features.
- Monetization features.

### Non-Functional Requirements

- Daily Active Counters: 1 billion
- Total Increments Per Day: 50 billion
- Average Write Throughput (Increments/sec): ~580,000 ops/sec
- Peak Write Throughput: ≥ 1,000,000 ops/sec
- Read : Write Ratio: 1 : 20 (write-heavy)
- Historical Retention: 90 days (configurable per counter)
- Hot Counters Read Latency: P95 < 10 ms
- Must detect and block malicious or spam activities
- Must enforce strong access controls and maintain detailed audit logs
- Must support **zero-downtime deployments**
- Must provide full observability (logs, metrics, traces, proactive alerts)
- Must comply with all organizational and regulatory data-retention policies

## Design Considerations

**The Design Considerations** section outlines the architectural strategy and technical decisions needed to ensure that the Distributed Counter System meets its performance, scalability, and correctness requirements at global scale.

These considerations include counter replication models, aggregation strategy, consistency guarantees, storage hierarchy, fault tolerance, and system adaptability.

A primary design challenge is to support massively concurrent writes while maintaining correctness, especially for globally distributed users.

### Data Storage and Retention

A average database record required 132 bytes **(event_id,counter_key, delta, created_at)** for counter event and 110 bytes **(counter_key, value)** for counter.

Daily space required for counter:

1,000,000,000 × 110 bytes

\= 110,000,000,000 bytes

\= 110 GB (approx)

counter rows for a year → multiply **110 GB × 365 = 40,150 GB = 40.15 TB**

Daily space required for counter events:  
50,000,000,000 × 132 bytes

\= 6,600,000,000,000 bytes

\= 6.6 TB (approx)  

We need to retain events for 90 days

6.6 TB/day × 90 days

\= 594 TB

Final storage required for a year  
594 TB + 40.15 TB ≈ 634.15 TB

**Caching Strategy**

Since this is a write-through cache, the cache stores the current value of the most frequently accessed counters.

Access distribution follows Pareto 80/20

- 20% counters receive 80% of traffic
- 5% counters receive 50% of traffic
- 1% counters receive 20% of traffic

Top 5% = **50 million counters**

50,000,000 × 150 bytes = 7,500,000,000 bytes

≈ 7.5 GB

**Eviction Policy**

The cache employs the **Least Recently Used (LRU)** strategy with optional key expiration:

- Frequently accessed URLs remain in memory
- Least recently used or expired keys are automatically evicted as memory fills
- This ensures efficient memory utilization and consistent cache performance

### Security and Abuse Protection

- Rate limiting on increment operations to avoid system overload
- Data encrypted in transit and at rest
- Monitoring for suspicious counter surges or replay attacks

### Solution Approaches

The Solution Approaches section presents multiple strategies to design and implement a distributed counter. Each approach trades off accuracy, latency, scalability, operational complexity, and cost. Choose an approach based on the counters’ criticality (billing/SLAs vs. metrics/analytics), required accuracy (exact vs. approximate), and latency/SLA targets.

Approach 1: Single-Source Exact Counter (Strongly Consistent DB)

**Overview**

All increments/decrements hit a single authoritative store (RDBMS or strongly-consistent KV) that performs atomic updates.

**Key Update Process**

1.  Client/service sends increment request to counter API.
2.  API routes request to authoritative DB node (or leader in a cluster).
3.  DB performs atomic update (e.g., UPDATE counters SET val = val + 1 WHERE id = X RETURNING val).
4.  API returns updated value.

**Advantages**

- Exact counts at all times (strong consistency).
- Simple semantics and easy to reason about (no reconciliation).
- Good for small scale or billing/financial counters that cannot tolerate drift.

**Disadvantages**

- Single-point throughput/latency bottleneck; poor horizontal write scalability.
- High contention on hot keys; locking and latency under heavy writes.
- Poor geo latency for global users unless leaders are geo-distributed (adds complexity).

**Best Fit**

Billing, payments, quotas, or any counter that **must be exact** and where write QPS is moderate.

Approach 2: Sharded Counters with Periodic Aggregation

**Overview**

Split each counter into many shards (by time window, node ID, or hash). Each shard is updated independently; global count = sum(shards). Periodic aggregation compacts shards into a canonical counter.

**Key Update Process**

1.  API chooses a shard ID (e.g., counterId:shardNodeId or counterId:YYYYMMDD:node) and performs local increment (fast, low contention).
2.  Shard updates are stored in low-latency stores (Redis or local DB).
3.  Background job or stream processor periodically sums shards and writes aggregated value to long-term store and compacts older shards.

**Advantages**

- High write throughput (parallelize across shards).
- Low contention on hot counters.
- Simple correctness model (sum of shards = exact value when all shards accounted).

**Disadvantages**

- Reading exact global value requires reading/aggregating shards (extra cost) or relying on aggregated value delay.
- Aggregation windows introduce near-real-time lag (depending on flush interval).
- Requires shard lifecycle and compaction logic.

**Best Fit**

High-throughput event counters where **eventual exactness** is acceptable (e.g., analytics, dashboards, leaderboard systems that can tolerate small delays).

Approach 3: CRDT-Based Counters (G-Counter / PN-Counter)

**Overview**

Use Conflict-free Replicated Data Types (CRDTs) where each node keeps local deltas; merges are commutative/associative so global state converges without coordination.

**Key Update Process**

1.  Each node increments its local component of a G-Counter (a map nodeId→count).
2.  Nodes exchange states (anti-entropy/ gossip) or send deltas to aggregator.
3.  Merge operation is element-wise max/sum depending on type; aggregated sum is final count.

**Advantages**

- No coordination required for updates; tolerant to partitions.
- Convergent and eventually consistent with bounded conflict semantics.
- Good for geo-distributed systems needing local writes.

**Disadvantages**

- State size grows with number of replicas (need compaction).
- Merging frequency controls staleness.
- Harder to support decrements (PN-counters add per-node negative components).
- Not suitable where strict, immediate exactness is required.

**Best Fit**

Globally-distributed, highly-available meters where local write availability is critical and **eventual convergence** is acceptable.

Approach 4: Approximate Counters (Count-Min Sketch / Probabilistic)

**Overview**

Use probabilistic data structures (Count-Min Sketch, HyperLogLog for uniques) to estimate frequencies with bounded error while using small memory.

**Key Update Process**

1.  On increment, update the sketch data structure (update multiple hash buckets).
2.  Query returns approximate count with error bound (determined by sketch width/depth).
3.  Periodically persist sketches or merge sketches from multiple nodes.

**Advantages**

- Extremely memory efficient for high-cardinality counts.
- Fast updates and merges; natural fit for streaming/aggregated analytics.
- Good for approximate metrics, anomaly detection, and cardinality estimates.

**Disadvantages**

- Returns approximate counts with quantifiable error (no exact guarantees).
- Not usable for billing, strict quotas, or correctness-critical counters.
- Requires careful parameter tuning (width/depth) for acceptable error.

**Best Fit**

Analytics dashboards, trend detection, approximate ranking, and unique-user estimates where small error is acceptable.

Approach 5: Streaming Event Log + Aggregate (Kafka + Stream-Processor)

**Overview**

Treat every increment as an append-only event into a durable log (Kafka). Use stream processors (Flink, Kafka Streams, Spark Streaming) to compute aggregates in real-time and store materialized views.

**Key Update Process**

1.  API appends increment event {counterId, delta, ts} to the event topic.
2.  Stream processor consumes the topic, increments its local state store for the counter (sharded), and writes aggregated snapshots to persistent store (Cassandra, ClickHouse, Timescale).
3.  Materialized view provides near-real-time read access; historical events retained for replay/reconciliation.

**Advantages**

- Durable, auditable event trail (replayable).
- Seamless horizontal scaling and reprocessing for fixes/backfills.
- Good throughput and real-time aggregation.
- Supports many derived views (time windows, rollups).

**Disadvantages**

- Operational complexity (message broker, stream infra).
- Slight read latency depending on processing time; eventual consistency.
- Need for exactly-once semantics or idempotent processing to avoid over-counts.

**Best Fit**

High-throughput analytics/metrics pipelines where durability, reprocessing, and flexible rollups are required (e.g., telemetry, monitoring, feature pipelines).

Approach 6: Cache-Backed Counters with Write-Through / Write-Behind

**Overview**

Use an in-memory counter store (Redis, Memcached) for low-latency increments, backed by durable storage via write-through or batched write-behind.

**Key Update Process**

1.  Increment in Redis via atomic INCR/INCRBY for low-latency updates.
2.  Synchronously (write-through) or asynchronously (write-behind/batch) persist deltas to durable store (Cassandra, RDBMS).
3.  Reconciliation jobs apply missing deltas if persistence failed.

**Advantages**

- Extremely low latency for updates and reads.
- Atomic operations in Redis solve contention for many workloads.
- Flexible persistence options (immediate vs batched) to optimize cost/latency.

**Disadvantages**

- Asynchronous persistence can lead to data loss unless Redis is persisted/replicated and write-behind is reliable.
- Requires careful design for durability, failover, and replay on crashes.
- Hot keys can still overwhelm a single Redis instance; need sharding or cluster.

**Best Fit**

Low-latency counters (caches, feature flags, UI counts) where small window of potential loss is acceptable or where Redis persistence/replication policies mitigate risk.

Approach 7: Edge/Client-Side Local Aggregation + Reconciliation

**Overview**

Aggregate frequent local events at the edge (mobile device, CDN edge) into compact summaries and periodically flush to central system to reduce write amplification.

**Key Update Process**

1.  Edge node accumulates local increments into small batches or deltas.
2.  Periodically send batched delta to central ingestion endpoint (or append to event log).
3.  Central system merges deltas and updates aggregates.

**Advantages**

- Reduces network and API load for very high-frequency events.
- Improves perceived latency and saves bandwidth.
- Works well with intermittent connectivity (mobile).

**Disadvantages**

- Adds staleness and potential double-counting due to retries (needs idempotency).
- More complex client logic; device storage constraints.
- Not suitable for counters needing immediate consistency.

**Best Fit**

Mobile analytics, IoT telemetry, and edge-captured metrics where reducing write amplification matters.

Selected Approach — Hybrid (Sharded Local Counters + Streaming Aggregation + Exact Path for Critical Counters)

**Overview (Recommended)**

Adopt a hybrid architecture that combines the strengths of sharding, streaming, CRDTs, and durable logging:

- **Primary write path (high-throughput metrics):** API increments a local shard stored in Redis (or local in-memory), and emits an event to Kafka.
- **Streaming layer:** A stream processor consumes events, keeps materialized aggregates (per minute/hour/day shards), and writes aggregated snapshots to a durable, horizontally scalable store (Cassandra/ClickHouse).
- **CRDT/anti-entropy for global availability:** For geo-distributed writes that must be available locally, use CRDT deltas with anti-entropy to converge (for non-critical counters).
- **Exact-critical path:** For counters that must be exact (billing/quotas), route updates to a leader-coordinated shard or a strongly-consistent DB with sharding and rate limiting. Periodic reconciliation between exact store and aggregated stream ensures correctness.
- **Reads:** Serve real-time reads from Redis or the materialized view; fallback to aggregated store for historical queries.
- **Durability & Replay:** All increments are present in Kafka for replay, backfill, and audit.

**Why this hybrid?**

- **Scales writes horizontally** via sharding and stream-parallelism.
- **Provides low-latency reads/writes** via Redis/local shards.
- **Preserves an auditable event log** (Kafka) for replay and correction.
- **Supports both exact and approximate use-cases** by isolating critical counters into exact path while handling the rest via aggregate/CRDT methods.
- **Fault-tolerant and geo-friendly**: local writes + anti-entropy reduce cross-region latency and tolerate partitions.

**Drawbacks**

- Higher operational complexity (must run Redis cluster, Kafka, stream processors, and durable stores).
- Needs robust exactly-once or idempotent processing to avoid double counts.
- Requires monitoring and reconciliation pipelines to detect/repair divergence.

**Best Fit**

Large-scale internet services with mixed counter requirements: millions of events/sec, a mix of analytics counters and a small set of correctness-critical counters (billing, rate-limits, quotas).

**Multi-Region Active-Active Design**

- Every region maintains its local shard writer
- Nodes use gossip or anti-entropy protocols for reconciliation
- System remains operational even when regions become isolated
- All increments are append-only events persisted to the stream
- Consumers maintain idempotency using unique event IDs
- On restart → full rebuild via event replay

## High-level Architecture (components & flow)

**Flow:**

1.  Region A generates event E1 (+5)
2.  Saves to local DB
3.  Publishes E1 to global bus
4.  Regions B, C, D also consume E1 and apply it
5.  All regions’ counters eventually match

Idempotency guaranteed by event_id PK in every region.

## Database Design

A **horizontally scalable NoSQL DB** (e.g., Cosmos DB with partition keys, or DynamoDB) with optional Redis caching for hot counters.

**Counter Table — (counters)**

|     |     |     |     |
| --- | --- | --- | --- |
| Column | Type | Nullable | Description |
| counter_key | STRING | No  | Primary key, Logical counter name (e.g., page_view, likes) |
| value | BIGINT | No  | Current value of the counter |

**Partitioning & Indexing:**

- Partition key: counter_key
- Index: counter_key for fast reads

**Counter Events Table — (counter_events)**

|     |     |     |     |
| --- | --- | --- | --- |
| Column | Type | Nullable | Description |
| event_id | UUID | No  | Unique ID for the event |
| counter_id | STRING | No  | Reference to counters.counter_id |
| delta | BIGINT | No  | Increment/decrement value |
| timestamp | TIMESTAMP | No  | Event creation time |

**Partitioning & Indexing:**

- Partition key: counter_id (ensures all events of a counter stay together)
- TTL: Optional (for event retention, e.g., 90 days)
- Index: timestamp for queries by time range

## API Design

**1\. Create Counter**

POST /v1/counters

**Request (JSON):**

{

"counterKey": "likes",

"initialValue": 0

}

**Responses:**

- 201 Created
- 409 Conflict → counterKey already exists for owner/region
- 400 Bad Request → invalid input
- 401 Unauthorized → if user is not authorized
- 403 Forbidden → if user has no permission

**2\. Increment Counter**

POST /v1/counters/{counterKey}/increment

**Request (JSON):**

{

"delta": 1

}

**Responses:**

- 200 OK
- 404 Not Found → if counterKey does not exist
- 429 Too Many Requests → rate limit exceeded
- 401 Unauthorized → if user is not authorized
- 403 Forbidden → if user has no permission

**3\. Increment Counter**

POST /v1/counters/{counterKey}/decrement

**Request (JSON):**

{

"delta": 1

}

**Responses:**

- 200 OK
- 404 Not Found → if counterKey does not exist
- 429 Too Many Requests → rate limit exceeded
- 401 Unauthorized → if user is not authorized
- 403 Forbidden → if user has no permission

**4\. Get Counter Value**

GET /v1/counters/{counterKey}

**Responses:**

- 200 OK

{

"counterKey": "page_views",

"value": 12345,

"lastUpdated": "2025-12-02T09:00:00Z"

}

- 404 Not Found → if counterKey does not exist
- 401 Unauthorized → if user is not authorized
- 403 Forbidden → if user has no permission

**5\. Delete Counter**

DELETE /v1/counters/{counterKey}

**Auth:** Optional owner verification

**Responses:**

- 204 No Content → success
- 404 Not Found → counterKey not present
- 401 Unauthorized → if user is not authorized
- 403 Forbidden → if user has no permission

**6\. Counter Analytics / Events**

GET /v1/counters/{counterKey}/events

**Query Parameters:**

- startTime → filter from
- endTime → filter to

**Responses:**

- 200 OK

{

"counterKey": "page_views",

"events": \[

{

"event_id": 1,

"delta": 1,

"timestamp": "2025-12-02T08:30:00Z"

},

{

"event_id": 2,

"delta": 2,

"timestamp": "2025-12-02T08:45:00Z"

}

\]

}

- 404 Not Found → counterKey not present
- 401 Unauthorized → if user is not authorized
- 403 Forbidden → if user has no permission

# Chapter 16 — URL Shortener

In the modern digital ecosystem, the ability to share information efficiently is fundamental. Hyperlinks (URLs) are the backbone of the web, allowing users to navigate between resources. However, URLs can often be lengthy, complex, and difficult to share or remember. As digital communication expanded across social media, messaging platforms, and marketing channels, the need for a more concise way to represent web addresses became increasingly evident.

The **URL Shortener Problem** arises from this challenge — how to transform long, cumbersome URLs into short, manageable links that are easy to distribute, while still maintaining an accurate redirection to the original destination.

## Overview

With the proliferation of online content and user-generated media, sharing URLs has become an integral part of communication. However, several practical challenges make this process cumbersome:

1.  **Length and Readability** Many URLs contain query strings, tracking parameters, and identifiers that make them excessively long and visually unappealing. For example:
2.  https://www.example.com/products/item?id=12345&utm_source=twitter&utm_campaign=spring_sale

Such URLs are difficult to remember, type, or communicate verbally.

1.  **Character Limitations** Platforms like Twitter impose strict character limits on posts. Including a lengthy URL can consume a significant portion of the message, leaving less room for meaningful content.
2.  **Aesthetic and Trust Factors** Short, branded URLs (e.g., https://nyt.ms/abc123) appear more professional and are easier to trust and recognize compared to long, generic URLs.
3.  **Tracking and Analytics** Organizations require insight into user engagement — how many times a link was clicked, where the traffic originated, and what devices were used. URL shorteners facilitate click tracking and analytical reporting without altering the target URL.
4.  **Ease of Sharing** Shortened URLs are more convenient to share in offline formats (such as QR codes, printed materials, or presentations) where space is limited.

These needs collectively motivated the emergence of URL shortening services such as **TinyURL (2002)** and **Bitly (2008)**, which have since become critical tools for digital marketing, analytics, and content distribution.

## Requirements

The requirements for the URL Shortener system are divided into two categories: Functional Requirements, Non-Functional Requirements.

### Functional Requirements

- **URL Shortening:** Users should be able to input a long URL and receive a unique, shortened alias. The shortened URL should use a compact format with English letters and digits to save space and ensure uniqueness. Also use can give custom alias too. The input url should be unieq per user, means a same url can get different short url per user.
- **URL Redirection:** When users access a shortened URL, the service should redirect them seamlessly to the original URL with minimal delay.
- **URL Managment**: The url must have a expire and user can delete them if they want.

**Out of Scope Requirements**

- Authentication and Authorization for users.
- Analytics features.
- Monetization features.

### Non-Functional Requirements

- Must support **100M daily active users**
- Expected traffic: **~1M new URLs/day**, with a **100:1 read-to-write ratio**
- Average throughput requirement: **~12 writes/sec** and **~1,200 reads/sec**, with ability to scale up to **≥ 10K writes/sec** and **≥ 100K reads/sec** during peak
- URL redirect latency must be **P95 < 5 ms**
- System must handle **high concurrency** without performance degradation
- Must support **2× peak traffic spikes** without violating SLAs
- Service availability must be **≥ 99.99%**, with automatic failover ensuring minimal downtime
- Data retention must be **≥ 5 years**
- Average URL record size: **~500–512 bytes**
- Must support **multi-region replication** to prevent data loss
- Data durability must be **≥ 11 nines**
- Must detect and block malicious or spam URLs
- Must enforce strong access controls and maintain detailed audit logs
- Must support **zero-downtime deployments**
- Must provide full observability (logs, metrics, traces, proactive alerts)
- Must comply with all organizational and regulatory data-retention policies

## Design Considerations

The **Design Considerations** section outlines the architectural reasoning and key technical decisions made to ensure that the URL Shortener system meets its functional and non-functional requirements efficiently and at scale.

These decisions cover unique identifier generation, data storage, caching strategy, performance goals, and system scalability.

A primary design aspect is how the system generates and manages shortened identifiers — compact, unique tokens that map to original long URLs.

### Encoding Scheme

The system uses a **Base62 encoding** approach, which includes:

\[a–z\] → 26 lowercase letters

\[A–Z\] → 26 uppercase letters

\[0–9\] → 10 digits

This yields **62 unique symbols per position**, providing a good balance between readability and entropy.

For a short URL of length **L**, the total number of unique combinations is calculated as:

\[ 62^L \]

**Capacity Estimation**

|     |     |     |     |
| --- | --- | --- | --- |
| Length (L) | Unique Combinations | Approx. Count | Scalability Level |
| 4   | 14,776,336 | 14.8M | Small-scale |
| 5   | 916,132,832 | 0.9B | Moderate-scale |
| 6   | 56,800,235,584 | 56.8B | Recommended |
| 7   | 3,521,614,606,208 | 3.5T | Global-scale |

Given projected usage of **1 million new URLs per day** and a **5-year data retention policy**, the total number of URLs will be approximately **1.8 billion**. A **6-character Base62 identifier** provides ~56.8 billion unique values — sufficient capacity for long-term scalability with significant headroom.

### Data Storage and Retention

All persistent data will be stored in a **Relational Database Management System (RDBMS)** to ensure **ACID compliance**, **data integrity**, and **efficient querying**.

- Data will be **partitioned** by **creation date** or **hash key range** to support horizontal scalability and balanced load distribution.
- Appropriate **indexes** will be maintained on **short URL keys**, **user identifiers**, and **expiration dates** to optimize read and lookup operations.
- Regular archival of expired URLs.
- **Average Entry Size:** ~500 bytes per record.
- **Estimated Storage Requirement:** 1 million writes/day × 500 bytes × 365 days × 5 years ≈ **912** **GB** total raw data (_excluding replication and indexes_)

**Caching Strategy**

Efficient caching is essential to minimize database load and achieve sub-millisecond redirection latency.

Given the **100:1 read-to-write ratio**, **Average Redirects per second (RPS): 12 \* 100 = 1,200**

If we want to cache some of the hot URLs, we can follow the **80-20 rule** where 20% of the URLs generate 80% of the read traffic.

Since we have 1 million writes per day, if we only cache 20% of the hot urls in a day, **Total cache memory required** = 1M \* 0.2 \* 127 Bytes = 25.4 MB.

Assuming a cache hit ratio of 90%, we only need to handle 10% of the redirect requests directly from the database.

**Requests hitting the DB**: 1,200 × 0.10 ≈ 120 RPS

**Eviction Policy**

The cache employs the **Least Recently Used (LRU)** strategy with optional key expiration:

- Frequently accessed URLs remain in memory
- Least recently used or expired keys are automatically evicted as memory fills
- This ensures efficient memory utilization and consistent cache performance

**Cache Operations**

- On URL redirection, the short code is first queried from Redis
- If found → redirect immediately
- If not found → fetch from the RDBMS, then asynchronously update Redis

This caching approach guarantees **high throughput**, **low latency**, and **load isolation** from the primary database, while maintaining full consistency with persistent storage.

### Security and Abuse Prevention

To ensure system trustworthiness and prevent misuse:

- **Destination Validation:** Prevent shortening of malicious or blacklisted URLs.
- **Rate Limiting:** Restrict URL creation per user/IP to prevent abuse.
- **Input Sanitization:** Guard against injection attacks and malformed inputs.
- **HTTPS Enforcement:** All requests must be served over TLS to protect data integrity.

### Solution Approaches

The **Solution Approaches** section presents multiple strategies to design and implement the URL Shortener system. Each approach offers distinct trade-offs in terms of scalability, performance, complexity, and data consistency. These approaches primarily differ in **how short keys are generated**, **how data is stored and accessed**, and **how collisions and uniqueness are managed**.

Approach 1: Auto-Increment ID + Base62 Encoding

**Overview**

In this approach, each new URL insertion is assigned a unique, auto-incrementing numeric ID from the database. This ID is then converted into a short code using **Base62 encoding** (using characters a–z, A–Z, and 0–9).

**Key Generation Process**

1.  Insert long URL into the RDBMS → receive an incremental integer ID.
2.  Encode the ID into a Base62 string.
3.  Use the encoded string as the short URL key.

**Advantages**

- **Simple and deterministic** — no collisions.
- **Fast key generation** (delegated to the database sequence).
- **Compact URLs** due to Base62 encoding.
- **Easily scalable** by partitioning ID ranges per database instance.

**Disadvantages**

- Potential **predictability** — users could guess URLs by incrementing IDs.
- Requires **centralized ID generation** or sequence management to avoid collisions across shards.

**Best Fit**

Small-to-medium scale systems or systems with strong RDBMS dependency and moderate write throughput.

Approach 2: Hash-Based Key Generation

**Overview**

Each long URL is passed through a **hashing algorithm** (e.g., MD5, SHA-1, or MurmurHash) to generate a unique identifier. A fixed number of characters (e.g., first 6–8) from the hash output are used as the short key.

**Key Generation Process**

1.  Compute hash of the original URL (optionally combined with user ID or timestamp).
2.  Take the first N characters of the hash as the short code.
3.  On collision, append a salt or increment a counter.

**Advantages**

- **Stateless key generation** — no dependency on database sequences.
- Can be **distributed easily** (each node can independently generate keys).
- **Good randomness** — harder for users to guess short URLs.

**Disadvantages**

- **Collision handling** adds complexity.
- **Non-deterministic length control** if hash truncation leads to duplicates.
- Slightly **slower** than auto-increment approach for very high throughput systems.

**Best Fit**

Systems requiring distributed key generation without centralized coordination.

Approach 3: Random String Generation with Collision Check

**Overview**

The system generates a random Base62 string of a fixed length (e.g., 6 or 7 characters) for each new URL. Before finalizing, it checks whether the generated key already exists in the database.

**Key Generation Process**

1.  Generate random 6-character Base62 string.
2.  Check existence in RDBMS.
3.  If collision occurs, regenerate until unique key is found.

**Advantages**

- **Simple and stateless**.
- **Good randomness and unpredictability**.
- Easy to implement without sequence management.

**Disadvantages**

- **Possible collisions**, especially as the dataset grows (though rare for large Base62 space).
- Slightly **higher latency** during key creation due to existence checks.
- **Database contention** on uniqueness constraint for high write volume.

**Best Fit**

Smaller systems or systems prioritizing randomness and simplicity over absolute performance.

Approach 4: Distributed ID Generation (Snowflake-like IDs)

**Overview**

This approach uses a **distributed unique ID generation service** inspired by Twitter’s **Snowflake** algorithm. Each generated 64-bit ID encodes:

- Timestamp bits
- Machine ID bits
- Sequence bits

The resulting ID is then Base62-encoded to form the short URL.

**Key Generation Process**

1.  Each node generates unique 64-bit IDs using timestamp + node ID + counter.
2.  Convert ID to Base62 string.
3.  Store mapping in RDBMS.

**Advantages**

- **Globally unique and scalable** across data centers.
- **No collisions** without central coordination.
- **High throughput** (millions of IDs per second).

**Disadvantages**

- Slightly **more complex implementation** (requires clock synchronization).
- Not deterministic — hard to reproduce keys for the same URL.

**Best Fit**

Large-scale, distributed systems requiring **high availability**, **geo-redundancy**, and **independent node operations**.

Approach 5: Pre-Generated Key Pool (Dedicated Key Generation Service)

**Overview**

A **separate service** is responsible for **pre-generating and managing a pool of unique short keys**, which are stored in advance in a database table. The main URL Shortener service simply **fetches an available key** from the pool during URL creation, eliminating key generation latency at runtime.

**Key Generation Process**

1.  Key Generation Service pre-populates a table (e.g., AvailableKeys) with millions of unique Base62 strings.
2.  When a new URL is shortened:
    - The service fetches one unused key (e.g., SELECT TOP 1 … FOR UPDATE).
    - Marks it as used and stores the mapping.
3.  When the pool runs low, the background job replenishes it asynchronously.

**Advantages**

- **Instant key allocation** — no hash computation or collision checks at runtime.
- **Supports horizontal scaling** — multiple nodes can draw from the same pool.
- **Predictable performance** and **low latency** even under heavy load.
- Decouples **key lifecycle management** from the core URL service.

**Disadvantages**

- Requires **key pool monitoring and replenishment logic**.
- **Concurrency control** is needed to avoid multiple nodes claiming the same key.
- Slightly **higher operational complexity** due to an extra service.

**Best Fit**

High-throughput production systems requiring **consistent millisecond-level latency** and **separation of concerns**.

Selected Approach — Hybrid: Snowflake-style ID Generator + Pre-generated Key Pool

We will adopt the **hybrid approach**: use a **distributed, Snowflake-like ID generator** to create globally unique numeric IDs, **pre-generate** batches of Base62-encoded keys, store them in a **Key Pool** table, and let application servers **consume** keys from the pool at URL-creation time. This gives the best balance of **low-latency writes**, **global uniqueness**, **horizontal scale**, and **operational predictability**.

Below is a professional, production-ready design package for the next phases: **high-level architecture**, **database design (RDBMS)**, **API specification**, **cache & key-pool behavior**, **operational notes**, and **monitoring**.

## High-level Architecture (components & flow)

## Database Design

We assume a horizontally scalable RDBMS (e.g., PostgreSQL with partitioning, or managed cluster like Aurora) and usage of standard SQL features (transactions, row-level locking).

**URL Mappings Table — (url_mappings)**

|     |     |     |     |
| --- | --- | --- | --- |
| Column | Type | Nullable | Description |
| id  | BIGINT | No  | Primary key (unique identifier for each mapping) |
| short_key | VARCHAR(16) | No  | Base62 short URL identifier (~6 chars), must be unique |
| long_url | TEXT | No  | Original long URL |
| owner_id | BIGINT | Yes | User account ID (null if anonymous) |
| created_at | TIMESTAMP (UTC) | No  | Time record was created (default = now) |
| expires_at | TIMESTAMP (UTC) | Yes | TTL expiration timestamp (optional) |
| deleted_at | TIMESTAMP (UTC) | Yes | Timestamp used for soft deletion |

**Indexing & Partitioning Decisions**

- Unique index: (short_key) for fast redirect lookups
- Unique index: (owner_id, long_url) to avoid duplicates per user
- Index: (owner_id, created_at DESC) for user reporting
- Index: (expires_at, deleted_at) for cleanup jobs
- Partition by created_at (monthly/quarterly) for query scalability

**Key Pool Table — (key_pool)**

|     |     |     |     |
| --- | --- | --- | --- |
| Column | Type | Nullable | Description |
| key_id | BIGINT | No  | Primary key for key pool record |
| short_key | VARCHAR(16) | No  | Pre-generated Base62 key (unique) |
| status | SMALLINT | No  | Key state → 0=Available, 1=Reserved, 2=Used, 3=Retired |
| created_at | TIMESTAMP (UTC) | No  | Generation timestamp |
| reserved_by | VARCHAR(64) | Yes | Worker/transaction ID reserving the key |
| reserved_at | TIMESTAMP (UTC) | Yes | Time key was reserved |
| retired_at | TIMESTAMP (UTC) | Yes | Time key expired/retired |
| updated_at | TIMESTAMP (UTC) | No  | Last modification timestamp |

## API Design

**Create short URL**

**POST** /v1/shorten

**Request**

{

"longUrl": "https://example.com/very/long/url?x=1",

"customAlias": "promo2026", // optional

}

**Responses**

- 201 Created

{

"shortUrl": "https://short.ly/Ab3dE4",

"expiresAt": "2026-01-01T00:00:00Z"

}

- 409 Conflict if customAlias already exists.
- 400 Bad Request invalid URL or domain blacklisted.
- 429 Too Many Requests rate limit exceeded.

**Behavior**

- Reserve key from key_pool.
- Create mapping in url_mappings within transaction.
- Populate Redis cache with short_key→long_url.
- Return created resource.

**2\. Redirect (short URL)**

**GET** /{shortKey}

**Behavior**

- Lookup Redis by shortKey. If found → 302 Found (or 301 if permanent) redirect to long_url.
- If miss → query url_mappings → if found, cache it and redirect.
- If not found or expired → 404 Not Found or 410 Gone.

**Notes**

- Increment click counter asynchronously (e.g., push event to queue).

**Delete a short URL**

**DELETE** /v1/urls/{shortKey}

**Auth**: optional owner verification

**Responses**

- 204 No Content success
- 404 Not Found if not present
- 403 Forbidden if not owner

**Behavior**

- Mark mapping as deleted or remove row (depending on retention policy).
- Optionally mark key as recyclable after quarantine.

**Get analytics (basic)**

**GET** /v1/urls/{shortKey}/stats

**Response**

{

"shortKey": "Ab3dE4",

"clicks": 12345,

"createdAt": "2025-11-02T12:00:00Z",

"lastAccessedAt": "2025-11-30T09:00:00Z"

}

**Notes**

- For heavy analytics, query pre-aggregated tables or OLAP store.

**Admin: Key Pool status**

**GET** /v1/admin/keypool/status (internal)

**Response**

{

"availableKeys": 12500,

"reservedKeys": 10,

"usedKeys": 1250000,

"lowWaterMark": 1000

}

# Chapter 17 — Gist System

The design of a Pastebin (or Gist-like) system — a service that allows users to create, store, and share text or code snippets online.

## Overview

A Pastebin or Gist system enables users to submit a piece of text or code and obtain a shareable link that allows others to view it. The primary goals of such a system are:

- Fast read and write operations
- Efficient storage of large textual or binary content
- Metadata-driven retrieval and filtering
- Optional privacy and access control

While conceptually simple, the system must scale efficiently to handle millions of pastes, ensure persistence, and manage user access patterns.

## Requirements

The requirements for the Gist system are divided into two categories: Functional Requirements, Non-Functional Requirements.

### Functional Requirements

- Create Paste: Accept content (text only), optional title, language, visibility (public/unlisted/private), TTL/expiration, and optionally a custom slug (if user requests human-friendly alias — optional feature). (e.g., https://paste.example/3f2b7a1c-0b45-4e3f-bc1c-fdbe6c8f9b21).
- Read Paste: Given GUID (or optional custom slug), return paste metadata and content (raw or rendered). Support Content-Type negotiation (text/plain, text/html for rendered view).
- Delete/Expire: Owner (or admin) can delete or mark a paste expired.
- Fork/Versioning (optional): Allow users to fork or create versions of pastes.
- List Pasts: Paginated listing of a user's pastes.

**Out of Scope Requirements**

- Authentication and Authorization for users.
- **Link Analytics:** The system should be able to track the number of times each gist URL is accessed to provide insights into link usage.
- Monetization features (e.g., ad-based redirect pages).

### Non-Functional Requirements

**Performance**

• **Metadata lookup / Routing**: Target P95 lookup latency < 10 ms for metadata (index lookups, authorization checks).  
• **Signed URL generation**: Fast (<10 ms) to support client-perceived snappiness.  
• **Content delivery latency**: CDN handles raw content; origin should serve authenticated signed URL generation quickly.

**Availability**

• **High availability**: Maintain ≥ 99.99% availability for read operations of public pastes.  
• **Automatic failover**: Multi-region failover for metadata and object storage; health checks and circuit breakers for dependent services.

**Scalability**

• **Horizontal scaling**: All stateless services must scale horizontally (**Read-to-Write Ratio: 100: 1**).  
• **Handle spikes**: System should absorb up to 2× expected peak write traffic without violating SLAs (burst capacity via autoscaling + request queuing).  
• **CDN offload**: Serve raw content through CDN to reduce origin read pressure.

**Capacity & Storage**

• **Daily Active Users**: Example target — **10–50 million** (adjust to product goals).  
• **Writes per day**: **200k — 2M** (configurable assumption range).  
• **Average paste size**: **2–8 KB** for text.  
• **Retention**: Configurable per paste; default 1 year for non-expiring public content.  

**Reliability & Durability**

• **Durability**: Use multi-region / multi-AZ object storage replication for paste content (S3-like replication). Target high durability (e.g., "11 nines" style for object store if available).  
• **Metadata durability**: Replicated, strongly-consistent metadata store for critical operations (or configurable consistency per operation).  
• **Backup & Recovery**: Periodic backups and tested restore procedures for metadata and configuration.

**Consistency & Correctness**

• **Read-after-write behavior**: For owner reads, prefer strong read-after-write for a short window. For global reads of newly created content, eventual consistency may be acceptable depending on storage replication model — document expected behavior.  
• **Slug uniqueness**: If custom slug requested, enforce global uniqueness (or user-scoped uniqueness depending on spec) with transactional checks.

**Security**  
• **Embed protection & sanitization**: Strip or sandbox potentially dangerous HTML; serve rendered content safely.  
• **Access controls & signed URLs**: Protect private/unlisted content with expiring signed URLs and strict authorization.  
• **Rate limiting & abuse detection**: Protect service from spam and DDoS (WAF, API gateway).  
• **Audit logging**: Keep immutable logs for critical actions (create, delete, expire, change visibility).  
• **Encryption**: At-rest encryption for stored objects and metadata; TLS for in-transit.

**Maintainability & Observability**

• **Zero-downtime deployments**: Support rolling upgrades and migration strategies that avoid downtime.  
• **Full observability**: Metrics, logs, distributed traces, dashboards, and alerting for key SLOs (latency, error rate, storage growth).  
• **Operational playbooks**: Runbooks for incident response (expired object cleanup, storage quota exhaustion, failover).

**Compliance**

• **Retention policies**: Allow per-paste retention controls and comply with organizational/regulatory retention rules.  
• **Data governance**: Support data deletion requests (e.g., GDPR/CCPA), ability to audit access.

## Design Considerations

The **Design Considerations** section outlines the architectural reasoning and key technical decisions made to ensure that the Pastebin or Gist system meets its functional and non-functional requirements efficiently and at scale.

### Slug Generation

In addition to the UUID, the system can expose a **human-friendly slug** that enhances readability and usability. The slug is optional and can be:

1.  **User-provided:**
    - Users can specify a custom slug at paste creation (e.g., my-first-snippet).
    - The slug must be **unique** in the database.
    - On conflict, the API should return a 409 Conflict error with a clear message.
2.  **System-generated:**
    - If no slug is provided, the system generates one automatically using:
        - A sanitized, lowercased version of the title (e.g., "Hello World!" → "hello-world"), and
        - A short **entropy suffix** (e.g., timestamp fragment, short hash, or nanoid) to ensure uniqueness.
    - Example generated slug: hello-world-20251105 or hello-world-a7f3c1
    - A robust approach for uniqueness:
        - Attempt slug generation based on title + date or hash.
        - Perform a quick uniqueness check in the metadata store.
        - If conflict occurs, retry with an additional entropy component.

**Slug generation algorithm (example):**

1\. Normalize title:

\- Convert to lowercase

\- Remove punctuation

\- Replace spaces with hyphens

\- Truncate to max 50 characters

2\. Append entropy:

\- Add short suffix: last 6 chars of UUIDv4 or a timestamp fragment

3\. Example:

Title: "System Design Notes"

UUID: 3f2b7a1c-0b45-4e3f-bc1c-fdbe6c8f9b21

Slug: "system-design-notes-fdbe6c"

Edge cases:

- Very large upload attempt → reject with 413 (Payload Too Large).
- Duplicate content detection: optional dedup by storing content-hash and mapping multiple GUIDs to same blob (if desired).

### Data Storage and Retention

All persistent data will be stored in a **Relational Database Management System (RDBMS)** to ensure **ACID compliance**, **data integrity**, and **efficient querying**.

1) Blob / Object Storage (S3/Azure/GCS)

- Stores the paste content blob at path: pastes/{yyyy}/{mm}/{dd}/{uuid} or content-addressed path blobs/{sha256}.
- Use server-side encryption at rest and TLS in transit.
- Configure lifecycle policies for expired content retention and deletion.
- Storage estimation (example): 2,000,000 writes/day × 8 KB average × 365 days ≈ ~5.84 TB/year raw

2) Relational Database (Metadata)

- Keeps small metadata records for fast lookups, queries, and ACLs.
- Storage estimation (example): 2,000,000 writes/day × 512 B average × 365 days ≈ ~ 373.76 GB/year.

### Caching Strategy

Efficient caching is essential to minimize database load and achieve sub-millisecond redirection latency.

Given the **100:1 read-to-write ratio**, **Average Redirects per second (RPS): 12 \* 200 = 2,400**

If we want to cache some of the hot URLs, we can follow the **80-20 rule** where 20% of the URLs generate 80% of the read traffic.

Since we have 2 million writes per day, if we only cache 20% of the hot gists in a day, **Total cache memory required** = 2M \* 0.2 \* 127 Bytes = 50.8 MB.

Only store CDN link of blob content with metadata.

Assuming a cache hit ratio of 90%, we only need to handle 10% of the redirect requests directly from the database and blob storage.

**Requests hitting the DB**: 2,400 × 0.10 ≈ 240 RPS

&nbsp;

**Eviction Policy**

The cache employs the **Least Recently Used (LRU)** strategy with optional key expiration:

- Frequently accessed URLs remain in memory
- Least recently used or expired keys are automatically evicted as memory fills
- This ensures efficient memory utilization and consistent cache performance

**Cache Operations**

- On URL redirection, the short code is first queried from Redis
- If found → redirect immediately
- If not found → fetch from the RDBMS, then asynchronously update Redis

This caching approach guarantees **high throughput**, **low latency**, and **load isolation** from the primary database, while maintaining full consistency with persistent storage.

### Security and Abuse Prevention

To ensure system trustworthiness and prevent misuse:

- **Destination Validation:** Check payload not large as per the system expiation.
- **Rate Limiting:** Restrict Gist creation per user/IP to prevent abuse.
- **Input Sanitization:** Guard against injection attacks and malformed inputs.
- **HTTPS Enforcement:** All requests must be served over TLS to protect data integrity.

### Solution Approaches

The **Solution Approaches** section presents multiple strategies to design and implement the Gist system. Each approach offers distinct trade-offs in terms of scalability, performance, complexity, and data consistency. These approaches primarily differ in **how slug are generated**, **how data is stored and accessed**, and **how collisions and uniqueness are managed**.

Approach 1: Minimal Monolith (DB + Blob storage)

**Overview**

Everything runs inside a single app/service: metadata (RDBMS) + object storage (blob store) + app renders HTML. CDN is optional (later add). Keys are GUIDs; optional custom slugs stored in DB.

**Data model / flow**

- Create: client → app → insert metadata in RDBMS (GUID), upload content to Blob storage (key = GUID) → respond with URL.
- Read: client → app → app fetches metadata and either:
    - Returns rendered HTML (app reads blob, sanitizes, renders), or
    - Redirects client to direct blob URL (if public) or returns content via app.

**Pros**

- Simple to build and reason about.
- Strong control over rendering/sanitization.
- Easy to support authentication/ACLs.

**Cons & risks**

- App becomes read bottleneck (reads for raw content or rendering).
- Not globally low-latency without a CDN.
- Scaling means scaling both compute and DB together.
- High origin bandwidth costs if many reads.

**Best fit**

- MVP, prototypes, low/moderate traffic (< thousands RPS), teams that need simplicity and rapid iteration.

**Ops considerations**

- Add caching (Redis) for metadata and rendered HTML.
- Add CDN later to offload raw content.

Approach 2: Blob Storage + CDN (Origin + Edge caching) — Recommended baseline

**Overview**

Content (raw pastes/attachments) stored in Blob storage (Azure Blob / S3). An edge CDN fronts the blob storage. The app/service handles metadata, permissions, signed URLs for private/unlisted content, and cache invalidation.

**Data model / flow**

- Create: Client → API Gateway → App stores metadata → App uploads to Blob (or generates SAS and client uploads) → App returns metadata + CDN URL (public) OR signed URL (SAS) for private.
- Read (public): Client fetches content from CDN edge; CDN serves cached content or fetches from Blob origin.
- Read (private/unlisted): App generates short-lived signed token (SAS or CDN token) and returns a CDN URL with token — CDN/edge validates & forwards to origin if needed.

**Pros**

- Lowest read latency globally (edge POPs).
- Massive read scale & cost-effective (CDN caches).
- Origin bandwidth reduced.
- Blob storage provides durability & lifecycle policies.
- Good separation: app manages metadata/auth, CDN handles traffic.

**Cons & trade-offs**

- Signed URL + caching interaction: SAS per request can break caching (every signed URL looks unique), so must use CDN features that support token auth or use _cacheable signed URLs_ (token in header or stable token).
- Invalidation complexity when content is deleted/updated (need cache purge).
- Slightly more operational setup (CDN + storage + tokens).

**Best fit**

- Production systems with heavy reads and global users; systems with strong durability requirements.
- Systems that want to keep rendering / auth logic centralized but scale content delivery.

**Ops concerns**

- Use CDN token authentication (not unique query strings) when you want caching.
- Implement cache purge on delete/expire events.
- Use pre-signed URLs with TTL aligned to CDN cache TTLs or use backend-mediated token validation at CDN if available.
- Logging at CDN + origin for analytics and usage.

Approach 3: Content-Addressed Storage + Deduplication (Hash-based content keys)

**Overview**

Store pastes by content hash (e.g., SHA-256). Metadata points to content hash. Identical content is stored once — reduces storage if many duplicates. Keys for user-facing URL are separate (GUID or custom slug).

**Data model / flow**

- Create: Compute hash of content (client or server). If hash exists, reuse object ID; else upload.
- Metadata row: owner, slug, visibility, content_hash, created_at, TTL, version pointer.
- Read: metadata lookup → object lookup by content_hash (via CDN fronting storage).

**Pros**

- Storage-efficient when many duplicates (dedupe).
- Supports immutable content (versions can link to same blob).
- Tamper-evident (hash ensures content integrity).

**Cons**

- Hash collisions (practically negligible for SHA-256).
- More complex version/permission semantics when same content is owned by multiple users (ACLs stored in metadata).
- If you want per-owner encryption keys, dedupe may become impossible.

**Best fit**

- Systems that expect many repeated snippets (copy/paste) and want to optimize storage costs.
- Systems requiring content integrity guarantees.

**Ops notes**

- Avoid putting user-identifying tokens into the hash if dedupe is desired.
- If encrypting objects with per-user keys, dedupe is incompatible.

Approach 4: Git-like Versioning (Delta storage + chunking)

**Overview**

Treat each paste as a repository/file with version history (forks & diffs). Use delta storage where new versions store deltas (diffs) rather than full copies, or store full copies for small objects and deltas only for large ones.

**Data model / flow**

- Metadata holds version history pointers: v1 -> blob1, v2 -> delta(v1→v2) or blob2.
- Forking creates another branch pointer.
- Rendering can reconstruct any version by applying deltas.

**Pros**

- Efficient storage for small changes.
- Intuitive for developers: supports history, blame, diffs.
- Great UX for edit/forking features.

**Cons**

- Complexity: delta computation and reconstitution on read.
- Read latency may increase for deep histories (need to apply several deltas).
- More complicated invalidation/purge strategies.

**Best fit**

- Systems that prioritize version history/fork UX (developer tools, code snippets).
- Low write volume or manageable read patterns (or keep checkpoints for long chains).

**Ops notes**

- Maintain periodic full checkpoints to cap reconstitution cost.
- Use CDN for blob/delta payloads; apply deltas server-side or via client with APIs.

## High-Level Architecture

## Database Design

We assume a horizontally scalable RDBMS (e.g., PostgreSQL with partitioning, or managed cluster like Aurora) and usage of standard SQL features (transactions, row-level locking).

**Gist/Pastbin: paste_metadata — _Paste/Gist level information_**

|     |     |     |     |     |
| --- | --- | --- | --- | --- |
| Column Name | Type | Nullable | Default | Description |
| id  | UUID | No  | —   | Primary key. Unique identifier for the paste. |
| blob_id | TEXT | No  | —   | Identifier of the primary blob/content in object storage. |
| owner_id | UUID | Yes | NULL | Link to user account; NULL = anonymous paste. |
| title | TEXT | Yes | NULL | Optional title for the paste. |
| language | VARCHAR(64) | Yes | NULL | Syntax highlighting tag (e.g., js, csharp, markdown). |
| description | TEXT | Yes | NULL | Optional short description for paste listings. |
| visibility | SMALLINT | No  | 0   | 0 = Public, 1 = Unlisted, 2 = Private. |
| created_at | TIMESTAMPTZ | No  | now() | When the paste was created. Supports partitioning. |
| expires_at | TIMESTAMPTZ | Yes | NULL | Optional expiry timestamp (TTL). |
| deleted_at | TIMESTAMPTZ | Yes | NULL | Soft-delete field (preserve metadata for audit & GC). |
| slug | TEXT | Yes | NULL | User-friendly identifier; unique when present. |

Partitioning rule: PARTITION BY RANGE (created_at) → typically monthly partitions.

**Indexes**

|     |     |     |
| --- | --- | --- |
| Index Name | Columns | Notes |
| idx_paste_owner_created_at | (owner_id, created_at DESC) | Supports fast user-owned listings. |
| idx_paste_expires | (expires_at) | For expiration sweeper jobs. |
| idx_paste_visibility | (visibility) | Filter public/unlisted/private pastes. |
| idx_paste_slug_unique | (slug) UNIQUE | Ensures friendly-slug uniqueness. |

**Gist/Pastbin versioning: paste_versions — _Version history for each paste_**

|     |     |     |     |     |
| --- | --- | --- | --- | --- |
| Column Name | Type | Nullable | Default | Description |
| id  | BIGSERIAL | No  | Auto increment | Primary key for version entry. |
| paste_id | UUID | No  | —   | FK → paste_metadata.id. Cascade delete. |
| version_number | INT | No  | —   | Sequential version: 1,2,3… |
| blob_path | TEXT | No  | —   | Path to blob containing version content. |
| content_hash | CHAR(64) | No  | —   | SHA-256 hash for dedupe/integrity check. |
| size_bytes | BIGINT | Yes | NULL | Size of stored blob (optional analytics). |
| created_at | TIMESTAMP | No  | CURRENT_TIMESTAMP | Timestamp of version creation. |
| is_latest | BOOLEAN | No  | TRUE | Whether this version is the current one. |

**Uniqueness Constraint**

|     |     |     |
| --- | --- | --- |
| Constraint | Columns | Notes |
| unique_version | (paste_id, version_number) | Prevent duplicate version numbers per paste. |

## API Design (RESTful)

All endpoints use **TLS** and **JSON** for metadata operations. Raw content retrieval may return text/plain or a rendered format depending on client headers.

**1\. Create Paste**

**Endpoint**

**POST /v1/pastes**

**Purpose**

Submit a paste creation request. The request is validated and queued for content scanning and asynchronous processing.

**Request (JSON or multipart/form-data)**

{

"content": "print('hello world')",

"title": "Hello World Snippet",

"description": "Sample Python snippet",

"language": "python",

"visibility": "public|unlisted|private",

"expiresIn": "7d",

"slug": "hello-world" // optional custom slug

}

**Immediate Response**

| **Status** | **Description** |
| --- | --- |
| 201 Created | Gist created |
| 400 Bad Request | Invalid payload or missing required fields |
| 413 Payload Too Large | Exceeds configured size limit |
| 429 Too Many Requests | Rate limit exceeded |

**Example Response:**

{

"requestId": "b62c28b4-1531-4893-b2b9-1f05c8f9dcd9",

"status": "accepted",

"message": "Paste submitted for scanning and processing.",

"estimatedProcessingTime": "a few seconds"

}

**2\. Get Paste (Rendered View)**

**GET /{slugOrId}**

**Behavior**

- Look up metadata in Redis or DB.
- If visibility allows, return either:
    - Rendered HTML view (for web clients), or
    - Raw content (for API clients via redirect or signed URL).

**3\. Get Raw Paste**

**GET /v1/pastes/{slugOrId}/raw**

**Behavior**

- Validate visibility and auth.
- Stream raw content from object store or redirect to signed CDN URL.

**4\. Delete Paste**

**DELETE /v1/pastes/{slugOrId}**

**Behavior**

- Validate ownership or admin privileges.
- Mark metadata as deleted and enqueue deletion job.
- Background worker removes blob after quarantine delay (for audit/recovery).

**5\. List User Pastes**

**GET /v1/users/{userId}/pastes?limit=20&cursor=...**

**Behavior**

- Paginated listing of metadata (title, slug, createdAt, expiresAt, etc.).
- Does not fetch or return raw content.
- Supports filters (visibility, language, expiration).

**6\. Admin: Blob Health & GC**

**GET /v1/admin/blobs/status**

Returns summary of:

- Blob reference counts
- Orphaned blobs
- Pending deletions
- Last GC run time

Protected with admin authentication.

**7\. Get Specific Version**

GET /v1/pastes/{slug}/versions/{version}

Returns content and metadata for a specific version.

**8\. Update Paste (create new version)**

PATCH /v1/pastes/{slug}

**Behavior**

- Validates ownership and size limits.
- Queues for content scan (as in POST).
- When approved, Azure Function uploads new blob, creates new version entry, updates metadata.
- Returns HTTP 201 Created immediately.

**Responses**

201 Created

{

"message": "Update accepted and queued for processing",

"slug": "my-snippet",

"queuedAt": "2025-11-05T07:25:00Z"

}

**8\. List Versions**

GET /v1/pastes/{slug}/versions

Returns a list of all versions:

\[

{ "version": 1, "createdAt": "2025-11-01T10:00:00Z", "isLatest": false },

{ "version": 2, "createdAt": "2025-11-05T08:00:00Z", "isLatest": true }

\]

## Monitoring, Metrics & Alerts

Metrics:

- Paste creation throughput (requests/sec)
- Average paste size
- Blob store egress volume
- CDN and Redis hit ratios
- GC and orphan blob cleanup stats

Alerts:

- Queue backlog > threshold
- Content scan failures
- Blob storage egress anomalies
- High quarantined content ratio

**Retention, GC, and Cost Controls**

- Object store lifecycle rules automatically delete expired blobs.
- Periodic GC job removes metadata marked deleted_at and dereferences blobs.
- Optional reference-count model for deduped blobs.
- Quarantine window before permanent deletion for audit/recovery.

# Chapter 18 — Email Template Management

The design of an Email Template Management System that supports system-wide templates, user-defined custom templates, localization, and template snippets with unique identifiers.

## Overview

An Email Template Management System enables organizations to create, manage, and use email templates with support for both system-wide templates and user-specific customizations. The system supports internationalization, localization, and reusable snippets, making it highly flexible and maintainable.

The primary goals of such a system are:

- Efficient template management and versioning
- Support for system and user-specific templates
- Robust localization and internationalization
- Reusable template snippets
- Template override management
- High performance template rendering

While conceptually simple, the system must scale efficiently to handle millions of templates, ensure persistence, and manage user access patterns.

## Requirements

The requirements for the Gist system are divided into two categories: Functional Requirements, Non-Functional Requirements.

### Functional Requirements

- Create Template: Accept template content, metadata, type (system/custom), localization info, and unique template code
- Override System Template: Allow users to create personal versions of system templates
- Manage Snippets: Create and manage reusable template snippets
- Render Template: Process template with variables and render in specified locale
- List Templates: View available templates (system + user-specific)
- Version Control: Track template changes and maintain version history

**Out of Scope Requirements**

- Authentication and Authorization for users.
- **Link Analytics:** The system should be able to track the number of times each email template is used.

### Non-Functional Requirements

**Performance**

- Template rendering (merge + variable substitution) should complete within **P95 < 20 ms** for standard template sizes (≤ 20 KB).
- Metadata and template lookup latency should remain **P95 < 10 ms**.
- Cache-first resolution for system templates and popular custom templates.
- Pre-compiled templates for faster execution where applicable.

**Scalability**

- **Horizontal scaling** for rendering workers supporting elastic autoscaling based on CPU & queue depth.
- Support up to **100–1,000 concurrent template render requests per second** without SLA violation.
- Template data + localization references must be retrieved efficiently via distributed cache for high QPS.

**Availability**

- Template Service uptime **≥ 99.9%**; rendering for critical flows should tolerate dependent service failures.
- Multi-AZ failover for metadata & caches; active-active replication where feasible.
- Graceful degradation:
    - Use last-known-good template version if primary DB/cache is unavailable.

**Capacity & Storage**

- Daily Active Users: **1,000 – 100,000**
- System Templates: **100 – 1,000**
- Custom Templates per User: **5 – 50**
- Template Size: **2 – 20 KB**
- Supported Locales: **10 – 50**
- Snippets / partial reusable blocks: **50 – 500**
- Storage must support at least **10× volume growth** without redesign.

**Reliability & Durability**

- Version-controlled metadata & templates stored in **strongly consistent database**.
- All updates must maintain **write-ahead backups & point-in-time restore**.
- Durable replication with **RPO ≈ 0**, **RTO < 15 minutes** for disaster recovery.

**Consistency & Correctness**

- Strong consistency for:
    - Latest template version fetch
    - Template activation + rollout
- Support **rollbacks** and **preview** version reads.
- Distributed rendering nodes must use caches that **auto-invalidate** on version update.

**Security**

- **Role-based access control** for template CRUD operations.
- **Input sanitization** for variable content to prevent XSS or HTML injection.
- Templates & metadata encrypted **in-transit (TLS)** and **at-rest**.
- Signed access tokens & **multi-tenant isolation** rules enforced.
- Secret-like variables (PII) masked in logs and UI.

**Auditability**

- Maintain immutable audit logs for:
    - Template creation, modification, deletion
    - Publish / unpublish actions
    - Rendering usage logs at aggregated level
- Provide exportable audit trails for compliance.

**Maintainability & Observability**

- Zero-downtime deployments with:
    - Canary releases
    - Safe rollback controls
- Metrics:
    - Render latency, error rate, template cache hits/misses, version rollouts
- Full distributed tracing across services & render pipeline.
- Comprehensive runbooks for incidents like cache poisoning, version rollback, quota failures.

**Compliance**

- Enforce retention rules per organization (template versions, access logs).
- Right-to-delete workflows for user-created templates (GDPR/CCPA shift).
- Document transparency around locale-dependent content generation.

## Design Considerations

The **Design Considerations** section outlines the architectural reasoning and key technical decisions made to ensure that the Pastebin or Gist system meets its functional and non-functional requirements efficiently and at scale.

### Template Identifier Design

- **Pattern:**  
    {category}\_{purpose}\_{version}  
    Example → notification_welcome_v1
- **Uniqueness:** template_code is the **global unique ID**, enforced via DB constraint.
- **Versioning:**
    - version increments when a template is updated.
    - System templates version independently from user overrides.
- **Hierarchy reference:** parent_template_id links overrides to original system templates.

### Localization Strategy

- **Locale Format:** Standard BCP-47 → en-US, es-ES, fr-FR
- **Per-locale Content:** Stored in template_localizations  
    Includes:
    - content (email body)
    - subject_template
- **Fallback Chain**  
    e.g., for fr-CA → check:  
    1️⃣ fr-CA → 2️⃣ fr → 3️⃣ default locale en-US
- **Translation Bundles Support:**  
    Organized per locale, dynamically loaded for rendering based on requested locale.

### Template Override Management

- System templates remain unchanged
- Overrides visible **only** to owning user (owner_id)
- System updates **do not** propagate automatically to overrides

### Data Storage and Retention

All persistent data will be stored in a Relational Database Management System (RDBMS) to ensure ACID guarantees, consistent metadata queries, and secure template governance. Template bodies and partial snippets may require more space due to localization and versioning, so capacity planning must consider growth and high-availability replication.

**1️⃣ Blob / Object Storage (Primary Content Storage)**

Stores:  
✔ Localized template HTML / subject  
✔ User overrides  
✔ Snippets / reusable blocks

Storage path convention:

templates/{category}/{purpose}/{templateCode}/{locale}/v{version}.html

snippets/{snippetCode}.html

**Capacity Estimation** (max sizing):

| **Driver** | **Value** |
| --- | --- |
| Daily Active Users | 100,000 |
| System Templates | 1,000 |
| Custom Templates | 50 × 100,000 = **5,000,000** |
| Total Templates | **5,001,000** |
| Supported Locales | 50  |
| Avg. Content Size | 10 KB |

**Total Localized Objects:**  
5,001,000 × 50 ≈ **250,050,000 stored template versions**

**Total Yearly Storage (raw):**  
250,050,000 × 10 KB ≈ **2.56 TB per year**

With multi-AZ/region replication (3×) → provision **~7.7 TB+**

Additional Snippets:  
• 500 × 10 KB ≈ 5 MB (minimal)

**Blob Storage Lifecycle**  
• Auto-expire deprecated versions after configurable TTL (e.g., 180 days)  
• Cold-tier transition for inactive overrides  
• Encryption at rest + TLS enforced

**2️⃣ Relational Database (Metadata & Governance)**

Stores:  
✔ Template identity & lifecycle state  
✔ Locale index & version references  
✔ Ownership and access control  
✔ Variable schema definitions

Minimal row size: **~512–1024 bytes** average

**Storage Estimation:**  
255M metadata rows × 1 KB ≈ **255 GB raw**  
→ **~765 GB+** with replication

Outage Safety  
• Multi-AZ deployment with automated failover  
• Daily backups & PITR (Point-in-Time Recovery) support

### Caching Strategy

Caching is critical to ensure ultra-low latency rendering and reduce load on both the RDBMS (metadata) and Blob storage (template content).

  
This system experiences **both read-heavy and write-heavy operations** due to template rendering, localization lookup, variable expansion, and user overrides.

**Expected Request Profile**

- **100–1,000** concurrent template rendering requests per second
- Assume average load: **500 RPS**
- Estimate read/write ratio ≈ **70:30**  
    → Read requests ≈ **350 RPS**  
    → Write/override updates ≈ **150 RPS**

Even rendering 350 templates per second directly from storage would be expensive — caching ensures scale and consistent performance.

**What We Cache**

| **Data Type** | **Key Format** | **TTL** | **Purpose** |
| --- | --- | --- | --- |
| Template metadata | template:metadata:{templateCode} | 1–24 hrs | Avoid DB lookups |
| Localized content blobs | template:content:{templateCode}:{locale}:v{version} | 24 hrs | Avoid blob fetch |
| Snippets | snippet:{snippetCode} | 24–72 hrs | Fast partial rendering |
| Fully rendered template with variables | template:rendered:{code}:{locale}:{hash(vars)} | Short TTL (15–120 sec) | Ultra-fast delivery for high-traffic notifications |

Short TTL for rendered results prevents stale personalized content.

**Hot Cache Memory Estimation**

Using **80:20 rule**  
→ 20% of templates generate ~80% of read traffic.

Daily active template traffic (worst case):

100,000 users × 5 renders/day = 500,000 renders/day

Hot set = 20% → 100,000 renders/day

Avg rendered document = 10 KB

Cache requirement for hotset:

100,000 × 10 KB ≈ 1 GB

Redis memory recommendation:

| **Purpose** | **Memory** |
| --- | --- |
| Rendered hot templates | ~1 GB |
| Metadata + snippets | ~100–200 MB |
| Safety buffer (headroom) | ~300 MB |
| **Total Recommended** | **~1.5 GB Redis capacity** |

**Cache Performance Target**

| **Metric** | **Target** |
| --- | --- |
| Cache hit ratio | ≥ 85–95% |
| Latency impact | Sub-millisecond hits |
| DB fallback requests | 350 × 10% = **35 RPS** max |
| Blob fallback requests | ≤ 25 RPS |

This keeps origin load low and predictable even at peak scale.

**Eviction Policy**

Redis will use **Least Recently Used (LRU)** + TTL:

- Hot frequently rendered templates stay cached
- Expired versions and rarely used overrides auto-evict
- Supports growth without service degradation

**Cache Operations**

| **Operation** | **Flow** |
| --- | --- |
| Read (render flow) | Check Redis → If miss, fetch DB + Blob → Render → Cache → Respond |
| Write (override/publish) | Update DB → Invalidate affected Redis keys → Pre-warm if high-traffic |

Automatic cache invalidation triggers:

- Template activation
- Override creation
- Localization updates
- Variable schema changes

This caching approach guarantees **high throughput**, **low latency**, and **load isolation** from the primary database, while maintaining full consistency with persistent storage.

### Security and Abuse Prevention

To ensure system trustworthiness and prevent misuse:

- **Destination Validation:** Check payload not large as per the system expiation.
- **RBAC** for template CRUD (system vs user scope).
- **Rate Limiting:** Restrict template creation per user/IP to prevent abuse.
- **Input Sanitization:** Guard against injection attacks and malformed inputs.
- **HTTPS Enforcement:** All requests must be served over TLS to protect data integrity.

### Solution Approaches

The Solution Approaches section presents multiple strategies to design and implement the **Email Template** system. Each approach offers different trade-offs in scalability, performance, complexity, and operational cost. Approaches primarily differ in where template content and compiled artifacts live, how rendering is performed, how versioning and overrides are managed, and how caching/CDN is used.

**Approach 1: Minimal Monolith (RDBMS + In-process Rendering)**

**Overview**

Single application hosts metadata, stores template source in the RDBMS, and performs compile + render operations in-process. Assets (images/attachments) stored in Blob storage; CDN optional.

**Data model / flow**

- Create/Update: API → write templates and template_localizations rows in RDBMS.
- Publish: API compiles template (syntax check) in process and marks version as active.
- Render: Request hits app → app loads metadata + template content from DB → compiles/executes template with variables → returns rendered HTML/text → enqueue send if applicable.

**Pros**

- Simple to implement and reason about.
- Strong transactional guarantees for metadata and versioning.
- Easy to enforce RBAC, auditing, and approval workflows.
- Fast for low throughput (no network hops).

**Cons & risks**

- CPU and memory pressure on app instances (templating can be expensive).
- Hard to scale render throughput: renders compete with API work for resources.
- Cold compile on high traffic causes spikes; caching is limited to process memory.
- Origin bandwidth for assets without CDN.

**Best fit**

- Early MVPs, low-to-moderate traffic (< few hundred RPS), small teams wanting quick delivery.

**Ops considerations**

- Add Redis for compiled-template cache as next step.
- Offload large templates/assets to Blob + CDN to reduce DB size.

**Approach 2: Compiled Artifact + Cache + CDN (Recommended Baseline)**

**Overview**

Store template _source_ metadata in RDBMS; compile templates on publish into an intermediate artifact (AST/bytecode) stored in Redis (hot) and optionally persisted to Blob (warm). Rendering workers fetch compiled artifacts (from Redis), perform variable substitution, and produce email. Static assets are served from Blob via CDN.

**Data model / flow**

- Create/Publish: API saves source → compile → store compiled artifact in Redis and object store → mark version active.
- Render: Render worker fetches compiled artifact from Redis (fallback to Blob), executes render with variables → returns rendered payload and enqueues send.
- Invalidation: Publish/override events invalidate Redis keys via pub/sub.

**Pros**

- Very low render latency (compiled artifact cache).
- Scales horizontally: stateless render workers.
- CDN offloads assets, reducing origin bandwidth and improving deliverability (images).
- Good separation of concerns: API handles metadata; workers handle CPU-bound rendering.

**Cons & trade-offs**

- Added complexity: compile step, artifact storage, cache invalidation.
- Need robust pub/sub for invalidations.
- Must manage cache sizing and eviction policies for compiled artifacts.

**Best fit**

- Production systems needing sub-100ms render P95, medium-to-high throughput (100–1,000 RPS).
- Systems that require predictable latency and multi-region edge delivery of assets.

**Ops concerns**

- Ensure compiled artifacts are signed/verified if persisted to Blob.
- Monitor Redis eviction; pre-warm compiled artifacts for popular templates.
- Align CDN cache TTLs with template lifecycle and invalidation process.

**Approach 3: Content-Addressed Storage + Deduplication (Hash-based Blobs)**

**Overview**

Template content (compiled artifacts and/or source) is stored address-by-content hash (SHA-256). Metadata points to content hash(s). Identical content across templates/overrides reuses the same blob, saving storage.

**Data model / flow**

- Create: compute content hash server-side (or at client) → if blob exists reuse → else upload to Blob with path blobs/{sha256}.
- Metadata references content_hash per locale/version.
- Render: render worker fetches blob by hash (via CDN) and performs substitution (if needed).

**Pros**

- Storage-efficient when many duplicates (e.g., same system template reused across tenants).
- Immutable content simplifies caching and verification.
- Integrity: content tamper detection via hash.

**Cons**

- Complexity in permissions: same blob may be referenced by multiple owners; ACLs must live in metadata, not in blobs.
- If per-tenant encryption is required, dedupe becomes impossible.
- Variable substitution may require combining content with per-send data, so compiled vs source choice matters.

**Best fit**

- Organizations with heavy reuse of templates across tenants or those focused on storage optimization and content integrity.

**Ops notes**

- Maintain index on content_hash for fast dedupe lookup.
- Ensure blob lifecycle policies consider dedupe reference counts before deletion.

**Approach 4: Serverless Rendering + Managed Cache (Function-as-a-Service + CDN)**

**Overview**

Use serverless functions (AWS Lambda / Azure Functions) for compile-on-demand and rendering, backed by managed Redis (Elasticache) or managed cache (DAX). Blob + CDN for assets. Pre-compile popular templates and store compiled artifacts in managed cache to avoid cold-start penalties.

**Data model / flow**

- Create/Publish: API (could be serverless or managed) writes metadata and triggers pre-compilation job; compiled artifacts placed into managed cache or Blob.
- Render: Request triggers a short-lived function which fetches compiled artifact from cache/Blob, renders, and returns/queues send.

**Pros**

- Low ops (managed services), easy autoscaling to handle bursts.
- Cost-effective for spiky workloads (pay per execution).
- Fast to iterate and deploy.

**Cons**

- Cold-starts; need provisioned concurrency for consistent latency.
- Execution time limits can restrict complex renders; stateful caching must be externalized.
- Debugging and local testing of serverless functions can be less straightforward.

**Best fit**

- Teams preferring managed infra and facing spiky/irregular traffic patterns or early-stage products.

**Ops concerns**

- Use provisioned concurrency for critical paths or ensure pre-warming strategies.
- Keep compiled artifacts in external cache to minimize cold compute.

**Approach 5: Git-like Versioning + Delta Storage (Checkpointing & Diffs)**

**Overview**

Treat templates as repositories with version histories. Store full snapshots for small templates and deltas for frequent small edits. Use checkpointing (periodic full snapshots) to bound reconstruction cost. CDN serves static compiled snapshots; rendering reconstructs version as needed.

**Data model / flow**

- Create/Edit: store delta or full snapshot into Blob (templates/{id}/versions/), metadata points to chain.
- Render: reconstruct version by applying deltas to last checkpoint (server-side), compile if required, render.
- Fork/override: user overrides are new branches pointing to original system template chain.

**Pros**

- Efficient storage for templates with many small edits (deltas).
- Natural support for forks, history, and audit.
- Good UX for rollbacks and diffs.

**Cons**

- Increased complexity: delta computation, storage, and reconstitution.
- Render latency can increase for deep chains unless checkpoints are frequent.
- Cache invalidation and CDN interactions more complex because reconstructed content depends on chain.

**Best fit**

- Tools prioritizing developer-like workflow (editing history, diffs), or when template edits are frequent and small.

**Ops notes**

- Keep regular full checkpoints to cap reconstruction overhead.
- Use CDN for serving checkpoints and compiled snapshots.

**Hybrid Selected Approach — Compiled Artifacts + CDN + Redis (Recommended)**

**Rationale**

Combines the predictable, low-latency renders of **Approach 2** with operational simplicity and cost-effectiveness of managed components from **Approach 4**. Use content addressing selectively for shared compiled artifacts to save storage when appropriate, and use versioned blobs for durable archival and audit.

**Key elements**

- RDBMS for metadata & ACLs.
- Blob storage for compiled snapshots and all assets (served via CDN).
- Redis for compiled-artifact hot cache + metadata cache.

**Benefits**

- Low render P95 (compiled cache).
- Easy horizontal scaling of render workers.
- CDN offloads asset delivery globally.
- Clear versioning: every send references exact template_version_id.

## High-Level Architecture

## Database Design

We assume a horizontally scalable RDBMS (e.g., PostgreSQL with partitioning, or managed cluster like Aurora) and usage of standard SQL features (transactions, row-level locking).

**Templates**

|     |     |     |
| --- | --- | --- |
| Column | Type | Description |
| id  | UUID (PK) | Primary identifier |
| template_code | VARCHAR(100), UNIQUE INDEX | Fast lookup by code |
| category | VARCHAR(50), INDEX | For listing & filtering |
| name | VARCHAR(200) |     |
| description | TEXT |     |
| type | VARCHAR(20) INDEX | system / custom |
| owner_id | UUID, Nullable |     |
| parent_template_id | UUID, Nullable, INDEX | Version inheritance lookups |
| version | INT |     |
| status | VARCHAR(20), INDEX | active most common |
| content_storage_type | ENUM(blob/inline) |     |
| blob_id | UUID, Nullable |     |
| blob_path | VARCHAR, Nullable |     |
| created_at | TIMESTAMPTZ, INDEX(desc) | Useful for latest queries |
| updated_at | TIMESTAMPTZ |     |
| created_by | UUID |     |
| updated_by | UUID |     |

**Indexes**

- PK: (id)
- UNIQUE: (template_code)
- INDEX: (category)
- INDEX: (type)
- INDEX: (status)
- INDEX: (parent_template_id)
- INDEX: (created_at DESC)

**Template Localizations**

|     |     |     |
| --- | --- | --- |
| Column | Type | Description |
| id  | UUID (PK) |     |
| template_id | UUID, FK → templates.id | Indexed for joins |
| locale | VARCHAR(10) |     |
| blob_path | VARCHAR |     |
| subject_text | TEXT |     |
| checksum | VARCHAR(64), Nullable |     |
| created_at | TIMESTAMPTZ |     |
| updated_at | TIMESTAMPTZ |     |

**Indexes**

- PK: (id)
- UNIQUE: (template_id, locale)
- INDEX: (locale)
- INDEX: (checksum) — for dedupe
- INDEX: (template_id)

**Template Snippets**

|     |     |     |
| --- | --- | --- |
| Column | Type | Description |
| id  | UUID (PK) |     |
| snippet_code | VARCHAR(100), UNIQUE INDEX |     |
| name | VARCHAR(200) |     |
| description | TEXT |     |
| scope | VARCHAR(20), INDEX | global / category / template |
| category | VARCHAR(50), Nullable, INDEX | For filtering |
| blob_path | VARCHAR |     |
| created_at | TIMESTAMPTZ |     |
| updated_at | TIMESTAMPTZ |     |

**Indexes**

- PK: (id)
- UNIQUE: (snippet_code)
- INDEX: (scope)
- INDEX: (category)

**Template Variables**

|     |     |     |
| --- | --- | --- |
| Column | Type | Description |
| id  | UUID (PK) |     |
| template_id | UUID, FK → templates.id, INDEX |     |
| variable_name | VARCHAR(100) |     |
| description | TEXT |     |
| required | BOOLEAN |     |
| default_value | TEXT |     |
| validation_regex | TEXT |     |
| created_at | TIMESTAMPTZ |     |

**Indexes**

- PK: (id)
- INDEX: (template_id)
- UNIQUE: (template_id, variable_name) → avoid duplicates

## API Design (RESTful)

All endpoints use **TLS** and **JSON** for metadata operations. Raw content retrieval may return text/plain or a rendered format depending on client headers.

**1️⃣ Create Template**

**POST /v1/templates**

**Purpose**

**Create a new custom template or system template (admin only).**

**Request (JSON)**

**{**

**"templateCode": "order-confirmation",**

**"name": "Order Confirmation Email",**

**"description": "Sent after new purchase",**

**"category": "ecommerce",**

**"type": "custom",**

**"content": "&lt;html&gt;...&lt;/html&gt;",**

**"locale": "en-US"**

**}**

**Responses**

| **Status** | **Description** |
| --- | --- |
| **201 Created** | **Created successfully** |
| **400 Bad Request** | **Missing invalid or duplicate template_code** |
| **401 Unauthorized** | **Missing/invalid auth** |
| **413 Payload Too Large** | **Exceeds 20 KB body size** |
| **429 Too Many Requests** | **Rate limit exceeded** |

**Example Response**

**{**

**"id": "837e4c69-728f-461f-ae33-30afd167df5c",**

**"status": "created",**

**"version": 1**

**}**

**2️⃣ Add / Update Localization**

**PUT /v1/templates/{templateId}/localizations/{locale}**

**Same version — no new template version created.**

**Request:**

**{**

**"content": "&lt;html&gt;Hola {{userName}}&lt;/html&gt;",**

**"subjectText": "Confirmación de pedido"**

**}**

**Response: 200 OK or 201 Created**

**3️⃣ Get Template (Resolved)**

**GET /v1/templates/{templateCode}?locale=en-US&renderMode=inline|cdn**

**Behavior:**

- **Resolve latest version**
- **If locale missing → fallback to default (configurable)**
- **Render mode:**
    - **inline: content+variables embedded**
    - **cdn: return signed URL only**

**Response:**

**{**

**"templateCode": "order-confirmation",**

**"locale": "en-US",**

**"version": 3,**

**"subject": "Order Confirmed",**

**"signedUrl": "https://cdn.example.com/t/...."**

**}**

**4️⃣ Delete Template**

**DELETE /v1/templates/{templateCode}**

**Behavior:**

- **Must not have active dependencies**
- **Marks status as deprecated (soft-delete)**
- **Queues blob cleanup later**

**Response: 202 Accepted queued for cleanup**

**5️⃣ List Templates (with Filters)**

**GET /v1/templates?type=system&status=active&category=ecommerce&limit=20&cursor=…**

**Response:**

**{**

**"templates": \[**

**{ "templateCode": "reset-password", "status": "active" }**

**\],**

**"nextCursor": "..."**

**}**

**6️⃣ Create New Version (Update)**

**PATCH /v1/templates/{templateCode}/versions**

**Request:**

**{**

**"content": "&lt;html&gt;Updated content&lt;/html&gt;",**

**"locale": "en-US",**

**"changeNote": "Updated footer links"**

**}**

**Response:  
201 Created — new version queued & metadata updated**

**7️⃣ Get All Versions**

**GET /v1/templates/{templateCode}/versions**

**Response:**

**\[**

**{ "version": 1, "activatedAt": "2025-01-01", "isLatest": false },**

**{ "version": 2, "activatedAt": "2025-01-10", "isLatest": true }**

**\]**

**8️⃣ Admin — Promote or Deprecate Template**

**POST /v1/admin/templates/{templateCode}/status**

**Request:**

**{ "status": "active" }**

**Response: 200 OK**

**9️⃣ Snippet Management**

**Create Snippet**

**POST /v1/snippets**

**Fetch Snippet**

**GET /v1/snippets/{snippetCode}**

**List by Scope**

**GET /v1/snippets?scope=category&category=ecommerce**

**🔟 Variable Catalog**

**List required variables for a template**

**GET /v1/templates/{templateCode}/variables**

## Monitoring, Metrics & Alerts

Metrics:

- Paste creation throughput (requests/sec)
- Average paste size
- Blob store egress volume
- CDN and Redis hit ratios
- GC and orphan blob cleanup stats

Alerts:

- Queue backlog > threshold
- Content scan failures
- Blob storage egress anomalies
- High quarantined content ratio

**Retention, GC, and Cost Controls**

- Object store lifecycle rules automatically delete expired blobs.
- Periodic GC job removes metadata marked deleted_at and dereferences blobs.
- Optional reference-count model for deduped blobs.
- Quarantine window before permanent deletion for audit/recovery.

# Chapter 19 — Email Provider & Sender

This document describes a system that provides a unified Email Provider + Sender platform: a Web API to manage OAuth connections to external providers (Gmail, Outlook, etc.), store user tokens, and a separate microservice that exposes unified async APIs to send, fetch, and list email messages across configured providers.

## Overview

The system enables users to connect their email provider accounts (Gmail, Outlook, etc.) via OAuth, then send and receive emails through a unified API. It decouples user authentication/authorization (OAuth onboarding and token storage) from email operations (send, get, list) which are processed asynchronously using queues and background processors.

Primary goals:

Unified API surface for multiple providers

Secure storage and handling of user tokens and attachments

Asynchronous, resilient dispatch with retries and per-provider processors

Scalability and observability

## Requirements

The requirements for the Email provider system are divided into two categories: Functional Requirements, Non-Functional Requirements.

### Functional Requirements

- User onboarding: allow users to connect an external email provider via OAuth and store access/refresh tokens
- Unified Send API: accept an email send request (recipients, subject, body, attachments metadata) and enqueue for dispatch
- Attachments: attachments are uploaded via attachment CRUD APIs and stored in blob storage; metadata stored in DB; attachments encrypted at rest
- Inbox APIs: list messages, get message detail (headers/body/attachments) from provider or cached copy
- Async Delivery: sending must be asynchronous — user receives accepted response and later get status
- Per-provider operations: support Gmail and Outlook (initial), pluggable connectors for other providers
- Retry & Failure Handling: retries, exponential backoff, DLQ
- Web UI: integration button to begin OAuth flows and show connection status
- Provider callback/webhook processing (where supported)

**Out of Scope Requirements**

- **Link Analytics:** The system should be able to track the number of times each email template is used.

### Non-Functional Requirements

**Performance**

• P95 send pipeline latency (HTTP request → queued) < **50 ms** for normal load  
• P95 provider submission latency (worker → external provider) < **300 ms**  
• Tracking event ingestion and status updates must process with P95 < **100 ms**  
• Metadata + user plan lookup latency P95 < **20 ms**  
• Outbound emails queued within **sub-second** behavior under peak  
• Provider rate limits respected dynamically with exponential back-off & retry policies  
• Caching for user plan checks and provider routing decisions

**Scalability**

• Horizontal scaling for worker services using CPU, queue depth & throughput autoscaling  
• Support **100–5,000 emails per second** depending on plan tier  
• Queue-driven async processing to absorb spikes up to **10× peak load**  
• Multi-tenant usage isolation to prevent noisy-neighbor throttling

**Availability**

• Target uptime ≥ **99.9%** for email submission API  
• Email dispatch must tolerate outages of a single cloud region (Active-Active preferred)  
• Fallback to alternate provider if primary provider is degraded  
• Graceful degradation:  
o Queue messages with delayed retry if provider unavailable  
o Paused processing instead of dropping messages  
• Real-time health monitoring for providers via synthetic checks

**Capacity & Storage**

• Daily Active Senders: **1,000 – 100,000**  
• Emails per user per day: **10 – 1,000** depending on subscription tier  
• Attachments:  
o Max **10 attachments**  
o Max **5 MB** each, but all attachment size must be less than **21 MB.**  
• Email metadata & Tracking Retention.  
• Storage capacity planned for **10× growth** without redesign  
• Tracking events volume: **millions/day** scale supported  
• Distributed storage for large attachment workloads (Azure Blob)

**Reliability & Durability**

• Messages persist durably once accepted via transactional queue write  
• RPO ≈ **0**, RTO < **15 minutes** for disaster recovery  
• Write-ahead logs for state changes (queued, sent, failed, delivered, opened)  
• At-least-once delivery guarantee for outbound email pipeline  
• Duplicate-send protection via idempotency keys

**Consistency & Correctness**

• Strong consistency for:  
o Quota/rate-limit enforcement  
o Plan subscription validation  
• Eventual consistency allowed for analytics roll-ups & engagement metrics  
• Idempotent retry logic for both queue and provider operations  
• Status tracking must reflect **latest** known state with reconciliation jobs  
• Message correctness validated (schema, personalization, sender identity)

**Security**

• Multi-tenant isolation at data, queue & processing levels  
• Encryption: TLS 1.2+ in-transit, AES-256 at-rest for metadata & attachments  
• Strict RBAC for messaging, contact lists & configuration  
• OAuth2/OpenID Connect for authentication to providers  
• PII redaction in logs; attachments never logged  
• DMARC, SPF, DKIM enforced for deliverability + domain validation required  
• Input sanitization to prevent phishing content injection & HTML exploits

**Auditability**

• Immutable logs for:  
o Email send requests  
o Sender identity + template usage  
o Status transitions and retries  
• Provider interaction logs maintained for compliance  
• Exportable audit reports by organization / time range  
• Tamper-evident log retention policies applied

**Maintainability & Observability**

• Zero-downtime deployments with canary rollout + auto rollback  
• Distributed tracing across:  
o Submission API  
o Queue + Workers  
o Provider callbacks / tracking engine  
• Platform metrics:  
o Queue depth, worker throughput  
o Send failure rate + provider error breakdown  
o Bounce rate + deliverability degradation alerts  
• Dedicated runbooks for:  
o Provider rate limit breach  
o Queue backlog overflow  
o Attachment scanning & corruption handling

**Compliance**

• Right-to-forget workflows (GDPR/CCPA) for sender + contact personal data  
• Data residency enforcement based on customer region  
• Retention rules configurable per org & regulatory requirement  
• Consent proof retention for tracking & engagement analytics

**Constraints & Assumptions**

• Maximum recipients per request: **configurable** (baseline ≤ 100)  
• Maximum attachments: **10**, ≤ **5 MB per attachment** and all attachment size ≤ **21 MB.**  
• Initial supported providers:  
o Gmail REST API  
o Microsoft Graph API  
• Cloud Platform: **Azure-first**, leveraging:  
o Azure Blob Storage  
o Azure Service Bus / Storage Queues  
o Azure Functions / App Services  
• Design must remain **provider-agnostic & cloud-portable**  
• Email deliverability influenced by receiver domains & spam rules (out of system control)

## Design Considerations

The Design Considerations section outlines the foundational architectural decisions required to deliver a secure, scalable, and compliant cloud-native email delivery platform that meets the system’s reliability, performance, and extensibility goals.

### Service Responsibility Segregation

To support independent evolution, scaling, and governance:

| **Service** | **Primary Responsibilities** | **Deployment Tier** |
| --- | --- | --- |
| **Auth Service** | OAuth onboarding, API access tokens, sender identity mgmt, UI redirects | Edge, low-latency web tier |
| **Email Service** | Send/list/get APIs, validation, quota/rate limiting, queue dispatching, provider sync | Compute workers & asynchronous messaging tier |

### Data Storage Architecture

**1️⃣ Relational Database (Postgres / Azure SQL)**

Used for strongly consistent metadata:

Stored Items:  
✔ User accounts (sender identity, OAuth credentials)  
✔ Token lifecycle and provider refresh tokens  
✔ Message metadata (state, timestamps, retry count)  
✔ Recipient lists (hashed or tokenized where required)

ACID guarantees maintain message correctness and state integrity.

Storage estimation (baseline):

| **Driver** | **Value** |
| --- | --- |
| Daily Active Send Requests | 1M messages/day |
| Avg row size per message metadata | ~1 KB |
| Daily DB growth | ~1 GB/day raw |

**2️⃣ Blob/Object Storage**

Used for:  
✔ Attachments (max 10, ≤5MB each)  
✔ Large message bodies or inline media (optional shift)

Storage path guidelines:

messages/{messageId}/attachments/{attachmentId}

emails/bodies/{hash or messageId}

Advantages:  
• Low-cost & infinitely scalable  
• Encrypted at rest (AES-256)  
• Supports lifecycle rules (cold tier after 30–90 days)

### Queue-Driven Processing Strategy

Queues ensure reliable delivery and provide backpressure controls.

Event Streams:

| **Queue Name** | **Purpose** |
| --- | --- |
| send-requests | Persist accept → enqueue → async execution |
| provider-callbacks | Ingest delivery/bounce updates |
| retry-pipeline | Automatic delayed retries on throttling/failures |

Why queues?  
• Rate smoothing — absorbs traffic spikes (up to 10× peak)  
• Provider fault tolerance — messages retry later  
• Guaranteed processing — durable, at-least-once delivery

### Provider Connector Architecture

Connector modules implement a **common interface**:

ISendProvider:

send(emailMessage)

getStatus(messageId)

listMessages(filters)

Initial Implementations:  
• Gmail — Gmail REST API  
• Outlook — Microsoft Graph API

Future Expansion:  
• SES, SendGrid, Mailgun, SMTP universal connector

Decision Pattern:  
• Provider routing selected by user domain, plan, or deliverability insights  
• Fallback provider auto-selected on SLA drops

**Idempotency & Duplicate Protection**

Key ↔ sendIdempotencyKey from clients ensures:  
• Multiple retries → **0 duplicate sends**  
• Accurate reporting & billing  
• No replay failures during transient outages

Validation workflow:  
API receives request → Checks metadata store → Discards duplicate → Returns existing status/IDs

**Security & Token Governance**

Sensitive items:  
✔ OAuth refresh tokens  
✔ Message recipients (may include PII)  
✔ Attachments

Security Controls:  
• TLS enforcement end-to-end  
• Database encryption (TDE) + blob encryption  
• PII hashing or tokenization for optional tenant policies  
• Zero visibility of attachment content in logs

Email sending must enforce:  
• SPF, DKIM, DMARC validation on registered domains  
• Domain ownership proof to prevent spoofing

**Scalability Strategy**

| **Component** | **Scaling Dimension** |
| --- | --- |
| API Gateways | Horizontal scale on request QPS |
| Worker Functions | Queue depth, throughput & failure rate |
| Blob Storage | Auto-scale by default |
| DB & Redis | Read replicas + caching |

Worker Performance Target:  
• ~100–500 messages/sec per worker instance  
• Fully stateless → dynamic pool expansion

### Caching Strategy

What is cached:

| **Cache Item** | **Key Format** | **Purpose** |
| --- | --- | --- |
| User plan metadata | user:plan:{userId} | Prevent DB hotspots |
| Provider routing rules | provider:rules:{domain} | Fast SLA-based decisions |
| OAuth tokens (short-TTL) | oauth:token:{provider}:{user} | Avoid provider auth churn |

Cache Goals:  
• Hit ratio ≥ 85%  
• Prevent excessive DB & provider API calls  
• Auto-invalidate on token refresh or plan change

### Attachment Handling Strategy

Processing Rules:  
• Max 10 attachments per email  
• Max size 5 MB each (policy)  
• Antivirus scanning before worker pickup  
• Mime type validation — prevent executable content forwarding

Storage Tiering:  
• Inline for small (<100 KB) content only  
• Blob references for large payloads

### Async Dispatch Flow

1.  Client POST /v1/messages/send -> API validates and persists message + attachments metadata
2.  API enqueues message id to dispatch-queue
3.  Dispatch Azure Function triggered by dispatch-queue picks message:
    - Retrieve message metadata and attachments
    - Determine provider (explicit or pick by preference/availability)
    - Transform message to provider format (MIME, REST payload)
    - Place into provider-specific queue (e.g., gmail-send-queue) OR attempt immediate send
4.  Provider Processor picks provider queue entry and calls the provider API (Gmail/Graph):
    - Use stored access_token; refresh if expired using refresh_token
    - Ensure idempotency header or client-side idempotency if supported
    - On success: update messages.external_id and status = sent; push to sent-queue
    - On transient failure: increment attempt_count, schedule retry using exponential backoff; if attempts exceed threshold push to DLQ
    - On permanent failure: mark failed and emit events/notifications
5.  Post-send processors consume sent-queue for user notifications, analytics, and webhook firing to client callbacks (if any)

### Operational Concerns

Key metrics monitored:  
• Send success rate & bounce classification  
• Provider SLA degradation warnings  
• Queue backlog alerts with auto scale-out  
• Token refresh failures (OAuth expiry)

Runbooks for:  
• Provider rate limit lockout  
• DB connection exhaustion  
• Dead letters > threshold

Deployment:  
• Zero downtime via canary deployments  
• Automatic rollback triggers based on error spikes

## High-Level Architecture

## Database Design

We assume a horizontally scalable RDBMS (e.g., PostgreSQL with partitioning, or managed cluster like Azure Database for PostgreSQL / Azure SQL with sharding) and usage of standard SQL features (transactions, row-level locking, partial indexes). The design below prioritizes strong consistency for metadata, auditability, and partitioned/archived storage for high-volume message events.

**Users**

|     |     |     |
| --- | --- | --- |
| Column | Type | Description |
| id  | UUID (PK) | Primary identifier |
| email | VARCHAR(320), UNIQUE | Login / contact email |
| display_name | VARCHAR(255) | Human-friendly name |
| timezone | VARCHAR(50), NULLABLE | Optional user timezone |
| created_at | TIMESTAMPTZ, INDEX (desc) | Account creation |
| updated_at | TIMESTAMPTZ | Last update |

**Indexes**

- PK: (id)
- UNIQUE: (email)
- INDEX: (created_at DESC)

**Provider Connections**

|     |     |     |
| --- | --- | --- |
| Column | Type | Description |
| id  | UUID (PK) |     |
| user_id | UUID, FK → users(id), INDEX | Owner |
| provider_name | VARCHAR(50), INDEX | e.g., 'gmail','outlook' |
| provider_account_id | VARCHAR(255) | Provider account identifier |
| access_token | TEXT NOT NULL | Encrypted at-rest |
| refresh_token | TEXT | Encrypted at-rest |
| token_expires_at | TIMESTAMPTZ | Expiry time for access token |
| scopes | TEXT\[\] | Granted OAuth scopes |
| is_active | BOOLEAN DEFAULT TRUE | Soft disable connector |
| created_at | TIMESTAMPTZ DEFAULT now() |     |
| updated_at | TIMESTAMPTZ DEFAULT now() |     |

**Indexes**

- PK: (id)
- INDEX: (user_id, provider_name)
- INDEX: (provider_account_id)

**Messages**

(metadata for each send request — canonical source of truth for email lifecycle)

|     |     |     |
| --- | --- | --- |
| Column | Type | Description |
| id  | UUID (PK) |     |
| user_id | UUID, FK → users(id), INDEX |     |
| provider_connection_id | UUID, FK → provider_connections(id), NULLABLE | preferred provider |
| external_id | VARCHAR(255), NULLABLE | provider message id (populated after send) |
| status | VARCHAR(50) NOT NULL, INDEX | queued, sending, sent, delivered, bounced, failed, retrying |
| subject | TEXT |     |
| body_format | VARCHAR(10) NOT NULL DEFAULT 'html' | 'html' or 'text' |
| body_blob_id | UUID, NULLABLE | blob reference if stored in Blob |
| created_at | TIMESTAMPTZ DEFAULT now(), INDEX (desc) |     |
| updated_at | TIMESTAMPTZ |     |
| scheduled_at | TIMESTAMPTZ, NULLABLE | deferred send time |
| idempotency_key | VARCHAR(255), NULLABLE | client-supplied idempotency |
| attempt_count | INT DEFAULT 0 |     |
| priority | SMALLINT DEFAULT 0 | for scheduling |
| recipient_count | INT DEFAULT 0 |     |

**Indexes**

- PK: (id)
- INDEX: (user_id, created_at DESC)
- INDEX: (status)
- UNIQUE PARTIAL: (idempotency_key) WHERE idempotency_key IS NOT NULL

**Message Recipients (normalized recipients)**

(Storing recipients as normalized rows simplifies queries, quotas, analytics, and per-recipient status)

|     |     |     |
| --- | --- | --- |
| Column | Type | Description |
| id  | UUID (PK) |     |
| message_id | UUID, FK → messages(id), INDEX |     |
| recipient_type | VARCHAR(10), INDEX | to / cc / bcc |
| address | VARCHAR(320), INDEX | recipient email |
| display_name | VARCHAR(255), NULLABLE |     |
| status | VARCHAR(50), DEFAULT 'pending' | delivered, bounced, deferred, etc. |
| status_reason | TEXT, NULLABLE |     |
| delivered_at | TIMESTAMPTZ, NULLABLE |     |
| created_at | TIMESTAMPTZ DEFAULT now() |     |

**Indexes**

- PK: (id)
- INDEX: (message_id)
- INDEX: (address)
- INDEX: (status)

**Message Events / Delivery Events**

(immutable event stream for each message/recipient — useful for reconciliation & audit)

|     |     |     |
| --- | --- | --- |
| Column | Type | Description |
| id  | BIGSERIAL (PK) |     |
| message_id | UUID, FK → messages(id), INDEX |     |
| recipient_id | UUID, FK → message_recipients(id), NULLABLE |     |
| event_type | VARCHAR(50), INDEX | enqueued, sent, delivered, opened, clicked, bounced, complaint |
| event_payload | JSONB | raw provider webhook payload |
| occurred_at | TIMESTAMPTZ NOT NULL, INDEX |     |
| processed_at | TIMESTAMPTZ NULL |     |

**Indexes**

- PK: (id)
- INDEX: (message_id)
- INDEX: (recipient_id)
- INDEX: (occurred_at DESC)

**Attachments**

(metadata only; content in Blob Storage)

|     |     |     |
| --- | --- | --- |
| Column | Type | Description |
| id  | UUID (PK) |     |
| user_id | UUID, FK → users(id), INDEX |     |
| message_id | UUID, FK → messages(id), NULLABLE |     |
| blob_path | TEXT NOT NULL | canonical blob path |
| size_bytes | BIGINT NOT NULL |     |
| mime_type | VARCHAR(255) |     |
| name | VARCHAR(512) |     |
| uploaded_at | TIMESTAMPTZ DEFAULT now() |     |
| encrypted | BOOLEAN DEFAULT true |     |

**Indexes**

- PK: (id)
- INDEX: (user_id, uploaded_at DESC)
- INDEX: (message_id)

**Provider Rate Limit / Quota (optional)**

(Tracks provider-specific counters for routing and throttling)

|     |     |     |
| --- | --- | --- |
| Column | Type | Description |
| id  | UUID (PK) |     |
| provider_name | VARCHAR(50) |     |
| tenant_id | UUID, NULLABLE |     |
| limit_window | VARCHAR(50) | e.g., per_minute, per_hour |
| limit_value | INT |     |
| current_count | INT |     |
| window_start | TIMESTAMPTZ |     |

**Storage & Partitioning Strategy**

- **Partition high-volume tables** (e.g., message_events, messages) by time (monthly) or by tenant (hash of user_id) to enable efficient pruning/archival.
- **Move older partitions** to cheaper storage or export to data warehouse (e.g., ADLS / Synapse / BigQuery) for analytics.
- **Retention policies**: keep message metadata 30–90 days online, events 90–365 days depending on compliance, then archive.
- **Vacuum / compaction**: schedule during low-traffic windows.
- **Backups**: frequent PITR for metadata DB; blob storage lifecycle + replication.

**Caching & Hot-Path Optimization**

- Cache frequently read items in Redis: user plan, provider routing, token metadata (short TTL), and recent message status.
- Use read-replicas for heavy read workloads (analytics / UI queries). Route writes to primary to keep consistency for idempotency checks.

**Notes on Idempotency, Concurrency & Transactions**

- Use **unique partial index** on idempotency_key in messages to prevent duplicate sends. Wrap idempotency check + insert in a transaction to avoid races.
- Use **row-level locking** (SELECT ... FOR UPDATE) when updating message status and attempt_count.
- Use **atomic operations** for counters or move to Redis with strong synchronization if extremely high QPS.

## API Design (RESTful)

All endpoints use **TLS** and **JSON**.  
Large or binary payloads (attachments / raw emails) may be returned via **signed URLs**.

### Auth Service — API Specification

**1️⃣ Begin OAuth**

**GET /v1/connect/{provider}?userId={userId}&returnUrl={encodedUrl}**

Purpose  
Initiate provider OAuth login and redirect the user to Gmail/Outlook authorization page.

Responses

| **Status** | **Description** |
| --- | --- |
| 200 OK | Return JSON containing redirect URL |
| 302 Redirect | Browser flow redirect |
| 400 Bad Request | Missing userId or unsupported provider |

Example Response

{ "authorizationUrl": "https://accounts.google.com/..." }

**2️⃣ OAuth Callback**

**POST /v1/connect/{provider}/callback**

Behavior:  
• Exchange auth code → encrypted tokens stored in provider_connections  
• Validate state for CSRF  
• Activate connection

Response:

{

"connectionId": "c24f33e4-ef84-413a-8ec4-5a3e43d91718",

"status": "connected"

}

Errors: 400, 401, 500

**3️⃣ List OAuth Connections**

**GET /v1/connections?userId={userId}**

Response

{

"connections": \[

{

"connectionId": "uuid",

"provider": "gmail",

"connectedAt": "2025-10-10T10:00:00Z"

}

\]

}

**4️⃣ Disconnect Account**

**DELETE /v1/connections/{connectionId}**

Behavior:  
• Optionally revoke provider token  
• Mark inactive

Response: **204 No Content**

Errors: 404, 409 if used by pending email sends

### Email Service — API Specification

**1️⃣ Send Email (Async)**

**POST /v1/messages/send**

**Request (JSON)**

{

"userId": "uuid",

"providerPreference": "gmail",

"idempotencyKey": "abcd-1234",

"subject": "Welcome!",

"body": "&lt;html&gt;Hello!&lt;/html&gt;",

"bodyFormat": "html",

"to": \["test@xyz.com"\],

"cc": \[\],

"bcc": \[\],

"attachments": \["attachmentId1"\],

"scheduledAt": "2025-11-05T08:00:00Z"

}

**Response**

| **Status** | **Description** |
| --- | --- |
| 202 Accepted | Queued successfully |
| 422 Validation | Recipients or attachment violations |
| 429 Too Many Requests | Rate limit exceeded |

Example:

{

"messageId": "ac683369-339b-4403-a8b4-e7082c11d7d9",

"status": "queued"

}

Backend Steps:  
✓ Validate user & connection  
✓ Validate recipient rules  
✓ Insert into DB (status=queued)  
✓ Enqueue async send

**2️⃣ Upload Attachment**

**POST /v1/attachments**

Content-Type: multipart/form-data

Response:

{

"attachmentId": "uuid",

"size": 1048576

}

Errors: 413 if >5MB per attachment or >10 max per message

**3️⃣ Get Message Status**

**GET /v1/messages/{messageId}**

Response:

{

"messageId": "uuid",

"status": "sent",

"provider": "gmail",

"externalId": "abc123@google.com",

"attempts": 1,

"createdAt": "2025-10-10T10:00:00Z"

}

**4️⃣ List Sent Messages**

**GET /v1/messages?userId={userId}&limit=20&cursor=next**

Response pagination:

{

"messages": \[

{ "messageId": "uuid", "status": "sent" }

\],

"nextCursor": "..."

}

**5️⃣ Fetch Raw Message Data**

**GET /v1/messages/{messageId}/raw**

Behavior:  
• Returns message body content  
• Signed URLs for attachments

Response:

{

"body": "&lt;html&gt;Welcome&lt;/html&gt;",

"attachments": \[

{ "name": "file.pdf", "signedUrl": "https://blob..." }

\]

}

**6️⃣ Unified Inbox → List Items**

**GET /v1/inbox/list?userId={userId}&provider=gmail&since=2025-10-10T00:00:00Z**

Response:

{

"items": \[

{

"provider": "gmail",

"providerMessageId": "msg123",

"subject": "Hello",

"from": "a@b.com",

"receivedAt": "2025-10-10T10:00:00Z"

}

\]

}

**7️⃣ Get Inbox Email Details**

**GET /v1/inbox/{providerMessageId}**

Response:

{

"provider": "gmail",

"subject": "Invoice",

"body": "&lt;html&gt;…&lt;/html&gt;",

"attachments": \[

{ "signedUrl": "https://blob-url.com" }

\]

}

**🔄 Webhooks / Internal Callbacks**

**Provider Delivery Callbacks**

**POST /internal/providers/{provider}/delivery-status**

Purpose: Update tracking status → messages table  
Auth: Shared Secret + Signed payload

**📎 Additional APIs (Recommended for MVP+)**

| **Feature** | **Endpoint** |
| --- | --- |
| Retry send | POST /v1/messages/{id}/retry |
| Cancel scheduled | DELETE /v1/messages/{id} |
| Signed URL refresh | POST /v1/attachments/{id}/refresh-url |

# Chapter 20 — News Feed System

In today’s digital ecosystem, the ability to consume timely, relevant content is central to user engagement on social platforms. Social networks, messaging apps, and content-sharing services rely on news feeds to present users with posts, updates, and media from people or entities they follow. However, with hundreds of millions of users and billions of posts, delivering an accurate, personalized, and up-to-date feed in real-time poses significant technical challenges.

The News Feed Problem arises from this challenge — how to provide users with a continuously updating timeline of posts from followed accounts and recommended content while ensuring low latency, scalability, and reliability.

## Overview

As social media and content platforms grew, several practical issues emerged in building a robust news feed system:

**Goals**

- **Primary goal:** Deliver personalized, up-to-date timelines to users with low latency and high availability.
- **Secondary goals:** Support massive scale (hundreds of millions of users), provide near real-time delivery of posts, enable efficient storage and retrieval of media, and allow rich engagement (likes, replies, retweets).

**High Volume of Content**  
Users generate massive amounts of posts, media, and engagement events. A single user may follow thousands of accounts, each producing content continuously, resulting in a flood of updates that need to be delivered in near real-time.

**Personalization and Ranking**  
Not all posts are equally relevant. The system must rank content based on recency, engagement, relevance, and user preferences to ensure each feed is meaningful and engaging.

**Latency Requirements**  
Users expect feeds to update immediately when new content is available. High-latency feeds lead to poor user experience and reduced engagement.

**Fan-out Complexity**  
Propagating a new post to potentially millions of followers (fan-out) can create significant load on databases and message queues. Two primary strategies exist:

- **Fan-out-on-write:** Push updates to each follower’s timeline immediately.
- **Fan-out-on-read:** Compute the feed dynamically when the user requests it.

**Storage and Retrieval**  
Efficiently storing posts, engagement data, and timeline indices is critical. Systems must balance write-heavy workloads (posting new content) with read-heavy workloads (users fetching timelines).

**Scalability and Availability**  
The system must support hundreds of millions of users, handle spikes in posting activity, and remain available globally. Multi-region replication, partitioning, and caching are essential to meet these demands.

**Engagement Tracking**  
Feeds must support rich interactions like likes, comments, and shares. Each engagement can affect post ranking and must be reflected in the feed in near real-time.

These requirements have driven the evolution of sophisticated news feed systems at scale, such as those used by Twitter, Facebook, and Instagram. By combining **real-time data propagation, personalized ranking algorithms, distributed storage, and caching strategies**, modern news feeds deliver relevant content to users efficiently, reliably, and at massive scale.

## Requirements

The requirements for the News Feed System are divided into three categories: Functional Requirements, Non-Functional Requirements, and Scale Requirements.

### Functional Requirements

- Create posts with text and media (images/videos).
- Follow / unfollow users.
- Read home timeline (personalized timeline) with infinite scroll.
- Real-time propagation of new posts to followers.
- Engagements: like, retweet, reply — immediately reflected where relevant.
- Media upload and delivery (CDN-backed).
- Search and user/profile lookups.
- Admin tools for moderation and content control.

### Non-Functional Requirements

- Availability: 99.99% regional availability for reads; high availability for writes.
- Latency: Timeline load under ~200ms for first page; tail latency minimized.
- Throughput: Support billions of feed reads per day and hundreds of millions of writes per day.
- Freshness: New posts should be visible in followers' timelines in near real-time (seconds) for most use cases.
- Consistency: Avoid duplicates and missing posts; eventual consistency acceptable for some ranking updates.

**Constraints & Challenges**

- Fan-out scale problem (celebrity users with millions of followers).
- Write vs read heavy workload (reads dominate; ~80% reads).
- Personalization and ranking at scale.
- Media storage and CDN delivery for very large volumes.
- Abuse detection, moderation, and privacy controls.

**Capacity & Scale Estimates (example)**

- 500M total users, 200M DAU.
- 1B posts/day; 300M media uploads/day.
- 1B likes/day, 500M replies/day, 250M retweets/day.
- 2B+ feed requests/day (average 10 feed opens per DAU).
- Reads are ~80% of traffic; writes and engagement operations are heavy but smaller in volume.

## Design Considerations

The **Design Considerations** section outlines the architectural reasoning and key technical decisions made to ensure that the **News Feed System** meets its functional and non-functional requirements efficiently at scale.

These decisions cover feed storage, fan-out strategies, caching, timeline personalization, media delivery, performance, scalability, and system reliability.

### Feed Storage and Fan-out

A primary challenge in a news feed system is **efficiently storing posts and propagating them to followers’ timelines**. Two primary approaches exist:

**1\. Fan-out-on-write**

- When a user posts, the system pushes the post to all followers’ timelines immediately.
- Pros: Fast timeline reads, low latency for end users.
- Cons: High write amplification, especially for celebrity users with millions of followers.

**2\. Fan-out-on-read**

- Timelines are computed dynamically when a user requests them, fetching posts from followed users.
- Pros: Write-efficient, handles celebrity users well.
- Cons: Higher read latency, more compute per feed request.

**Hybrid Approach (Recommended)**

- Use **fan-out-on-write** for regular users (smaller follower count).
- Use **fan-out-on-read** for users with massive follower counts.
- Combine both strategies for a **balanced approach**, ensuring low latency and efficient resource usage.

**Event Hub Topics (Shared)**

| **Event** | **Producer** | **Consumer** |
| --- | --- | --- |
| PostCreated | Post Service | Timeline, Ranking, Notification |
| PostLiked | Engagement | Ranking, Notification |
| PostCommented | Engagement | Notification |
| UserFollowed | Relationship | Ranking, Notification |

### Data Model and Storage

**Post Storage**

- Store posts in a **high-throughput, distributed database** (e.g., Cosmos DB, DynamoDB, or Cassandra).
- Each post record includes: post_id, user_id, timestamp, content, media references, engagement counters.
- Posts partitioned by user_id or timestamp for balanced write/read distribution.

**Timeline Storage**

- Timeline entries can be stored in a **key-value store** (Redis, Memcached) or database with **list/set structures** per user.
- Store pointers to post IDs instead of full content to reduce memory footprint.

**Media Storage**

- Media files (images, video) stored in **CDN-backed object storage** (e.g., Azure Blob Storage + CDN).
- Use media references in post records rather than embedding content directly.

### Caching Strategy

Efficient caching is essential to minimize read latency and database load.

- **Hot Feed Cache:** Frequently accessed timelines stored in Redis or in-memory cache.
- **Eviction Policy:** Use **Least Recently Used (LRU)** or TTL-based expiration for timeline entries.
- **CRDTs / Eventual Consistency:** For multi-region deployment, use **CRDT-based counters** for likes, retweets, and engagement metrics to handle concurrent updates without conflicts.

**Cache Operations:**

1.  On feed read: check Redis cache → if hit, return feed.
2.  On cache miss: query database → populate cache asynchronously.
3.  Fan-out updates push new post IDs to cached timelines.

### Personalization & Ranking

- Rank posts based on recency, user engagement, and relevance using a **scoring algorithm**.
- Use ML-based recommendation pipelines to surface posts outside the immediate follower graph.
- For large-scale timelines, maintain **precomputed ranking slices** for faster retrieval.

### Performance & Scalability

**Throughput and Latency**

- Timeline reads: low-latency (<200ms first page), tail latency minimized.
- Post writes and engagement updates: propagate in near real-time (seconds).

**Horizontal Scaling**

- Services split into **microservices**: post creation, timeline generation, engagement tracking, media delivery.
- Partition data by user ID, region, and time for balanced load distribution.

**High-Volume Fan-out**

- For users with millions of followers, leverage **asynchronous processing** via **message queues or event hubs** (e.g., Azure Event Hub, Kafka).
- Use **Azure Functions / serverless workers** as consumers to update timelines.

### Security and Abuse Prevention

- **Authentication & Authorization:** All write operations require secure access.
- **Spam & Abuse Detection:** Automated moderation pipelines and rate-limiting.
- **Input Validation & Sanitization:** Prevent malicious content injection.
- **HTTPS / TLS:** All client-server communication must be secure.

## High-level Architecture (components & flow)

## Database Design

### User Service Database Design

**Users Table — (users)**

|     |     |     |     |
| --- | --- | --- | --- |
| Column | Type | Nullable | Description |
| id  | **BIGINT** | **No** | **Primary key** |
| username | **VARCHAR(32)** | **No** | **Unique handle** |
| email | **VARCHAR(256)** | **No** | **Unique email** |
| password_hash | **VARCHAR(255)** | **No** | **Secure hash** |
| bio | **TEXT** | **Yes** | **Profile bio** |
| avatar_url | **TEXT** | **Yes** | **Profile image** |
| created_at | **TIMESTAMP** | **No** | **When account created** |
| updated_at | **TIMESTAMP** | **No** | **Last modified** |
| deleted_at | **TIMESTAMP** | **Yes** | **Soft delete support** |

**Indexes**

- **Unique(username)**
- **Unique(email)**
- **Index(created_at DESC)**

### Post Service Database Design

**Posts — (posts)**

|     |     |     |
| --- | --- | --- |
| Column | Type | Nullable |
| id  | **BIGINT** | **No** |
| user_id | **BIGINT** | **No** |
| content | **TEXT** | **No** |
| media_url | **TEXT** | **Yes** |
| visibility | **SMALLINT** | **No (0-Public, 1-Friends, 2-Private)** |
| created_at | **TIMESTAMP** | **No** |
| updated_at | **TIMESTAMP** | **No** |
| deleted_at | **TIMESTAMP** | **Yes** |

**Indexes:**

- **Index(user_id, created_at DESC)**
- **Partition by created_at (monthly)**

### Relationship Service Database Design

**(Follow/unfollow operations)**

**Relationships — (user_relationships)**

|     |     |     |     |
| --- | --- | --- | --- |
| Column | Type | Nullable | Description |
| follower_id | **BIGINT** | **No** | **Follower User ID** |
| followee_id | **BIGINT** | **No** | **Followed User ID** |
| created_at | **TIMESTAMP** | **No** | **Follow timestamp** |

**🔹 Composite PK: (follower_id, followee_id)**

**Indexes:**

- **Index(follower_id)**
- **Index(followee_id)**

**Partition by followee_id hash for scalability**

### Engagement Service Database Design

**Likes — (post_likes)**

|     |     |     |
| --- | --- | --- |
| Column | Type | Nullable |
| user_id | **BIGINT** | **No** |
| post_id | **BIGINT** | **No** |
| created_at | **TIMESTAMP** | **No** |

**PK: (user_id, post_id)**

**Comments — (post_comments)**

|     |     |     |
| --- | --- | --- |
| Column | Type | Nullable |
| id  | **BIGINT** | **No** |
| post_id | **BIGINT** | **No** |
| user_id | **BIGINT** | **No** |
| comment_text | **TEXT** | **No** |
| created_at | **TIMESTAMP** | **No** |
| parent_comment_id | **BIGINT** | **Yes (threading)** |
| deleted_at | **TIMESTAMP** | **Yes** |

**Indexes:**

- **Index(post_id, created_at)**
- **Index(user_id)**

**Partition comments by post_id hash or created_at monthly**

### Notification Service Database Design

**Notification Preferences — (user_notification_pref)**

|     |     |     |
| --- | --- | --- |
| Column | Type | Nullable |
| user_id | **BIGINT** | **No (PK)** |
| email_enabled | **BOOL** | **No** |
| push_enabled | **BOOL** | **No** |
| sms_enabled | **BOOL** | **No** |
| whatsapp_enabled | **BOOL** | **No** |
| created_at | **TIMESTAMP** | **No** |
| updated_at | **TIMESTAMP** | **No** |

**Notification Events — (notification_events)**

|     |     |
| --- | --- |
| Column | Type |
| id  | **BIGINT PK** |
| user_id | **BIGINT** |
| event_type | **VARCHAR(64)** |
| payload | **JSONB** |
| status | **SMALLINT (0=Queued,1=Sent,2=Failed)** |
| created_at | **TIMESTAMP** |
| sent_at | **TIMESTAMP** |
| retry_count | **INT** |

**Indexes:**

- **Index(user_id, created_at DESC)**
- **Index(status)**

**Partition by created_at (daily/weekly)**

### Ranking Service Database Design

**_(Internal — Analytics Model)_**

**This service does not store posts or relationships, only aggregated metrics.**

**User Ranking Metrics — (user_rank_metrics)**

|     |     |
| --- | --- |
| Column | Type |
| user_id | **BIGINT PK** |
| followers_count | **BIGINT** |
| engagement_score | **FLOAT** |
| trending_score | **FLOAT** |
| updated_at | **TIMESTAMP** |

**Indexes:**

- **Index(updated_at DESC)**

**This table is continuously updated from Event Hub  
No external writes — event driven only**

**Referential Integrity (Foreign Keys)**

| **From** | **To** | **On Delete** |
| --- | --- | --- |
| **posts.user_id** | **users.id** | **cascade** |
| **post_likes.user_id** | **users.id** | **cascade** |
| **post_likes.post_id** | **posts.id** | **cascade** |
| **post_comments.post_id** | **posts.id** | **cascade** |
| **user_relationships.follower_id** | **users.id** | **cascade** |
| **user_relationships.followee_id** | **users.id** | **cascade** |
| **notification tables.user_id** | **users.id** | **cascade** |

## API Design (RESTful) — Endpoint specification

### User Service

**✔ Create User**

POST /v1/users  
Request:

{

"username": "vikash",

"email": "vikash@example.com",

"password": "StrongPass123!",

"bio": "Software Engineer"

}

Responses:

- **201 Created**
- **409 Conflict** username/email exists

**✔ Get User Profile**

GET /v1/users/{userId}  
Response:

{

"id": 1,

"username": "vikash",

"bio": "Software Engineer",

"avatarUrl": "https://cdn/img.png",

"followersCount": 120,

"followingCount": 345

}

404 if not found

**✔ Update Profile**

PATCH /v1/users/{userId}  
Auth required

### Post Service

**✔ Create Post**

POST /v1/posts  
Request:

{

"content": "Hello world!",

"mediaUrl": "https://cdn.com/img.jpg"

}

Response 201 Created

Behavior:

- Write DB record
- Publish PostCreated event → Event Hub

**✔ Get Post**

GET /v1/posts/{postId}

**✔ Delete Post**

DELETE /v1/posts/{postId}

- 403 if not owner

**✔ Get User Posts**

GET /v1/users/{userId}/posts?page=1&size=20  
Paginated

### Relationship Service

**✔ Follow User**

POST /v1/users/{userId}/follow  
Request:

{

"followeeId": 25

}

Response 201 Created  
Behavior:

- Insert into user_relationships
- Emit event UserFollowed

**✔ Unfollow User**

DELETE /v1/users/{userId}/follow/{followeeId}

**✔ Get Followers**

GET /v1/users/{userId}/followers?page=1

**✔ Get Following**

GET /v1/users/{userId}/following?page=1

### Engagement Service

**Like Post**

POST /v1/posts/{postId}/like  
Response: 201 Created  
Event: PostLiked

**Remove Like**

DELETE /v1/posts/{postId}/like  
Response: 204 No Content

**Create Comment**

POST /v1/posts/{postId}/comments  
Request:

{

"commentText": "Nice post!",

"parentCommentId": 10

}

**List Comments**

GET /v1/posts/{postId}/comments?page=1&sort=recent

### Notification Service

**✔ List Notifications**

GET /v1/users/{userId}/notifications?page=1  
Response:

{

"items": \[

{

"id": 99,

"type": "PostLiked",

"title": "Your post was liked!",

"read": false,

"createdAt": "2025-12-02T09:00:00Z"

}

\]

}

**✔ Mark Notification as Read**

PATCH /v1/notifications/{notificationId}/read  
Response: 204 No Content

Behavior:

- Notifications generated ONLY by consuming **Post/Engagement/Relationship events** from Event Hub
- External delivery via **Azure Functions** for email / device Push

**✔ Update Notification Preferences**

PATCH /v1/users/{userId}/notifications/preferences  
Request:

{

"emailEnabled": true,

"pushEnabled": false

}

### Ranking Service

_(Internal scoring + external read-only)_

**✔ Get Trending Posts**

GET /v1/ranking/trending?page=1  
Response:

{

"posts": \[

{ "postId": 12, "score": 98.2 }

\]

}

**✔ Get Suggested Users**

GET /v1/ranking/suggestions/{userId}  
Response:

{

"suggestions": \[

{ "userId": 28, "reason": "Mutual followers" }

\]

}

# Chapter 21 — Video Sharing

In today’s streaming-driven digital landscape, access to personalized, high-quality video content is key to user engagement and platform growth. Video-sharing platforms rely on sophisticated recommendation systems and subscription feeds to surface new uploads, trending videos, and personalized suggestions. With billions of video views daily and countless uploads every minute, ensuring fast, relevant, and scalable content delivery presents major engineering challenges.

This engineering complexity is known as the Video Feed & Recommendation Problem — how to deliver personalized, continuously updated video suggestions while supporting enormous scale, rich metadata processing, and high availability.

## Overview

As video platforms expanded globally, several critical issues surfaced in building a world-class video feed and recommendation system:

**Goals**

- Primary goal: Deliver a highly personalized, real-time video feed with minimal latency and maximum uptime.
- Secondary goals: Handle billions of videos, multi-format streaming, global distribution, efficient metadata search, and interaction tracking (views, likes, comments, subscriptions, watch history, etc.)

**Massive Video Volume**

Users upload thousands of hours of video every minute. Each upload generates metadata → categories, thumbnails, captions, tags, watch signals → all of which must be processed, indexed, and made discoverable instantly.

**Personalization and Ranking Algorithms**

Not all videos match every user’s intent.

The system must:

- Rank content based on user behavior signals (watch history, likes, time watched)
- Evaluate content quality and safety
- Balance new content vs. highly engaging older content
- Avoid repetitive suggestions (diversity)

Recommendation models rely heavily on ML, user profiling, and real-time analytics.

**Latency and Streaming UX**

The feed must refresh quickly when:

- A subscribed creator uploads content
- A video trends globally
- A user’s interests shift based on new engagement

Slow or irrelevant recommendations lead to rapid disengagement and churn.

**Fan-out Delivery Challenges**

A single popular creator upload may need to reach millions of subscribers instantly.

Delivery options:

- Fan-out-on-write — push notifications and feed updates to subscribers immediately
- Fan-out-on-read — compute the feed dynamically when the app opens
- Often a hybrid approach is used based on popularity tiers

**Distributed Storage & Retrieval**

Systems must balance:

- Write-heavy workloads (video uploads)
- Read-intensive workloads (views, feed refreshes)

Key components:

- Global CDN networks for streaming
- Sharded object storage for large video binaries
- Metadata indexing for fast search and ranking

**Scalability & Global Availability**

Users expect seamless playback anywhere in the world.  
This requires:

- Multi-region replication
- Real-time caching of video metadata and feeds
- Load balancing to handle massive viewer spikes

High availability is crucial — downtime directly equals revenue loss.

**Engagement & Real-time Feedback Loops**

Likes, comments, subscriptions, watch duration, playlists → all must:

- Update engagement metrics instantly
- Feed back into recommendation and trending algorithms
- Adjust video quality serving and visibility

Streaming analytics must operate at high throughput and low latency.

## Requirements

The requirements for the Video Sharing System are divided into two categories: Functional Requirements and Non-Functional Requirements.

### Functional Requirements

- User registration, authentication, channel creation and subscription.
- Upload videos (chunked/resumable), metadata management (title, description, tags), and thumbnail uploads.
- Media processing: transcoding into multiple resolutions/bitrates, thumbnail generation, preview creation.
- Video storage and durable delivery via CDN with adaptive bitrate (HLS/DASH).
- Playback: low startup time, seeking, and smooth bitrate switching.
- Engagement: likes, comments, shares, view counters, and real-time notifications.
- Search and discovery: keyword search, trending lists, channel pages, playlists.
- Personalization: recommendation engine for home feed and up-next suggestions.
- Moderation and copyright workflows (DMCA, takedown, content ID-like matching).

### Non-Functional Requirements

- Scalability: support hundreds of millions of users, millions of uploads/day, and hundreds of millions of views/day.
- Availability: 99.99% (regional replication & CDN-based delivery).
- Latency: minimize startup delay (target <2s) and seek latency.
- Cost efficiency: tiered storage and smart encoding, minimize unnecessary egress.
- Security & Compliance: protect uploads, handle copyright, and comply with regional laws.

**Assumptions & Constraints**

- System handles pre-recorded videos (no live streaming scope here).
- Videos average ~10 minutes; average upload size ~50MB (varies by resolution and bitrate).
- Encoding pipeline must scale horizontally with transient worker fleets (GPU/CPU).
- Use cloud object storage for durable assets and CDN for delivery.

**Scale & Key Numbers (example)**

- Registered users: 100M.
- Daily uploads: 10M videos/day.
- Daily views: 500M views/day.
- Engagement events: 100M events/day (likes, comments, shares).
- Average video length: 10 minutes; encoded variants multiply storage by ~3x.

Implication: massive ingest and encoding throughput, huge storage and egress costs, and highly scalable metadata and analytics pipelines.

## Design Considerations

The Design Considerations outline key architectural decisions to ensure the Video Sharing System can efficiently manage uploads, media processing, feed personalization, engagement tracking, and global video delivery — while meeting demanding scalability, availability, and latency requirements.

These decisions address video ingest pipeline, distributed transcoding, metadata storage, CDN-based delivery, playback optimization, search/personalization mechanisms, and high-volume engagement processing.

### Video Ingest & Processing Pipeline

Uploading and processing large binary media at extreme scale requires a multi-stage pipeline:

**Chunked Upload & Durable Ingest**

- Videos uploaded in resumable chunks → temporary object storage
- Metadata (title, tags, visibility) stored immediately in metadata DB
- Upload completes → triggers processing event

**Event-Driven Media Processing**

- Azure Event Hub (or Kafka) triggers encoding workflow
- Azure Functions / GPU-enabled Kubernetes workers perform:
    - Multi-resolution transcoding (144p → 4K+)
    - Adaptive bitrate packaging (HLS, MPEG-DASH)
    - Thumbnail + preview generation
    - Safety/compression presets based on device analytics

⬆ Scalability: workers auto-scale based on queue backlog  
⬇ Cost: offload originals to cold storage after encoding completes

### Storage & Streaming Delivery

**Object Storage for Durability**

- Original and encoded variants stored in cloud object storage (e.g., Blob Storage)
- Lifecycle rules: hot → cool → archive tiers as content ages

**Content Delivery Network (CDN)**

- Edge caching ensures low latency playback worldwide
- Support for partial range requests → fast seek performance
- Signed URLs and tokenized access for private content

**Adaptive Bitrate Streaming**

Clients dynamically switch resolution based on:

- Network quality
- Buffer health
- Device capabilities

Target: Video start < **2 seconds**, smooth scrubbing

**Metadata & Search Indexing**

**Metadata Store**

- Videos indexed by ID, channel, tags, language, categories
- Stored in scalable distributed DB (Cosmos DB / DynamoDB / Spanner)
- Write-heavy during upload, read-heavy during browsing

**Full-Text Search Engine**

- ElasticSearch / OpenSearch / Azure Cognitive Search
- Supports:
    - Keyword queries
    - Autocomplete
    - Filtering (duration, upload date, popularity)

**Analytics-driven Ranking Signals**

- Views, watch duration, click-through rate → streamed into ML training pipelines

### Engagement & Notification Streams

Engagement generates massive real-time signals:

| **Event** | **Producer** | **Consumers** |
| --- | --- | --- |
| VideoUploaded | Upload Service | Encoding, Feed, Recommendation |
| VideoViewed | Playback Service | Analytics, Trending |
| Liked / Commented / Shared | Engagement Service | Notifications, Ranking |
| Subscribed | Channel Service | Notification, Feed |

Processing Characteristics:

- Append-only event logs for durability
- Batch and streaming analytics pipelines update ranking scores

### Feed Personalization & Recommendations

Personalization is crucial to user retention.

- **Home Feed** → ML-based collaborative filtering + watch history signals
- **Up-Next Suggestions** → real-time ranking based on:
    - Session interactions
    - Video similarity models (embedding-based)
    - Diversity heuristics to avoid repetition

**Hybrid Precomputation**

- Offline batch processing for deep personalization
- Real-time scoring adjustments during playback

### Caching Strategy

To minimize latency:

- CDN edge cache for popular videos
- Regional video manifest cache (Redis)
- Prefetch next segments during watch session
- Client-driven bitrate adaptation

**Cache Warmup Events**

- Trending or newly uploaded high-impact videos preloaded into CDNs

### Moderation & Compliance

To protect users & IP rights:

- Copyright detection pipeline (hash/fingerprint database)
- AI-based unsafe content flagging → human review queue
- Regional data retention, GDPR consent control

**DMCA Handling**

- Automated takedown workflows
- Audited versioning of uploads

### Security & Abuse Prevention

- OAuth2/JWT for user authentication
- Signed delivery tokens to prevent hotlinking
- Request throttling and bot detection
- Secure ingestion → HTTPS mandatory
- Content tampering prevention using checksums on upload

### Reliability & High Availability Architecture

- Multi-region replication for metadata
- Active-passive or active-active failover
- Graceful degradation: lower resolutions delivered if origin fails
- Eventual consistency acceptable for views/likes counters

**Availability Target**: **99.99%** uptime with zero data loss

### Cost Optimization Strategies

- Tiered storage policies (hot/cold/archive)
- Adaptive encoding based on popularity prediction
- Avoid unnecessary CDN egress via edge caching and regional peering
- Batch analytics to minimize compute costs

## High-level Architecture (components & flow)

## Database Design

### User Service Database Design

**Users Table — (users)**

|     |     |     |     |
| --- | --- | --- | --- |
| Column | Type | Nullable | Description |
| id  | BIGINT | No  | Primary key |
| username | VARCHAR(64) | No  | Unique handle |
| email | VARCHAR(256) | No  | Unique email |
| password_hash | VARCHAR(255) | No  | Secure hash |
| display_name | VARCHAR(128) | Yes | Display name |
| bio | TEXT | Yes | Profile bio |
| avatar_url | TEXT | Yes | Profile image |
| created_at | TIMESTAMP | No  | When account created |
| updated_at | TIMESTAMP | No  | Last modified |
| deleted_at | TIMESTAMP | Yes | Soft delete support |

**Indexes & Partitioning**

- UNIQUE(username), UNIQUE(email)
- INDEX(created_at DESC)
- No partitioning required for typical user table; use read-replicas for scale.

**Notes**

- Store authentication sessions/tokens in a separate secure store (Redis or dedicated auth DB).
- Minimal profile-only data kept here; heavy relationship loads go to Relationship Service.

### Upload Service Database Design

**Upload Sessions — (upload_sessions)**

|     |     |     |     |
| --- | --- | --- | --- |
| Column | Type | Nullable | Description |
| upload_id | UUID | No  | Primary key (client-visible) |
| user_id | BIGINT | No  | Owner |
| video_temp_path | TEXT | Yes | temp blob path prefix |
| total_bytes | BIGINT | Yes | expected size |
| uploaded_bytes | BIGINT | No  | progress |
| status | VARCHAR(32) | No  | UPLOADING/COMPLETED/FAILED |
| checksum | VARCHAR(128) | Yes | optional final checksum |
| metadata | JSONB | Yes | title, description, tags, privacy |
| created_at | TIMESTAMP | No  | created |
| updated_at | TIMESTAMP | No  | last progress |

**Indexes & Partitioning**

- INDEX(user_id, created_at DESC)
- TTL / cleanup job for expired sessions
- Use Redis for hot session state to minimize DB writes (persist occasionally)

**Notes**

- Actual chunks stored in Blob Storage (object store).
- On completion, Upload Service emits VideoUploaded event to Event Hub containing upload_id, user_id, metadata, and blob locations.

### Relationship Service Database Design

**Subscriptions / Followers — (subscriptions)**

|     |     |     |     |
| --- | --- | --- | --- |
| Column | Type | Nullable | Description |
| follower_id | BIGINT | No  | user who subscribed |
| channel_id | BIGINT | No  | subscribed-to channel (user id) |
| created_at | TIMESTAMP | No  | subscription timestamp |
| source | VARCHAR(64) | Yes | e.g., web, mobile |

**Primary Key & Indexes**

- Composite PK: (follower_id, channel_id)
- INDEX(channel_id) — to list subscribers
- INDEX(follower_id) — to list subscriptions

**Counts Cache — (subscriber_counts)**

|     |     |     |     |
| --- | --- | --- | --- |
| Column | Type | Nullable | Description |
| channel_id | BIGINT | No  | PK  |
| subscriber_count | BIGINT | No  | cached count |
| updated_at | TIMESTAMP | No  | last update |

**Partitioning**

- Partition subscriptions by channel_id hash for large-scale channels

**Notes**

- Relationship Service emits UserSubscribed and UserUnsubscribed events to Event Hub.
- Consider Redis sets for hot channels (very large follower lists) to accelerate fan-out and membership checks.

### Engagement Service Database Design

**View Events (append-only) — (view_events)**

|     |     |     |     |
| --- | --- | --- | --- |
| Column | Type | Nullable | Description |
| id  | BIGINT / UUID | No  | PK (append-only) |
| video_id | UUID/BIGINT | No  | referenced video |
| user_id | BIGINT | Yes | optional (anon) |
| region | VARCHAR(32) | Yes | optional |
| played_seconds | INT | Yes | watch progress |
| timestamp | TIMESTAMP | No  | event time |

**Real-time Counters (Redis / NoSQL) — (video_counters)**

|     |     |
| --- | --- |
| Key | Value |
| video:{id}:views | integer |
| video:{id}:likes | integer |
| video:{id}:dislikes | integer |

**Likes Table — (likes)**

|     |     |     |
| --- | --- | --- |
| Column | Type | Nullable |
| user_id | BIGINT | No  |
| video_id | UUID/BIGINT | No  |
| created_at | TIMESTAMP | No  |

PK: (user_id, video_id)  
Indexes: INDEX(video_id) for counts if necessary (but counters in Redis preferred)

**Comments Table — (comments)**

|     |     |     |
| --- | --- | --- |
| Column | Type | Nullable |
| id  | BIGINT | No  |
| video_id | UUID/BIGINT | No  |
| user_id | BIGINT | No  |
| text | TEXT | No  |
| created_at | TIMESTAMP | No  |
| parent_comment_id | BIGINT | Yes |
| deleted_at | TIMESTAMP | Yes |

Indexes:

- INDEX(video_id, created_at DESC)
- INDEX(user_id)

**Notes**

- Engagement Service writes append-only events into Event Hub (VideoViewed, VideoLiked, CommentCreated) for downstream aggregation, analytics, ranking and notifications.
- Counters stored in Redis are periodically flushed/aggregated into a durable store (data lake / analytics DB).

### Timeline Service Database Design

**Materialized Per-User Timeline — (user_timelines)**

|     |     |     |     |
| --- | --- | --- | --- |
| Column | Type | Nullable | Description |
| user_id | BIGINT | No  | PK / partition key |
| timeline_bucket | VARCHAR | No  | e.g., home, subscriptions, trending |
| items | JSONB / ARRAY | No  | ordered list of video_id + score + inserted_at |
| last_updated | TIMESTAMP | No  | last refresh |

**Feed Cache (Redis)**

- Key pattern: feed:user:{user_id}:home → list of video_id (LPUSH/LTRIM style)
- feed:user:{user_id}:subscriptions → list
- Use Redis lists or sorted sets (ZSET) with score for ordering

**Indexes & Partitioning**

- Partition user_timelines by user_id or by hash of user_id to spread load
- Evict/trim historical items to limit size (e.g., keep 1000 items per user)

**Notes**

- Timeline Service consumes events (VideoUploaded, UserSubscribed, UserUnsubscribed, Engagement events) and updates per-user timelines (fan-out or candidate generation).
- Write strategy: fan-out-on-write for small channels; fan-out-on-read or hybrid for very large channels.

### Notification Service Database Design

**User Notification Preferences — (user_notification_pref)**

|     |     |     |
| --- | --- | --- |
| Column | Type | Nullable |
| user_id | BIGINT | No (PK) |
| email_enabled | BOOL | No  |
| push_enabled | BOOL | No  |
| inapp_enabled | BOOL | No  |
| sms_enabled | BOOL | No  |
| created_at | TIMESTAMP | No  |
| updated_at | TIMESTAMP | No  |

**Notification Events — (notifications)**

|     |     |     |
| --- | --- | --- |
| Column | Type | Nullable |
| id  | BIGINT / UUID | No  |
| user_id | BIGINT | No  |
| type | VARCHAR(64) | No  |
| reference_id | TEXT | Yes |
| payload | JSONB | Yes |
| status | SMALLINT | No  |
| created_at | TIMESTAMP | No  |
| sent_at | TIMESTAMP | Yes |
| retry_count | INT | No  |

Indexes:

- INDEX(user_id, created_at DESC)
- INDEX(status)

Partitioning:

- Partition notifications by user_id or created_at (daily) depending on query patterns.

**Notes**

- Notification Service consumes events from Event Hub and persists them; Azure Functions or worker pools send external channels (push/email) and update status.
- Use a DLQ for failing sends.

## API Design (RESTful) — Endpoint specification

### User Service APIs

**Create User**

POST /v1/users  
Request:

{

"username": "vikash",

"email": "vikash@example.com",

"password": "StrongPass123!",

"displayName": "Vikash C"

}

Responses:

- 201 Created (user created)
- 409 Conflict if username/email exists  
    Behavior:
- Create user row in users table
- Return user id and profile (exclude password_hash)

**Get User Profile**

GET /v1/users/{userId}  
Response:

{

"id": 1,

"username": "vikash",

"displayName": "Vikash C",

"bio": "Software Engineer",

"avatarUrl": "...",

"subscriberCount": 12345

}

- 404 Not Found if not present

**Update Profile**

PATCH /v1/users/{userId}  
Auth required (owner)  
Behavior:

- Update fields in users table
- Emit UserProfileUpdated event (optional)

### Upload Service APIs

**Start/Initiate Upload Session**

POST /v1/uploads  
Request:

{

"userId": 123,

"metadata": {

"title": "My Video",

"description": "desc",

"tags": \["fun","vlog"\],

"privacy": "public"

},

"totalBytes": 52428800

}

Response:

- 201 Created:

{

"uploadId": "uuid-abc",

"uploadUrl": "https://.../upload/uuid-abc",

"expiresAt": "2025-12-31T00:00:00Z"

}

Behavior:

- Create upload_sessions row (status=UPLOADING)
- Return resumable upload URL (signed)

**Upload Chunk**

PUT /v1/uploads/{uploadId}/chunks  
Headers: Content-Range, etc.  
Responses:

- 200 OK (chunk accepted)
- 409/416 if range mismatch  
    Behavior:
- Write chunk to Blob Storage, update uploaded_bytes in upload_sessions (optionally in Redis then persist)

**Complete Upload**

POST /v1/uploads/{uploadId}/complete  
Response:

- 200 OK or 202 Accepted  
    Behavior:
- Validate checksum/size; set status=COMPLETED in DB
- Emit VideoUploaded event containing blob locations & metadata

**Get Upload Status**

GET /v1/uploads/{uploadId}  
Response:

{

"uploadId": "uuid",

"status": "UPLOADING",

"uploadedBytes": 1048576,

"totalBytes": 52428800,

"metadata": {...}

}

### Relationship Service APIs

**Subscribe (Follow Channel)**

POST /v1/users/{userId}/subscriptions  
Request:

{ "channelId": 789 }

Responses:

- 201 Created
- 409 Conflict if already subscribed  
    Behavior:
- Insert (follower_id=userId, channel_id) into subscriptions
- Increment subscriber_counts (atomic)
- Emit UserSubscribed event to Event Hub

**Unsubscribe**

DELETE /v1/users/{userId}/subscriptions/{channelId}  
Responses:

- 204 No Content success  
    Behavior:
- Delete subscription
- Decrement subscriber_counts
- Emit UserUnsubscribed event

**List Subscribers**

GET /v1/channels/{channelId}/subscribers?page=1&size=50  
Response: paginated list of userId + minimal profile

**List Subscriptions**

GET /v1/users/{userId}/subscriptions?page=1  
Response: channels user subscribes to

### Engagement Service APIs

**Record View (lightweight)**

POST /v1/videos/{videoId}/view  
Request (optional):

{ "userId": 123, "playedSeconds": 45 }

Responses:

- 202 Accepted  
    Behavior:
- Emit VideoViewed event to Event Hub (service does NOT synchronously increment durable counter)
- Optionally increment Redis real-time counter

**Like Video**

POST /v1/videos/{videoId}/like  
Request:

{ "userId": 123 }

Responses:

- 201 Created  
    Behavior:
- Insert (user_id, video_id) in likes table
- Increment Redis counter video:{id}:likes
- Emit VideoLiked event

**Remove Like**

DELETE /v1/videos/{videoId}/like?userId=123  
Responses:

- 204 No Content  
    Behavior:
- Delete like row, decrement Redis counter, emit VideoLikeRemoved event

**Create Comment**

POST /v1/videos/{videoId}/comments  
Request:

{

"userId": 123,

"text": "Nice video!",

"parentCommentId": null

}

Responses:

- 201 Created with comment id  
    Behavior:
- Insert row into comments, emit CommentCreated event

**List Comments**

GET /v1/videos/{videoId}/comments?page=1&size=20&sort=recent  
Response: paginated comments

### Timeline Service APIs

**Get Home Timeline (personalized)**

GET /v1/timelines/{userId}/home?page=1&size=20  
Response:

{

"userId": 123,

"items": \[

{ "videoId": "v-abc", "reason":"subscribed","score":98.2, "publishedAt":"2025-12-02T12:00:00Z" }

\],

"cursor": "opaque-cursor"

}

Behavior:

- Primary read path hits Redis feed cache feed:user:{id}:home; fallback to user_timelines DB
- If cache miss, compute candidate list (fan-out-on-read) or fetch materialized list
- Timeline Service subscribes to Event Hub to maintain materialized feeds and to apply updates (VideoUploaded,Subscribed,Engagement)

**Refresh Timeline / Pull-to-refresh**

POST /v1/timelines/{userId}/refresh  
Response:

- 202 Accepted (async refresh kicked)  
    Behavior:
- Trigger recompute for top N candidates (real-time scoring)

**Get Subscriptions Timeline**

GET /v1/timelines/{userId}/subscriptions?page=1

**Get Trending / Explore**

GET /v1/timelines/{userId}/explore?region=us&page=1

### Notification Service APIs

**List Notifications**

GET /v1/users/{userId}/notifications?page=1&size=20  
Response:

{

"items": \[

{ "id": "n-1", "type": "VideoUploaded", "title": "New video from X", "payload": {...}, "read": false, "createdAt":"..." }

\]

}

**Mark Notification Read**

PATCH /v1/notifications/{notificationId}/read  
Response:

- 204 No Content  
    Behavior:
- Update notifications.status=Read

**Update Notification Preferences**

PATCH /v1/users/{userId}/notifications/preferences  
Request:

{

"emailEnabled": true,

"pushEnabled": true,

"inappEnabled": true

}

Response:

- 204 No Content  
    Behavior:
- Update user_notification_pref

**Notification Delivery (internal)**

- Notification Service consumes Event Hub events (VideoUploaded, VideoLiked, UserSubscribed) and enqueues sends to Azure Functions or delivery processors.
- Delivery failures -> retry with exponential backoff and store attempts in delivery_logs.

# Chapter 22 — Chat System

In today’s communication-driven digital world, real-time messaging has become the backbone of personal, social, and business interactions. Modern chat platforms must deliver instant, reliable, and secure communication across millions of active devices, while maintaining seamless synchronization, presence awareness, and message history across multiple user endpoints. With billions of messages exchanged every day and tens of millions of concurrent connections, ensuring low-latency delivery, strong consistency, and end-to-end privacy introduces significant engineering challenges.

This engineering complexity is known as the Real-Time Messaging & Synchronization Problem — how to deliver fast, encrypted, and ordered messages to millions of users and devices, while supporting presence, multi-device sync, attachments, and high availability at massive global scale.

## Overview

This document outlines a high-level system design for a large-scale chat application capable of handling billions of messages per day and tens of millions of concurrent connections. It covers capacity estimates, key challenges (fan-out, presence, delivery semantics), architecture (connection gateways, routing, storage), data models, end-to-end encryption (E2EE), device sync, ordering and deduplication, monitoring, testing, and operational playbooks.

This design assumes the following baseline (from requirements):  
• 100M daily active users  
• 50 messages/user/day → 5,000,000,000 messages/day (average).  
• Peak multiplier 3x → 15,000,000,000 messages/day (peak day).  
• 20–30M concurrent online users during peaks.

Goals  
• Provide low-latency, reliable one-to-one and group messaging (sub-second for most messages).  
• Support tens of millions of persistent connections (WebSockets/HTTP2/QUIC) and graceful reconnection.  
• Guarantee clear delivery semantics (sent, delivered to device, delivered to user, read) and efficient storage/retrieval.  
• Support multi-device sync, deduplication, and ordering guarantees.  
• Support robust E2EE for private chats, and server-side encryption for metadata.  
• Be operationally observable and resilient to provider/infrastructure failures.

Terminology  
• Message: a single chat payload (text, media, reaction, sticker) from one client to another client or group.  
• Conversation: 1:1 chat or multi-user group with ordered messages.  
• Delivery receipt: acknowledgement that a message was delivered to a device or user.  
• Read receipt: acknowledgement that recipient consumed the message.  
• Fan-out: distributing a message to multiple recipients/devices.  
• Connection Gateway: front-line service managing persistent client connections (WebSocket/TCP/HTTP2/QUIC).  
• Device Registry: mapping user → device ids and active connections.  
• Sequence number: per-conversation, strictly increasing ID assigned to messages to provide ordering.

## Requirements

The requirements for the Chat System are divided into two categories: Functional Requirements and Non-Functional Requirements.

### Functional Requirements

- Real-time 1:1 messaging and group messaging.
- Persistent message storage and history retrieval (per conversation).
- Multi-device sync with per-device ordering and deduplication.
- Presence: per-device and per-user (online/offline/idle).
- Delivery receipts and read receipts.
- Attachments/media upload with CDN distribution and resumable uploads.
- End-to-end encryption for private chats (optional for groups), server-side encryption for metadata.
- Admin/moderation tools: reporting, message deletion (if allowed), retention enforcement (non-E2EE).
- Offline push notifications for devices not connected.
- Search within conversation history (optional advanced feature).

### Non-Functional Requirements (NFRs)

- **Scalability:** Support 100M DAU; handle 5B messages/day average and 15B/day peak.
- **Throughput:** Average ~57,870 msg/sec; peak average ~173,611 msg/sec (with bursts).
- **Latency:** Sub-second for most messages (P95 target ≤ 500 ms; local delivery often << 100 ms).
- **Availability:** Regional high availability with graceful degradation; target ≥ 99.99% for message ingress and delivery.
- **Durability:** Persist messages reliably with configurable retention; support replay/backfill.
- **Security:** TLS in transit, encryption at rest, secure key management for E2EE; token-based auth.
- **Consistency:** Strong ordering per-conversation (monotonic sequence numbers). Global strong consistency not required.
- **Maintainability:** Zero-downtime deployments, CI/CD, blue-green or canary.
- **Observability:** Metrics, logs, distributed tracing, alerting.
- **Cost:** Optimize storage and compute via tiering, batching, and selective fan-out.

## Design Considerations

Key design trade-offs and constraints that guide the architecture:

- **Fan-out vs cost**: Fan-out-on-write (eager) delivers fast device delivery but multiplies writes for large groups; fan-out-on-read (lazy) reduces writes at the cost of fetch latency. Use hybrid strategies.
- **Ordering & deduplication**: Per-conversation monotonic sequence numbers assigned at the server give ordering; client-generated IDs aid idempotency and dedup detection.
- **Durability vs latency**: Synchronous durable writes (strong durability) add latency. Use a durable append-only event log (Kafka/Pulsar) to decouple ingestion and durable processing for both persistence and replay.
- **E2EE vs moderation**: E2EE forbids server plaintext inspection, limiting content moderation. Provide non-E2EE options for managed groups and enterprise with server-side scanning.
- **Geo-distribution**: Local writes must be low latency; use regional gateways with local buffering and replication to global aggregate stores.
- **Attachment handling**: Offload media to object storage + CDN with signed URL uploads to avoid passing media payloads through core messaging pipelines.
- **Resource constraints**: Millions of persistent connections consume resources—optimize gateway footprint, connection multiplexing, and protocol choice (QUIC/http3 where beneficial).
- **Idempotency & retries**: Use unique message IDs + sequence numbers; upstream systems (ingress, brokers) should support deduplication and exactly-once where possible.

### Solution Approaches & Trade-offs

Below are plausible approaches for core subsystems (message ingestion, fan-out, storage, ordering). The recommended system uses a hybrid of these approaches.

**Message Ingress & Durability**

- **Approach A: Synchronous DB Writes (Strong Consistency)**
    - Simpler semantics but poor scale for writes at our target.
    - **Use-case:** Very small scale or critical counters.
- **Approach B: Append-only Event Log + Stream Processing (Recommended)**
    - Client → Gateway → Append to durable log (Kafka/Pulsar) → Stream processors materialize state and persist to DB.
    - Allows durable, replayable events and decouples ingestion from persistence.
    - **Trade-off:** Operational complexity but excellent for scale, replay, and analytics.

**Fan-out**

- **Fan-out-on-write**: When message arrives, push to each recipient/device. Low delivery latency; high write amplification for large groups. Use for 1:1 and small groups.
- **Fan-out-on-read (Lazy fan-out)**: Store message and generate per-device delivery on demand. Lower write amplification; may add read latency. Use for very-large groups, broadcast channels.
- **Hybrid**: Eager for small groups, lazy for large groups. Use thresholds (e.g., > N members) to switch.

**Ordering & Deduplication**

- **Server-assigned sequence numbers per conversation** for strict ordering.
- **Client message IDs (UUIDs)** for de-dup and idempotency.
- **Gap-detection & sync**: clients detect missing sequences and request missing messages via sync API.

**Storage Model**

- **Hot store** (low-latency): wide column DB (Cassandra/Scylla) for recent messages and per-conversation reads.
- **Cold store**: object storage (S3) or long-term column-store/warehouse for archived messages and attachments.
- **Materialized views**: Stream processors produce pre-aggregated views (recent N messages, unread counts) for fast reads.

**E2EE**

- **Server stores only ciphertext and metadata**; key server manages public keys and prekeys; devices handle encryption/decryption.
- **Server can support server-side-encrypted (non-E2EE) flows** for enterprise moderation.

## Storage & Retention Strategy

**Retention Policy**

- Default message retention: **configurable per tenant/user** (e.g., 30 days, 1 year, 5 years).
- E2EE messages: server stores ciphertext; retention rules still apply to ciphertext but content inaccessible.

**Data Tiers**

1.  **Hot Tier (recent N days or recent M messages)**
    - Store in hot DB (Cassandra/Scylla or Redis for extremely recent).
    - Optimized for low-latency reads and writes.
2.  **Warm Tier (older but frequently accessed)**
    - Compacted aggregates in column store; partial data in hot store.
3.  **Cold Tier (archive)**
    - S3/Blob storage with compressed, batched message archives (per conversation/day).
    - Indexed using metadata to support rehydration on demand.

**Retention & Deletion**

- **TTL policies** at storage layer for automated deletion.
- **Legal hold** or compliance retention exceptions for flagged content.
- **Deletion semantics**: For E2EE, deletion removes ciphertext pointers; for non-E2EE, delete from hot and cold stores and purge indexes.

**Storage Estimates (ballpark)**

- Avg message size (metadata + text) ≈ 500 bytes (text only; attachments separate).
- 5B messages/day × 500 B ≈ 2.5 TB/day raw data. Over 5 years: ~4.56 PB (without compaction/retention) — **note**: this is huge; we will use compaction, rollups, and retention rules to manage storage.
- **Compression & aggregation**: Compression (gzip/snappy), storing diffs, or summarizing reduces footprint significantly.
- **Attachments**: Stored in object storage; stored separately with CDN links.

Important: earlier URL-shortener conversation used 912 GB — that was for a smaller write volume. For chat at 5B msgs/day, storage must be planned carefully. Use retention, TTLs, and aggregation.

**Cache Strategy**

Caching reduces read latency and reduces load on storage and fan-out workers.

**Cache Layers**

1.  **Edge/Client Cache**
    - Clients cache last-seen sequence numbers and recent N messages per conversation.
2.  **Gateway-local Cache**
    - Gateways keep per-connection small caches for immediate resends and reconnection sync.
3.  **Global Cache (Redis/Memcached)**
    - Materialized recent message fragments, unread counts, conversation metadata (hot keys).
4.  **CDN for Attachments**
    - Media assets delivered via CDN; signed URLs for upload and access.

**What to Cache**

- Recent N messages per conversation (sliding window), unread counts, presence snapshot, user profile thumbnails, small metadata (conversation title, participants).
- Avoid caching entire conversation history for large groups.

**Cache Eviction & Consistency**

- Use short TTLs for message caches (minutes/hours) and invalidate on updates (edits, deletes).
- For presence, use TTL-based key refresh; presence keys expire if no heartbeat.
- Use write-through for small critical counters (unread counts) or use atomic Redis ops (INCR/DECR).

## High-Level Architecture & Components

**Main Components**

- **Clients**: mobile, web, desktop. Use WebSockets/HTTP2/QUIC for persistent connections.
- **Global Load Balancers**: route clients to the nearest region and gateway.
- **Connection Gateways (WebSocket/QUIC Gateways)**: manage persistent connections, authentication, heartbeat, backpressure, and local buffering.
- **Auth Service**: token issuance, refresh, rate-limiting.
- **Device Registry**: maps user → device IDs → gateway nodes, active connection metadata, push tokens, identity keys.
- **Ingress API / Message API**: receives messages and does initial validation; forwards to durable log.
- **Durable Event Log (Kafka/Pulsar)**: append-only, partitioned, durable storage for events.
- **Pub/Sub Router**: routes messages from event log to interested consumers and fan-out workers.
- **Fan-out Workers**: deliver messages to recipient devices (eager) or generate notifications for lazy delivery; scale horizontally.
- **Stream Processors**: materialize views, compute unread counts, aggregate metrics, persist to hot store.
- **Hot Store**: Cassandra/Scylla for per-conversation message reads/writes.
- **Cold Archive**: S3 or object storage for archived message batches and attachments.
- **Presence Service**: in-memory (Redis) for TTL-based presence keys and aggregation.
- **Sync Service**: handles multi-device sync and gap repairs.
- **Media Service**: presigned uploads to object storage, virus scans (non-E2EE), and CDN integration.
- **Key Server**: manages E2EE public keys, prekeys, and rotation for end-to-end encrypted conversations.
- **Notification Service**: push notifications for offline devices (APNs/Firebase).
- **Observability Stack**: metrics (Prometheus), tracing (Jaeger), logs (ELK/EFK), alerting.
- **Admin & Moderation Tools**: reporting UI, content moderation workflows (non-E2EE only).

**Message Flow (High-level)**

1.  Client sends message → Gateway (auth + validation).
2.  Gateway forwards message event → Durable event log (Kafka) (ack to client after append or after local ack policy).
3.  Fan-out workers consume event and:
    - For small groups/1:1: push to recipient device connections (gateway → client).
    - For large groups: write to per-conversation hot store and notify devices as needed (lazy fan-out).
4.  Stream processors update materialized views (recent messages, unread counts).
5.  Hot store persists message fragments for fast read.
6.  Cold archive jobs compact older messages and write to S3 according to retention policy.
7.  Notification service sends push notifications for offline devices.

**Data Flow (Detailed)**

1.  **Client → Gateway**
    - TLS + token-based auth.
    - Gateway validates token, checks rate limits, and writes to durable log. Optionally assign sequence number (or delegated to message ordering service).
2.  **Gateway → Append Log**
    - Message event {conversationId, senderId, clientMsgId, timestamp, payloadRef/ciphertext, metadata} appended to Kafka partition (partitioned by conversationId for ordering).
3.  **Durable Log → Fan-out Workers / Stream Processors**
    - Fan-out workers consume the partition; ensure idempotency via clientMsgId.
    - Stream processors update materialized views and persist to hot store.
4.  **Fan-out → Gateway(s)**
    - Fan-out workers route messages to recipient device gateway nodes via device registry.
    - If recipient offline: store delivery status; trigger push notification.
5.  **Hot Store / Cache Read**
    - Clients request conversation history from hot store or caches; sync service repairs gaps by fetching from hot store or replaying events.
6.  **Cold Archive**
    - Periodic compaction jobs move older messages from hot store into cold archive and purge hot shards per retention rules.

## Database Design

Use a polyglot persistence approach: wide-column DB (Cassandra/Scylla) for hot path, relational DB for user data, Redis for presence and short-lived state, object store for attachments.

**User Service (Relational)**

users

\- user_id (bigint) PK

\- username (text) UNIQUE

\- phone (text) UNIQUE

\- email (text) UNIQUE

\- profile_name (text)

\- avatar_url (text)

\- created_at (timestamp)

\- settings (json)

**Devices**

devices

\- device_id (uuid) PK

\- user_id (bigint) FK

\- gateway_node (text)

\- push_token (text)

\- last_seen (timestamp)

\- identity_key (blob) // E2EE public key

\- created_at (timestamp)

**Conversations (Relational / Metadata)**

conversations

\- conversation_id (uuid) PK

\- type (enum: direct/group)

\- created_at (timestamp)

\- owner_id (bigint)

\- topic (text)

\- member_count (int)

\- retention_policy (json)

conversation_participants

\- conversation_id (uuid) PK

\- user_id (bigint) PK

\- role (enum: admin/member)

\- joined_at (timestamp)

**Messages (Wide-column — primary hot store)**

Partition by conversation_id, cluster by sequence_number DESC for fast recent reads.

messages (Cassandra-style)

PK: (conversation_id)

Clustering: (sequence_number DESC)

Columns:

\- sequence_number (bigint)

\- message_id (uuid) // server assigned or client-provided

\- client_msg_id (uuid) // idempotency

\- sender_id (bigint)

\- timestamp (timestamp)

\- payload_ref (text) // pointer to ciphertext or inline payload

\- metadata (json) // e.g., message type, attachment refs

\- status (map&lt;device_id, status&gt;) // optional, or stored in receipts table

**Delivery Receipts**

delivery_receipts

PK: (conversation_id, sequence_number, device_id)

\- status (enum: delivered/read)

\- updated_at (timestamp)

**Presence (Redis)**

- Key: presence:user:{user_id}:device:{device_id} -> {gateway_node, last_seen, status} TTL-based.
- Aggregation: presence:user:{user_id} -> aggregated state computed by presence service.

**Attachments (Object Storage)**

- attachments table (relational) for metadata:

attachments

\- attachment_id (uuid) PK

\- conversation_id (uuid)

\- uploader_id (bigint)

\- storage_url (text)

\- mime_type (text)

\- size (bigint)

\- created_at (timestamp)

\- virus_scan_status (enum) // for non-E2EE

**Indexing & Search**

Optional small search index for message text or metadata using a search engine (Elasticsearch/OpenSearch) populated by stream processors (only for non-E2EE or enterprise).

## API Design

Use REST/gRPC for control APIs and WebSocket/QUIC for real-time message channels. Below are core endpoints (REST/gRPC summaries). Use versioning (/v1).

**Authentication & User**

- POST /v1/auth/register — register user (returns user_id).
- POST /v1/auth/login — authenticate device, returns access token + refresh token.
- POST /v1/auth/refresh — refresh tokens.
- GET /v1/users/{userId} — get user profile.
- PATCH /v1/users/{userId} — update profile.

**Device Management**

- POST /v1/devices — register device (device_id, identity_key, push token).
- DELETE /v1/devices/{deviceId} — deregister device.
- GET /v1/devices/{userId} — list devices and last-seen.

**Conversation Management**

- POST /v1/conversations — create conversation (direct or group).
- GET /v1/conversations/{conversationId} — get conversation metadata.
- POST /v1/conversations/{conversationId}/participants — add participant.
- DELETE /v1/conversations/{conversationId}/participants/{userId} — remove participant.

**Messaging (Realtime + REST)**

Realtime (WebSocket/QUIC):

- Client connects to Gateway with token, opens per-user session.
- SEND event: {conversationId, clientMsgId, payload, timestamp, attachments} — gateway forwards to append log.

REST (fallback/history):

- POST /v1/messages/send — (HTTP) send message (uses same event schema).
- GET /v1/conversations/{id}/messages?cursor={}&limit={} — retrieve paginated history.
- POST /v1/messages/{conversationId}/{sequence}/receipt — update delivery/read receipts.

**Sync & Gap Repair**

- GET /v1/sync/{userId}?since_sequence={} — return messages and state changes since last known sequence per conversation (per-device granularity optional).

**Presence & Presence APIs**

- POST /v1/presence/update — heartbeat update (gateway usually handles).
- GET /v1/presence/{userId} — aggregated presence.

**Media**

- POST /v1/media/upload/initiate — returns signed upload URL and upload id.
- POST /v1/media/complete — finalize upload (triggers processing and CDN invalidation).

**E2EE Keys**

- GET /v1/keys/{userId} — fetch public prekeys for session setup.
- POST /v1/keys/upload — upload identity/provisioning keys.

**Admin**

- GET /v1/admin/reports — fetch abuse reports.
- POST /v1/admin/retention — set retention policies per conversation/tenant.

**Reliability, Availability & Security**

**Reliability & High Availability**

- **Multi-region deployment** with active-active or active-passive depending on latency and consistency needs. Use region-local gateways with cross-region replication for durable store.
- **Durable append log** (Kafka/Pulsar) with replication factor > 2 for fault tolerance.
- **Hot store** should be deployed as a cluster with replication and careful partitioning.
- **Stateless services** for fan-out and gateways where possible to enable horizontal scaling and rolling upgrades.
- **Backpressure & circuit-breakers** to protect critical paths (auth, DB) during overload.

**Consistency & Ordering**

- Partition event log by conversationId ensures ordering per conversation.
- Server-assigned sequence numbers prevent concurrent ordering issues. Use monotonically increasing counters per partition.

**Security**

- **Transport**: TLS for all client-server and server-server communication.
- **Authentication**: OAuth2/JWT tokens with short TTLs for gateways.
- **Authorization**: RBAC for admin APIs and fine-grained checks for conversation access.
- **E2EE**: Out-of-band key exchange, prekeys for offline messaging; server never stores plaintext for E2EE chats.
- **Data protection**: Encryption at rest (hot store and cold), key management (KMS/HSM), and strict IAM controls.
- **Abuse prevention**: Rate limiting, anomaly detection, CAPTCHAs for suspicious flows, content scanning for non-E2EE flows.

**Compliance**

- **Data residency** support—store data as per regional laws.
- **Retention & legal hold**: support for enforced retention and legal holds.
- **Audit logs**: immutable logs for admin actions and access for compliance audits.

**Monitoring & Observability**

Key metrics, tracing points, and alerts:

**Metrics**

- Ingest throughput (msgs/sec) and consumer throughput.
- Gateway connection count, per-node.
- Consumer lag for durable log (Kafka consumer lag).
- Message delivery latency (client to delivery).
- Error rates (per endpoint).
- Disk/IO usage, GC and heap for JVM services.
- Hot store read/write latencies and timeouts.
- Number of replays and reconciliations.

**Tracing & Logs**

- Distributed tracing (Jaeger) for request flows across gateway → log → stream processors → storage.
- Structured logs (ELK/EFK) with request ids and message ids.

**Alerts**

- Consumer lag > threshold.
- Gateway memory/FD exhaustion.
- Rapid increase in unacked messages.
- Elevated error rates or 5xx responses.
- Storage thresholds (disk).
- Security alerts (suspicious login patterns, key compromises).

**Health & Runbooks**

- Automated health checks for gateways and consumer groups.
- Runbooks for consumer lag, partition rebalancing, lost replicas, and data reconciliation.

**Scalability & Cost Optimization**

**Horizontal Scaling Strategies**

- **Stateless front-ends** (gateways, fan-out workers) scale horizontally behind load balancers.
- **Partitioning**: Kafka topics partitioned by conversationId. Cassandra partitioning by conversationId.
- **Auto-scaling** fans and processors based on consumer lag and CPU.
- **Sharding thresholds**: split very hot groups across multiple sharding strategies (time-based or sub-conversation partition).

**Cost Optimizations**

- **Hybrid fan-out**: eager for small groups; lazy for huge groups (e.g., channels with >10k members).
- **Storage tiering**: keep recent data hot and archive older data; compress archived data.
- **Attachment lifecycle**: TTL/auto-delete for low-value attachments; store thumbnails instead of full images where appropriate.
- **Batch writes**: batch persistence and group updates to reduce IOPS and message broker overhead.
- **Use spot/preemptible VMs** for non-critical batch/processing tasks.

# Chapter 23 — **Notification** System

In today’s event-driven digital ecosystem, timely and relevant notifications are essential for user engagement, platform responsiveness, and operational visibility. Applications rely on multi-channel messaging—email, SMS, push, and in-app—to deliver alerts, confirmations, reminders, and personalized updates. Achieving this at massive scale requires a robust event ingestion pipeline, flexible templating, fine-grained user preferences, delivery retries, idempotency safeguards, and real-time observability.  
This engineering challenge is known as the **Notification Delivery Problem**—how to reliably transform high-volume events into personalized, localized, multi-channel notifications while ensuring compliance, respecting user preferences, and gracefully handling provider bottlenecks under heavy load.

## Overview

As platforms grow into global, multi-service ecosystems, the volume and diversity of notification events expand dramatically. Systems must process events from numerous upstream producers, evaluate user preferences, apply localization rules, choose optimal delivery channels, render templates efficiently, and deliver at scale—even when downstream SMS/email providers throttle or fail. Ensuring consistency, reliability, and compliance across regions introduces additional operational complexity.

**Goals**  
• Deliver event-driven notifications reliably across multiple channels.  
• Respect user preferences, localization settings, and quiet-hour rules.  
• Provide modular templates and dynamic personalization.  
• Support scalable ingestion, retry workflows, and durable storage.  
• Achieve high throughput with real-time visibility and operational resilience.

**Multi-Channel Delivery Complexity**  
Each provider (email, SMS, push) has different constraints, throughput, latency, and throttling behavior. The system must route intelligently, batch where practical, and support failover paths.

**User Preference Enforcement**  
Users may disable specific channels, enforce quiet hours, or require different templates based on locale. The system must validate preferences before every delivery attempt.

**Event Bursts & Backpressure**  
High-volume upstream events—such as flash sales, marketing campaigns, or system alerts—can create sudden spikes. The system must buffer, autoscale, and maintain delivery guarantees even under extreme load.

**Idempotency & Duplicate Suppression**  
Retries across providers can generate duplicate notifications. The system must enforce idempotency at event, notification, and channel levels.

**Compliance & Regional Regulations**  
Handling opt-in/opt-out, DND rules, GDPR, and regional privacy laws adds significant operational overhead and technical guardrails.

**External Provider Constraints**  
Rate limits and quota errors at email/SMS providers must be gracefully mitigated through buffering, retry schedules, fallback routes, or deferred sending.

## Requirements

### Functional Requirements

• Accept events from multiple internal services.  
• Map incoming events to one or more notification actions (channel + template).  
• Support email, SMS, push, and in-app notifications.  
• Enforce user channel preferences, DND settings, and localization.  
• Support scalable template rendering with personalization parameters.  
• Provide durable retry handling and DLQ for failed attempts.  
• Provide APIs for ad-hoc/custom notifications.  
• Capture delivery receipts, outcomes, and analytics.  
• Maintain idempotency across retries and multi-channel interactions.

### Non-Functional Requirements

• Scalability: handle ~100M notifications/day, peak 300M/day.  
• Reliability: at-least-once delivery with idempotent suppression.  
• Latency: majority delivered within seconds; allow batching where applicable.  
• Security: encrypt PII, authenticate APIs, support RBAC for admin actions.  
• Extensibility: easy to add new channels and new providers.  
• Observability: metrics, distributed tracing, logs, and audit trails.

**Constraints & Challenges**  
• Provider rate limits (SMS, email) may throttle throughput.  
• Users may configure per-event and per-channel preferences.  
• Large event bursts may overwhelm providers and internal queues.  
• Need to maintain idempotency across retries and channel-specific failures.  
• Must comply with regional notification policies (GDPR, opt-in rules).

**Scale & Capacity Estimates (example)**  
• Daily active users: ~10M.  
• Avg events per user/day: 5.  
• Avg channels per event: 2.  
• Notifications/day = 10M × 5 × 2 = 100M.  
• Peak factor ~3x → 300M/day.  
• Average throughput: ~1,160 notifications/sec.  
• Provider throttling requires buffering and autoscaling consumers.

## Design Considerations

Event-driven notification systems require a blend of durable pipelines, channel abstraction, dynamic template rendering, compliance enforcement, and sophisticated retry logic to ensure consistent delivery despite external provider variability.

**Event Ingestion & Routing**

Events arrive from multiple producers and are ingested into a durable log (Kafka/Pulsar). A routing layer maps event types to appropriate notification actions, templates, and channels.

**Template Rendering Engine**

Templates support localization, personalization tokens, and dynamic variables. Rendering occurs asynchronously and can be cached for common variants. Must support HTML (email), plain text (SMS), and structured JSON (push).

**User Preferences & Policies**

Preferences include enabled channels, locales, quiet hours, opt-in requirements, frequency caps, and per-event overrides. Before delivering any notification, the system validates compliance with these rules.

**Channel Abstraction Layer**

Each channel—email, SMS, push, in-app—is implemented as a pluggable module behind a unified interface. Provider-specific throttling, failover routing, and priority rules are encapsulated.

**Retry Logic & DLQ**

Failed deliveries follow exponential backoff and jitter. After N attempts, messages are moved to DLQ. Operators can replay DLQ messages after analysis.

**Idempotency & Deduplication**

Each notification has a globally unique ID. The system tracks delivery attempts per user, per channel, and suppresses duplicates across retries or provider failures.

**Batching & Throughput Optimization**

Batch email and push dispatch where possible. SMS may require strict sequential delivery per provider contract. Pre-fetch templates and preload provider credentials for low latency.

**Security & Privacy**

Encrypt PII at rest. Use TLS everywhere. Apply RBAC for admin APIs and enforce audit trails. Ensure template parameters are sanitized to avoid injection vulnerabilities.

**Monitoring, Tracing & Alerting**

Metrics track throughput, provider latency, bounce rates, throttling, retry volumes, DLQ counts, and delivery success rates. Full distributed tracing identifies bottlenecks in ingestion, rendering, and channel delivery.

**Reliability & High Availability**

Multi-region clusters ensure continuity even when providers fail regionally. Queues auto-replicate; channel workers autoscale horizontally.

**Cost Optimization**

Batch sends, provider rate negotiation, adaptive retry schedules, template caching, and cold storage for long-term logs reduce operational costs.

## High-level Architecture (components & flow)

• Event Producers (Order Service, Auth Service, Messaging, Billing, etc.)  
• API Gateway  
• Event Ingestion Layer (Kafka/Pulsar)  
• Notification Router  
• Template Rendering Service  
• User Preferences Service  
• Channel Orchestrator  
• Channel Providers (SES, Twilio, FCM/APNS)  
• Retry Engine & DLQ  
• Notification Logs Store  
• Observability Stack (Metrics, Tracing, Audit)

Flow: Event → Router → Template Engine → Preferences → Channel Orchestrator → Provider → Delivery Receipt → Analytics.

## Database Design

### User Preferences Database Design

  
**user_preferences**

|     |     |     |
| --- | --- | --- |
| Column | Type | Notes |
| user_id | bigint | Primary key |
| channels_enabled | json | Flags for email/sms/push/in-app |
| locale | text | e.g., en-US, fr-FR |
| quiet_hours | json | Start/end in user’s local timezone |
| dnd | boolean | Do-not-disturb |
| created_at | timestamp |     |

### Templates Database Design

  
**templates**

|     |     |     |
| --- | --- | --- |
| Column | Type | Notes |
| template_id | uuid | Primary key |
| name | text | Unique template identifier |
| channel | text | email/sms/push/in-app |
| locale | text | Supports localization rules |
| body | text | Template HTML/text/JSON |
| metadata | json | Subject, headers, priority, etc. |
| created_at | timestamp |     |

### Event & Notification Mapping Database Design

**event_actions**

|     |     |     |
| --- | --- | --- |
| Column | Type | Notes |
| event_type | text | Primary key (e.g., ORDER_PLACED, LOGIN_ALERT) |
| channel | text | Target delivery channel |
| template_id | uuid | FK → templates |
| priority | int | Higher means more urgent |
| metadata | json | Optional routing/config data |

### Notification Logs Database Design

**notification_logs**

|     |     |     |
| --- | --- | --- |
| Column | Type | Notes |
| notification_id | uuid | Primary key |
| user_id | bigint |     |
| channel | text | email/sms/push/in-app |
| status | text | delivered / failed / throttled / pending |
| provider_response | json | Raw provider callback data |
| attempt_count | int | Number of attempts so far |
| created_at | timestamp |     |
| updated_at | timestamp |     |

### DLQ Storage Design

**dlq_notifications**

|     |     |     |
| --- | --- | --- |
| Column | Type | Notes |
| notification_id | uuid | Primary key |
| payload | json | Original message & metadata |
| failure_reason | text | Provider failure / validation / timeout |
| retries | int | Number of failed attempts |
| created_at | timestamp |     |
| last_attempt | timestamp |     |

### Provider Configuration Database Design

**provider_configs**

| **Column** | **Type** | **Notes** |
| --- | --- | --- |
| provider_id | text | Primary key (SES, Twilio, FCM, APNS) |
| credentials | json | Encrypted provider credentials |
| rate_limits | json | Per-minute/hour/day provider constraints |
| enabled | boolean | Toggle provider availability |
| created_at | timestamp |     |

### Channel Queue Metadata (Optional)

**channel_queue_state**

|     |     |     |
| --- | --- | --- |
| Column | Type | Notes |
| channel | text | email/sms/push/in-app |
| backlog_size | bigint | Approx queue depth for autoscaling |
| updated_at | timestamp |     |

### Ad-hoc Notification Requests

**custom_notifications**

|     |     |     |
| --- | --- | --- |
| Column | Type | Notes |
| request_id | uuid | Primary key |
| user_id | bigint |     |
| channel | text | email/sms/push/in-app |
| template_id | uuid | FK → templates |
| parameters | json | Personalization tokens |
| status | text | queued / processing / completed / failed |
| created_at | timestamp |     |
| updated_at | timestamp |     |

### User Locale & Regional Rules

**regional_rules**

|     |     |     |
| --- | --- | --- |
| Column | Type | Notes |
| region | text | Primary key (e.g., EU, IN, US) |
| dnd_policies | json | Country/region-specific rules |
| sms_limits | json | Per-provider/country SMS throttling rules |
| compliance | json | GDPR/opt-in/opt-out requirements |
| updated_at | timestamp |     |

### Notification Preference Overrides (Per Event)

**preference_overrides**

|     |     |     |
| --- | --- | --- |
| Column | Type | Notes |
| user_id | bigint | PK composite |
| event_type | text | PK composite |
| channel_rules | json | Enable/disable channels specifically for event |
| locale | text | Optional override locale |
| updated_at | timestamp |     |

## API Design (RESTful) — Endpoint specification

### Event Ingestion Service APIs

**POST /v1/events**

**Description:**  
Ingests an event from an upstream service. The event is validated, persisted, and published to the event routing stream.

**Request Body (JSON):**

{

"eventType": "ORDER_PLACED",

"eventId": "d93f3e51-2fa9-4e9f-9c18-bc4e3f1a8f23",

"userId": 128991,

"payload": {

"orderId": "A12398",

"amount": 199.99

},

"timestamp": "2025-01-05T12:32:00Z"

}

**Response Body (JSON):**

{

"status": "accepted",

"eventId": "d93f3e51-2fa9-4e9f-9c18-bc4e3f1a8f23",

"queuedAt": "2025-01-05T12:32:01Z"

}

**Behaviour:**  
• Validates event type.  
• Ensures idempotency using eventId.  
• Publishes to event stream for routing.  
• Returns 202 Accepted for async workflow.

### Notification Orchestrator Service APIs

**POST /v1/notifications/send**

**Description:**  
Sends an ad-hoc notification using a chosen template and channel.

**Request Body (JSON):**

{

"userId": 128991,

"channel": "email",

"templateId": "PASSWORD_RESET",

"parameters": {

"username": "john",

"resetLink": "https://example.com/reset"

}

}

**Response Body (JSON):**

{

"notificationId": "0acbb65e-68f4-4885-a27d-616285a07a50",

"status": "queued"

}

**Behaviour:**  
• Evaluates user preferences (locale, quiet hours, channel restrictions).  
• Loads template and performs server-side rendering.  
• Queues the notification for delivery.  
• Enforces idempotency using (userId, templateId, parameters) hash.

**GET /v1/notifications/{notificationId}**

**Description:**  
Returns the status and history of a notification.

**Response Body (JSON):**

{

"notificationId": "0acbb65e-68f4-4885-a27d-616285a07a50",

"userId": 128991,

"channel": "email",

"status": "delivered",

"attempts": \[

{

"attempt": 1,

"status": "throttled",

"timestamp": "2025-01-05T12:40:02Z"

},

{

"attempt": 2,

"status": "delivered",

"timestamp": "2025-01-05T12:40:18Z"

}

\]

}

**Behaviour:**  
• Aggregates logs from delivery receipts and retry history.  
• Provides audit information.

### Preferences Service APIs

**GET /v1/preferences/{userId}**

**Description:**  
Returns the user’s notification preferences.

**Response Body (JSON):**

{

"userId": 128991,

"channelsEnabled": {

"email": true,

"sms": false,

"push": true,

"inApp": true

},

"locale": "en-US",

"quietHours": {

"start": "22:00",

"end": "07:00"

},

"dnd": false

}

**Behaviour:**  
• Fetches preferences from user_preferences.  
• Returns defaults if user has no overrides.

**PUT /v1/preferences/{userId}**

**Description:**  
Updates the user’s notification preferences.

**Request Body (JSON):**

{

"channelsEnabled": {

"email": false,

"sms": true,

"push": true

},

"locale": "fr-FR",

"quietHours": {

"start": "23:00",

"end": "06:00"

},

"dnd": true

}

**Response Body (JSON):**

{

"status": "updated"

}

**Behaviour:**  
• Validates user selections.  
• Ensures channel compliance with regional rules.  
• Updates stored preferences with audit tracking.

### Template Management Service APIs

**POST /v1/templates**

**Description:**  
Creates a new notification template.

**Request Body (JSON):**

{

"name": "ORDER_CONFIRMATION",

"channel": "email",

"locale": "en-US",

"body": "&lt;p&gt;Hello {{name}}, your order {{orderId}} has been placed.&lt;/p&gt;",

"metadata": {

"subject": "Order Confirmation"

}

}

**Response Body:**

{

"templateId": "b2cdc676-badc-4427-a54f-df49f75e2341",

"status": "created"

}

**Behaviour:**  
• Stores template + metadata.  
• Validates placeholders for safety.

**PUT /v1/templates/{templateId}**

**Description:**  
Updates an existing template.

**Request Body (JSON):**

{

"body": "&lt;p&gt;Hi {{name}}, your order {{orderId}} is confirmed!&lt;/p&gt;",

"metadata": {

"subject": "Your Order Confirmation"

}

}

**Response Body (JSON):**

{

"status": "updated"

}

**Behaviour:**  
• Ensures compatibility with previous placeholders.  
• Tracks versioning for rollback if needed.

### Delivery Provider Callback APIs

**POST /v1/providers/{provider}/delivery-receipt**

**Description:**  
Receives asynchronous delivery receipts from providers (SES/Twilio/FCM).

**Request Body (JSON):**

{

"providerMessageId": "7h3821dhsa",

"notificationId": "0acbb65e-68f4-4885-a27d-616285a07a50",

"status": "delivered",

"timestamp": "2025-01-05T12:45:00Z",

"raw": {

"providerEvent": "delivery",

"ip": "10.1.13.8"

}

}

**Response Body:**

{ "status": "acknowledged" }

**Behaviour:**  
• Updates internal logs and notification status.  
• Triggers analytics updates and event propagation.

### DLQ & Retry Management APIs

**POST /v1/dlq/replay**

**Description:**  
Replays failed notifications from DLQ.

**Request Body (JSON):**

{

"filter": {

"failureReason": "provider_timeout"

},

"limit": 500

}

**Response Body (JSON):**

{

"status": "replay_started",

"count": 500

}

**Behaviour:**  
• Requeues notifications back into retry pipeline.  
• Logs all replay actions for audit.

### Metrics & Audit APIs

**GET /v1/metrics/providers**

**Description:**  
Returns provider-specific latency, throttling, and success metrics.

**Response Body (JSON):**

{

"email": { "successRate": 0.98, "avgLatencyMs": 250 },

"sms": { "successRate": 0.94, "avgLatencyMs": 900 },

"push": { "successRate": 0.99, "avgLatencyMs": 80 }

}

**GET /v1/audit/logs**

**Description:**  
Fetches audit logs for admin operations.

**Response Body (JSON):**

{

"entries": \[

{

"timestamp": "2025-01-05T12:02:00Z",

"actor": "admin@example.com",

"action": "template_updated",

"templateId": "ORDER_CONFIRMATION"

}

\]

}

**Behaviour:**  
• Paginated retrieval.  
• Filterable by time, user, event type.

# Chapter 24 — **Cloud File Storage** System

Modern users expect seamless access to their files across all devices—mobile, desktop, and web—along with real-time collaboration, reliable syncing, secure sharing, and fast retrieval. Cloud file storage platforms must therefore handle massive data volumes, large-file uploads, offline changes, versioning, and strict access controls, all while ensuring low latency and high durability.

  
Supporting features like chunked uploads, multi-device sync, delta propagation, and fine-grained permissions at petabyte scale introduces significant engineering challenges. These include balancing performance with cost-efficiency, designing metadata systems that scale to billions of objects, and ensuring reliable conflict resolution during concurrent edits.

  
This chapter explores the architecture and design considerations required to build a highly scalable, secure, and efficient cloud file storage system capable of supporting millions of users, billions of files, and real-time synchronization across devices.

## Overview

This document describes a high-level system design for a **cloud-based file storage platform** capable of storing petabytes of data, supporting large-file uploads, providing fast cross-device sync, secure sharing, fine-grained access controls (view/edit/comment), and maintaining version history for compliance. The system targets **10M+ active users**, **billions of files**, and **low-latency metadata operations**, with multi-region durability and scalable sync propagation.

In today’s multi-device digital world, users expect seamless access to their files from anywhere—desktop, mobile, or web. File storage platforms must support real-time sync, collaborative editing, conflict resolution, large-file uploads, and secure sharing at internet scale. Achieving this requires careful separation of metadata and blob storage, efficient chunked upload workflows, strong access controls, and a scalable change-log architecture for sync propagation.

**Goals**

- Provide reliable, low-latency storage and retrieval for user files.
- Support resumable, chunked uploads for large files (multi-GB).
- Deliver near-real-time device sync with conflict resolution.
- Enable secure sharing with fine-grained permissions.
- Maintain full version history with restore and audit logging.

**Terminology**

- **Object / Blob** — Raw file content stored in object storage.
- **Metadata** — Structured information describing files and folders.
- **Chunk / Part** — Segment of a large file uploaded independently.
- **Sync delta** — Change record propagated to user devices.
- **ACL** — Access control list defining permissions.

## Requirements

### Functional Requirements

- Upload and download files of all sizes (small → multi-GB).
- Support chunked, resumable uploads.
- Create, move, rename, delete files and folders.
- Real-time / near real-time multi-device sync.
- Share files/folders with view/edit/comment permissions.
- Generate public shareable links with expiration and scopes.
- Maintain version history, trash, and restore flows.
- Provide metadata search (filename, properties).
- Admin and audit APIs for compliance/governance.

### Non-Functional Requirements

- **Scalability:** 10M+ users, billions of files, petabyte-scale objects.
- **Availability/Durability:** Multi-region, multi-zone replication.
- **Latency:** Metadata reads < 20 ms typical; sync < 5 seconds.
- **Security:** End-to-end encryption in transit; encryption at rest; strict ACL enforcement.
- **Cost-efficiency:** Hot/cold storage tiers, deduplication, lifecycle policies.
- **Observability:** Metrics, structured logs, distributed tracing, audit trails.

**Assumptions & Constraints**

- Files may reach several GB; chunking is mandatory.
- Object storage (S3/GCS/Azure Blob) stores file content.
- Metadata is stored in a separate high-performance database.
- Authentication handled externally (OAuth2, SSO).
- Sync propagation should be under 5 seconds for most updates.
- Multi-device usage can create sync storms; system must absorb bursts.

**Scale & Capacity Estimates**

- **Active users:** 10M
- **Average files/user:** 500 → ~5B files
- **Avg file size:** ~2 MB → ~10 PB total data
- **Peak uploads:** ~2,000 files/sec
- **Peak sync events:** ~10,000 deltas/sec

Implications:

- Metadata requires sharding/partitioning.
- Object storage handles data growth elastically.
- Sync/log services must scale horizontally.

**Access Patterns**

- **Read-heavy:** Folder listings, file previews, shared-link access.
- **Write-heavy bursts:** Large-file uploads, renames, sync storms.
- **Hot content:** Frequently shared/edited files → require CDN/caching.

## Design Considerations

This section enumerates practical constraints, engineering trade-offs, and recommended construction/deployment choices for building the cloud file storage system. It also covers rollout and operational construction details required to move from design to production safely.

**Constraints & Hard Requirements**  
• **Object-store dependency:** The design assumes reliable S3/GCS-style object storage with eventual consistency semantics for listing; object-store limits (request rates, per-object size, multipart part counts) must be respected.  
• **Metadata performance:** Metadata DB must support low-latency point reads and high write rates; choose a sharded NoSQL / NewSQL mix with strong indexing for common queries.  
• **Upload size & part limits:** Respect provider limits (e.g., max parts per multipart upload, min/max part sizes); chunk manager must enforce part size policy.  
• **Network egress & regional placement:** Data egress costs and residency requirements may force multi-region data placement and region-aware routing.  
• **Provider throttling & quotas:** External services (CDN, email, identity) have quotas — backpressure and throttling mitigation must be in place.  
• **Security & compliance:** Encryption-in-transit and at-rest, KMS-backed keys, per-tenant/regional compliance constraints (GDPR, HIPAA) require design-time choices for data locality and audit ability.  
• **Consistency model:** Metadata should provide strong consistency for single-object operations (reads/writes); cross-shard transactions should be minimized. Eventual consistency is acceptable for some list/analytics operations.

**Construction / Implementation Choices**  
• **Metadata store selection:** Use a hybrid approach — a strongly consistent primary store for critical metadata (user, ACLs, file pointers) and an eventually-consistent, highly-partitioned store for large-scale listings/analytics (e.g., leaderless wide-column tables or sharded document stores).  
• **Partitioning strategy:** Partition metadata by user_id for most user-scoped operations; use conversation/tenant-aware hashing for team/shared folders to avoid hotspots. Implement consistent hashing and dynamic resharding plans.  
• **Chunk manager implementation:** Stateless API front-ends that generate signed URLs; a small stateful service persists session state in a fast KV store (Redis with write-through) and periodically flushes to durable metadata store.  
• **Blob lifecycle & tiering:** Implement lifecycle policies that transition objects from hot → warm → cold tiers. Provide automated archival and restore workflows to bound storage cost.  
• **Deduplication strategy:** Implement content-addressable storage for exact-duplicate elimination at the blob level (store blob by checksum). Deduplication is best-effort and limited to identical content to avoid metadata explosion.  
• **Sync & fan-out:** Use an append-only durable change-log (Kafka/Pulsar) with regional partitions. Fan-out near the edge (regionally) to minimize cross-region traffic and lower sync latency.  
• **Conflict resolution approach:** Default to per-file server-side last-writer-wins for metadata edits, and CRDT/OT for collaborative structured documents. For binary files, provide automatic versioning + UI-assisted merge.  
• **Indexing:** Maintain near-real-time indices for filename/metadata (ElasticSearch or managed search service) with asynchronous updates and soft-consistency guarantees.

**Operational Construction & Deployment**  
• **Multi-region deployment model:** Deploy stateless front-ends and chunk managers in all primary regions; place metadata replicas regionally with a single writable primary or use multi-master with conflict resolution depending on requirements. Object storage buckets should be region-specific with cross-region replication for durability.  
• **Bootstrapping & migration:** Provide a migration plan to backfill metadata when moving users into new partitions; use idempotent migration jobs and reconciliation via checksums and delta-scan.  
• **Autoscaling strategy:** Autoscale gateways and worker pools based on request/queue length and backlog metrics. Pre-warm nodes before planned campaigns or known heavy events.  
• **Backups & disaster recovery:** Periodic consistent snapshots of metadata store and retained object manifests. Snapshot + WAL replay plan for fast recovery; provide playbooks for region failovers and partial restores.  
• **Testing & staging:** Blue/green deploys with canary traffic for new metadata or schema changes. Use synthetic workloads to simulate chunked uploads, sync storms, and hot-folder access patterns.  
• **Instrumentation & SLOs:** Define SLOs (metadata read p50/p95, sync latency p99, upload success rate) and instrument metrics, traces, and dashboards. Implement automatic alerts for partition hotspots, backlog growth, and high error rates.  
• **Operational runbooks:** Maintain clear runbooks for common incidents — stuck upload sessions, corrupted parts, object-store throttling, metadata DB partitions, and access control incidents. Include rollback steps, DLQ replay methods, and user-notification procedures.  
• **Cost governance:** Implement per-tenant usage accounting and lifecycle reporting, and provide mechanisms to enforce retention or storage quotas.

**Trade-offs & Design Decisions to Document**  
• **Strong vs eventual metadata consistency:** Strong consistency simplifies client UX but increases cross-region complexity and cost. Document chosen model and justify for product needs.  
• **Deduplication vs CPU/IO cost:** Dedup reduces storage but increases compute and metadata volume; choose boundaries (e.g., dedupe only for files above X size or within same user).  
• **CRDT/OT complexity vs UX:** CRDTs enable seamless collaboration but add engineering complexity—prefer for first-class collaborative document types and fall back to simpler versioning for binaries.  
• **Single multi-region bucket vs region-specific buckets:** A single global bucket simplifies management but increases latency/cost; region-specific buckets improve latency and compliance.

**Security & Compliance Construction**  
• **KMS & key rotation:** Use central KMS for envelope keys, rotate keys regularly, and support BYOK if required.  
• **Audit logging:** Ensure immutable audit logs for all ACL changes, share creation, and data-access events with retention policies.  
• **Access token flows:** Short-lived tokens for signed URLs; validate tokens at the gateway for every metadata-changing operation.

**Operational Recommendations**  
• Run capacity planning regularly with realistic workloads and schedule load tests quarterly.  
• Maintain a dedicated "migration & reconciliation" team for metadata scrubbing and audit.  
• Provide admin tools for bulk restores, quota enforcement, and legal holds.

## High-level Architecture (components & flow)

Components:

- **API Gateway & Auth Layer** — Token validation, rate limiting.
- **Upload Service / Chunk Manager** — Session init, signed URLs, chunk tracking, assembly.
- **Metadata Service** — File/folder metadata, versions, ACLs.
- **Object Storage** — Durable blob storage with lifecycle tiers.
- **Sync Service & Change Log** — Durable log of changes, pub/sub fan-out.
- **Conflict Resolution Engine** — CRDT/OT or last-writer-wins with manual merge options.
- **Sharing & ACL Service** — Link tokens, permissions, team/group access.
- **Search/Indexing Service** — Filename, metadata, content preview indexing.
- **Trash/Versioning Service** — Handles recovery, retention, cleanup.
- **Monitoring & Logging** — Metrics, tracing, audit events.

## Database Design

**files (root file/folder metadata table)**

|     |     |     |
| --- | --- | --- |
| Column | Type | Notes |
| file_id | uuid | Primary key |
| parent_id | uuid | Null for root folders |
| owner_id | bigint | Owner user |
| name | text | Filename |
| is_folder | boolean | File vs folder |
| size_bytes | bigint | Stored size |
| checksum | text | MD5/SHA-256 for dedupe & integrity |
| blob_id | uuid | FK to object storage mapping |
| version | int | Latest version number |
| metadata | json | File-type, thumbnail info, content-type |
| created_at | timestamp |     |
| updated_at | timestamp |     |

**file_versions**

|     |     |     |
| --- | --- | --- |
| Column | Type | Notes |
| version_id | uuid | Primary key |
| file_id | uuid | FK → files |
| version_num | int | Incremental version |
| blob_id | uuid | Points to stored object |
| size_bytes | bigint | Snapshot size |
| checksum | text | Integrity check |
| created_at | timestamp |     |

**upload_sessions**

|     |     |     |
| --- | --- | --- |
| Column | Type | Notes |
| session_id | uuid | Primary key |
| file_id | uuid | FK → files |
| user_id | bigint | Initiating user |
| total_parts | int | Number of expected chunks |
| uploaded_parts | json | Tracking uploaded chunk indices |
| expiry_at | timestamp | Cleanup schedule |
| created_at | timestamp |     |

**chunks**

|     |     |     |
| --- | --- | --- |
| Column | Type | Notes |
| chunk_id | uuid | Primary key |
| session_id | uuid | FK → upload_sessions |
| part_number | int | Chunk index |
| blob_ref | text | Object storage part reference |
| size_bytes | bigint |     |
| created_at | timestamp |     |

**acl_entries**

|     |     |     |
| --- | --- | --- |
| Column | Type | Notes |
| acl_id | uuid | Primary key |
| file_id | uuid | FK → files |
| subject_id | bigint | User or team ID |
| permission | text | view / edit / comment |
| created_at | timestamp |     |

**shared_links**

|     |     |     |
| --- | --- | --- |
| Column | Type | Notes |
| link_id | uuid | Primary key |
| file_id | uuid | FK → files |
| token | text | Secure random string |
| permissions | text | view / edit / comment |
| expires_at | timestamp | Optional expiration |
| created_at | timestamp |     |

**sync_deltas**

|     |     |     |
| --- | --- | --- |
| Column | Type | Notes |
| delta_id | uuid | Primary key |
| file_id | uuid | FK → files |
| user_id | bigint | Initiator |
| change_type | text | create/update/delete/move/version |
| metadata | json | Additional change attributes |
| created_at | timestamp |     |

**trash_bin**

|     |     |     |
| --- | --- | --- |
| Column | Type | Notes |
| trash_id | uuid | Primary key |
| file_id | uuid | FK → files |
| deleted_by | bigint | User who deleted |
| deleted_at | timestamp | Timestamp |
| expiry_at | timestamp | Auto-cleanup date |

**audit_logs**

|     |     |     |
| --- | --- | --- |
| Column | Type | Notes |
| event_id | uuid | Primary key |
| user_id | bigint | Actor |
| action | text | upload/update/delete/share/etc. |
| target_id | uuid | File or folder |
| metadata | json | Extra info |
| created_at | timestamp |     |

## API Design (RESTful) — Endpoint specification

### File Management Service APIs

**POST /v1/files**

**Description:**  
Creates a new empty file or folder (metadata only).

**Request Body:**

{

"parentId": "e12f-44aa...",

"name": "Documents",

"isFolder": true

}

**Response Body:**

{

"fileId": "b29d-11fa...",

"status": "created"

}

**Behaviour:**  
• Validates name uniqueness within parent.  
• Creates metadata entry.

**GET /v1/files/{fileId}**

Returns metadata of a file or folder.

**Response Body:**

{

"fileId": "...",

"name": "resume.pdf",

"isFolder": false,

"size": 128393,

"version": 3,

"permissions": \["view", "edit"\]

}

**DELETE /v1/files/{fileId}**

Moves file to trash.

**PUT /v1/files/{fileId}/rename**

Renames a file/folder.

### Upload Service / Chunk Manager APIs

**POST /v1/uploads/session**

Initializes a chunked upload session.

**Request Body:**

{

"fileName": "video.mp4",

"sizeBytes": 524288000,

"parentId": "f1bc..."

}

**Response:**

{

"sessionId": "9a77...",

"uploadUrls": \["signed-url-part1", "signed-url-part2"\]

}

**POST /v1/uploads/{sessionId}/complete**

Finalizes session and assembles parts.

**Download APIs**

**GET /v1/files/{fileId}/download-url**

Returns a time-limited signed URL.

### Sync Service APIs

**GET /v1/sync/changes**

Fetches sync deltas since a cursor.

### Sharing & ACL APIs

**POST /v1/share**

Creates a share entry.

**POST /v1/share/link**

Generates a shareable link.

### Versioning APIs

**GET /v1/files/{fileId}/versions**

List versions.

**POST /v1/files/{fileId}/versions/{versionId}/restore**

Restores a previous version.

### Search APIs

**GET /v1/search**

Search by filename or metadata.

### Audit APIs

**GET /v1/audit**

Fetch audit logs.

# Chapter 25 — **Online Rental Platform**

Modern rental marketplaces such as Airbnb rely on sophisticated search, booking, availability, and payment systems to deliver a seamless host–guest experience. Users expect real-time availability checks, accurate pricing, instant booking confirmations, secure payments, and high-quality media browsing. Achieving this at global scale introduces major engineering challenges: preventing double-bookings, managing millions of listings and media assets, coordinating with external calendars, ranking high-quality search results, and maintaining transactional integrity during peak demand.  
This chapter outlines the high-level design of a scalable rental platform, detailing the architecture, data models, APIs, booking workflows, search system, payments, notifications, calendar sync, and operational considerations needed to support millions of users and tens of millions of listings across the world.

## Overview

This document provides a high-level system design for an **online rental marketplace** similar to Airbnb. The platform supports **listing creation**, **geo-based search**, **availability & calendar sync**, **payments**, **reviews**, **media uploads**, and **host/guest workflows**. It must serve millions of users, handle large search workloads, guarantee booking consistency, and provide global availability.

The system integrates multiple subsystems—booking, payments, search indexing, real-time calendar synchronization, media handling, fraud detection, and notifications. It must balance **strong consistency** for bookings with **eventual consistency** for search and calendar sync, while ensuring low latency and high reliability.

**Goals**

- Enable hosts to list properties and manage availability & pricing.
- Enable guests to search, filter, book, pay, and review stays.
- Guarantee consistency in booking operations to avoid double-bookings.
- Provide global scale, localization, and multi-currency support.
- Support secure payments, media uploads, notifications, and sync.

**Terminology**

- **Listing** — A property available for rent.
- **Booking** — A confirmed reservation by a guest.
- **Availability calendar** — Per-day record of whether a listing is free.
- **Payment intent** — A secure payment authorization handled externally.
- **External calendar sync** — iCal / Google Calendar integration.
- **Host** — Property owner who lists and manages availability.
- **Guest** — User booking a stay.

**Actors**

- **Guest** — Searches and books stays.
- **Host** — Creates listings, uploads media, manages availability.
- **Admin** — Moderates content, handles fraud/disputes.
- **Payment Provider** — Stripe/PayPal for payments.
- **External Calendar Provider** — Google Calendar/iCal for availability sync.

## Requirements

### Functional Requirements

- Account & identity management.
- Listing creation/update/delete, media uploads, amenities, rules/policies.
- Search with geo filters, price filters, amenities, availability filters.
- Booking workflow: availability check, reserve, payment, confirmation.
- Calendar management & two-way external calendar sync.
- Notifications for bookings, cancellations, reminders.
- Review & rating system for guests and properties.
- Admin dashboards for moderation, fraud detection, and dispute handling.

### Non-Functional Requirements

- **Availability:** 99.99% uptime for booking and listing operations.
- **Latency:** Search < 300 ms; booking < 500 ms.
- **Scalability:** Millions of users, tens of millions of listings.
- **Consistency:** Strong consistency for booking.
- **Security:** PCI compliance, secure media uploading, GDPR for data.
- **Extensibility:** Easy addition of new regions, search filters, booking rules.

**Assumptions & Constraints**

- Payments handled entirely by third-party providers (no card storage).
- Object storage used for media assets (S3/Blob).
- External calendar sync may lag; host-facing UI should clarify limits.
- Reviews are processed via moderation pipeline.
- Search index (ES/OpenSearch) will be eventually consistent.

**Scale & Capacity Estimates**

- DAU: ~5M
- Concurrent users peak: ~100k
- Listings: ~50M
- Searches/day: ~50M
- Bookings/day: ~1M
- Media: ~500TB
- Payment transactions/day: ~1M

Implications:  
• Search is read-heavy; use caching + search indexing.  
• Booking is write-heavy and must be strongly consistent.  
• Media and indexing consume heavy storage and compute.

**Access Patterns**

- **Read-heavy:** Listing details, search queries, browsing.
- **Write-sensitive:** Booking transactions & availability updates.
- **Media-heavy:** Image/video serving → CDN required.

## Design Constraints

**Constraints & Hard Requirements**

• Booking must enforce **strong consistency** to prevent double-bookings.  
• Calendar updates must be atomic and low-latency.  
• Search index (ES) is eventually consistent; UI must handle delays.  
• Media uploads must respect part-size and total size limits.  
• Payment data must comply with PCI—no card storage.  
• GDPR applies for personal data → PII encryption + deletion workflows.

**Construction / Implementation Choices**

• Use **Postgres/Aurora** for booking & listing metadata (ACID).  
• Use **event-driven** indexing updates to maintain search index freshness.  
• Availability stored in **per-listing partitioned tables** or **KV stores** (e.g., DynamoDB).  
• Booking workflow uses **pessimistic locking** or **conditional writes**.  
• Media processed via async workers for thumbnails, video transcoding.  
• Pricing rules handled through a separate rule-engine for dynamic adjustments.

**Operational Construction & Deployment**

• Multi-region deployment with **read replicas** and local search nodes.  
• Blue/green deployment for booking & payment flows.  
• Autoscale search and media workers during peak events.  
• Full availability snapshot regeneration pipelines for disaster recovery.

**Security & Compliance Construction**

• OAuth2/SSO for authentication; short-lived tokens.  
• Object storage signed URLs for upload/download.  
• Full audit trails for listing edits and bookings.  
• Fraud-detection alerts for suspicious booking patterns.

##  High-level Architecture (components & flow)

Components:

- CDN & API Gateway
- Authentication & Identity Service
- Listing Service (CRUD + metadata)
- Search Service (Elastic/OpenSearch + ranking)
- Availability & Calendar Service (per-listing availability store)
- Booking Service (transactional, strong consistency)
- Payment Service (Stripe/PayPal integrations)
- Media Service (uploads, resizing, thumbnails)
- Notification Service (email/SMS/push)
- External Calendar Sync Workers
- Review Service
- Analytics & Recommendation Engine
- Datastores: Relational DB (Postgres/Aurora), Redis, S3, Search index
- Message Bus: Kafka/Pulsar

## Database Design

All tables follow the same uniform format as previous chapters.

**users**

|     |     |     |
| --- | --- | --- |
| Column | Type | Notes |
| user_id | bigint | PK  |
| email | text | unique |
| hashed_password | text | secure hash |
| role | text | guest/host/admin |
| locale | text |     |
| created_at | timestamp |     |

**listings**

|     |     |     |
| --- | --- | --- |
| Column | Type | Notes |
| listing_id | bigint | PK  |
| host_id | bigint | FK → users |
| title | text |     |
| description | text |     |
| location | json | lat/lng, address |
| amenities | json |     |
| price_per_night | numeric |     |
| currency | text |     |
| max_guests | int |     |
| status | text | active/inactive |
| created_at | timestamp |     |
| updated_at | timestamp |     |

**listing_media**

|     |     |     |
| --- | --- | --- |
| Column | Type | Notes |
| media_id | uuid | PK  |
| listing_id | bigint | FK  |
| url | text | CDN URL |
| type | text | image/video |
| size_bytes | bigint |     |
| created_at | timestamp |     |

**availability**

|     |     |     |
| --- | --- | --- |
| Column | Type | Notes |
| listing_id | bigint | PK composite |
| date | date | PK composite |
| is_available | boolean |     |
| price | numeric | dynamic pricing |
| updated_at | timestamp |     |

**bookings**

|     |     |     |
| --- | --- | --- |
| Column | Type | Notes |
| booking_id | uuid | PK  |
| listing_id | bigint | FK  |
| guest_id | bigint | FK  |
| start_date | date |     |
| end_date | date |     |
| amount | numeric |     |
| currency | text |     |
| status | text | pending/confirmed/cancelled |
| payment_intent_id | text | external |
| created_at | timestamp |     |
| updated_at | timestamp |     |

**payment_transactions**

|     |     |     |
| --- | --- | --- |
| Column | Type | Notes |
| transaction_id | uuid | PK  |
| booking_id | uuid | FK  |
| provider | text | Stripe/PayPal |
| status | text | succeeded/failed/pending |
| raw_response | json |     |
| created_at | timestamp |     |

**reviews**

|     |     |     |
| --- | --- | --- |
| Column | Type | Notes |
| review_id | uuid | PK  |
| listing_id | bigint |     |
| guest_id | bigint |     |
| rating | int | 1–5 |
| text | text |     |
| status | text | pending/approved/rejected |
| created_at | timestamp |     |

**shared_calendars**

|     |     |     |
| --- | --- | --- |
| Column | Type | Notes |
| calendar_id | uuid | PK  |
| listing_id | bigint | FK  |
| provider | text | google/ical |
| sync_token | text | pagination token |
| last_synced_at | timestamp |     |

**audit_logs**

|     |     |     |
| --- | --- | --- |
| Column | Type | Notes |
| event_id | uuid | PK  |
| actor_id | bigint | user/admin |
| action | text | listing_update/booking_cancel/etc. |
| target_id | uuid | listing/booking |
| metadata | json |     |
| created_at | timestamp |     |

## API Design (RESTful) — Endpoint specification

### Authentication & Identity Service APIs

**POST /v1/auth/register**

Registers user.

**POST /v1/auth/login**

Returns tokens.

### Listing Service APIs

**POST /v1/listings**

Creates a listing.

Request:

{

"title": "2BR Apartment",

"description": "Near downtown",

"location": { "lat": 37.7, "lng": -122.4 },

"pricePerNight": 120,

"currency": "USD",

"amenities": \["wifi", "kitchen"\]

}

Response:

{ "listingId": 30299, "status": "created" }

**PUT /v1/listings/{listingId}**

Updates listing details.

**DELETE /v1/listings/{listingId}**

Soft delete listing.

**Media Service APIs**

**POST /v1/listings/{listingId}/media**

Initiates upload → returns signed URLs.

**DELETE /v1/media/{mediaId}**

Deletes media asset.

### Search Service APIs

**GET /v1/search**

Query params: location, price range, dates, amenities.

Response (excerpt):

{

"results": \[

{

"listingId": 30299,

"title": "2BR Apartment",

"pricePerNight": 120,

"thumbnail": "cdn-url"

}

\]

}

### Availability & Calendar APIs

**GET /v1/listings/{listingId}/availability**

Returns per-day availability.

**PUT /v1/listings/{listingId}/availability**

Host updates calendar.

### Booking Service APIs

**POST /v1/bookings**

Request:

{

"listingId": 30299,

"startDate": "2025-06-12",

"endDate": "2025-06-18"

}

Response:

{

"bookingId": "b1d4...",

"status": "pending_payment"

}

**POST /v1/bookings/{bookingId}/confirm**

Confirms after successful payment.

**POST /v1/bookings/{bookingId}/cancel**

Cancels booking with refund logic.

### Payment Service APIs

**POST /v1/payments/intent**

Creates payment intent.

**POST /v1/payments/webhook**

Provider callback (Stripe/PayPal).

### Reviews Service APIs

**POST /v1/reviews**

Submit review.

**GET /v1/reviews/{listingId}**

Fetch listing reviews.

### Notification Service APIs

**POST /v1/notifications/send**

Send booking confirmation notifications.

### Admin & Moderation APIs

**GET /v1/admin/reports**

Fraud/misuse reports.

**POST /v1/admin/moderate**

Approve/reject review or listing.

# Chapter 26 — **Auction Platform System**

**Overview**

This document describes a high-level system design for a scalable, real-time auction platform. It covers functional and non-functional requirements, capacity estimates, architecture, bid processing and concurrency guarantees, timing and fairness concerns, anti-sniping strategies, payment integration, notifications, monitoring, security, and operational playbooks.

The design targets environments with thousands of concurrent auctions, time-sensitive bidding (sub-second), and strong fairness and auditability guarantees.

**Goals**

- Provide secure, low-latency bidding with accurate winner determination at close time.
- Enforce fairness, prevent double-winning, and provide strong audit trails for bids and payments.
- Scale horizontally to support many concurrent auctions and handle bursty bidding near close.
- Integrate reliably with payment providers and notify participants in real time.

**Terminology**

- Auction: an item listing with configured parameters (start_time, end_time, reserve_price, buy_now, extension_rules).
- Lot / Item: an individual object being auctioned.
- Bid: a user's offer (amount, timestamp, bidder_id) for an auction.
- Highest Bidder: the bidder currently leading the auction.
- Anti-sniping / Extension rule: policy to extend auction end time when last-second bids arrive.
- Auction Engine: service responsible for accepting bids, enforcing rules, and closing auctions.

**Functional Requirements**

- User registration and secure authentication (buyers & sellers).
- Sellers can create/list auctions with configurable parameters (start/end time, increment rules, reserve price, buy-now option).
- Users can place bids and receive immediate feedback (accepted/rejected/outbid).
- Real-time update stream of bids and auction state to watchers (WebSocket/pub-sub).
- Auction lifecycle transitions: scheduled → active → ended → settled.
- Winner determination and initiation of payment workflow when auction ends.
- Admin tools for moderation, dispute resolution, and manual overrides.

**Non-Functional Requirements**

- Low latency: sub-second bid acceptance and feedback.
- High availability during auctions; no single-point outage at close time.
- Strong consistency for bid ordering and winner selection for each auction.
- Durability and auditability: persistent append-only bid logs and immutable records for compliance.
- Scalability: handle thousands of concurrent auctions and bursts (e.g., many bidders in last seconds).

**Constraints & Challenges**

- Precise timing: auctions must close deterministically and fairly at configured end_time or after extension rules.
- Concurrency: many concurrent bids for the same auction can cause race conditions and must be serialized.
- Network latency and clock skew across regions complicate ordering and disputes.
- Payment failures: winners may fail to pay — need fallback and reallocation.
- Bot/auction-sniping attacks and fraud — detection and mitigation required.

**Capacity & Traffic Estimates (example)**

- Registered users: 5M; DAU: 500k.
- Ongoing auctions: ~1M active items across categories.
- Average bids per auction: 10 → ~10M bids/day.
- Peak concurrent bidders for a hot auction: ~10k.
- Completed auctions per day: ~100k → similar volume of payment transactions.

Sizing implications:

- Average write load is moderate, but bid spikes near close require burst-capable systems and enough parallel workers for hot auctions.

**High-Level Architecture**

Components:

- Web & Mobile Clients (HTTP, WebSocket)
- API Gateway / Edge CDN
- Authentication & Authorization Service
- Auction Service / Auction Engine (stateful per-auction components)
- Bid Ingest & Ordering Layer (durable log, sequencer)
- Real-time Pub/Sub / Notification Layer (WebSocket hubs, Kafka/Redis PubSub)
- Persistence:
    - Bid Archive (append-only immutable log; e.g., Kafka + long-term store)
    - Transactional DB (for auctions metadata, user, payment state)
    - Time-series / Audit DB for event reconstruction
- Payment Service (integration with Stripe/PayPal) + Payment Queue
- Monitoring, Tracing & Audit logging
- Admin & Moderation UIs

Conceptual flow:

Client -> API/Gateway -> Auction Engine -> Bid Sequencer/Log -> Auction State persisted -> Pub/Sub updates to clients

Notes:

- Auction Engine is the core: it validates bids, enforces increment/reserve rules, applies anti-sniping extensions, and triggers close operations.
- Critical operations (bid acceptance, highest-bid update, close) must be strongly consistent within the auction's partition/shard.

**Auction Partitioning & Localization**

- Partition auctions by auction_id across shards/hosts so each auction's state is managed by a single leader instance (actor model). This ensures per-auction serialization and avoids cross-shard locking.
- Use a consistent hashing or directory service to map auction_id → auction leader instance.
- For scale, run many auction leader instances per region; replicate reads via read-only caches for listing/browsing.

**Bid Ingest, Ordering & Validation**

Ordering model:

- Each auction leader maintains a monotonic sequence number for bids.
- Gateways publish incoming bids to a durable log (e.g., Kafka topic partitioned by auction_id) to provide durability and replay.
- Auction leader consumes the partition and serially processes bids, assigning sequence numbers and persisting the accepted bids.

Validation checks:

- Bid amount >= minimum allowed (current_highest + increment).
- Bid placed within auction active window (consider extension rules).
- Bidder eligibility (e.g., verified user, payment-capable if required for pre-approval).

Atomicity & persistence:

- The leader must atomically persist the accepted bid and update the current highest bid in the transactional store to avoid lost or concurrent winners.

**Handling Concurrency & Race Conditions**

- Per-auction leader serializes writes; no distributed locks required for per-auction operations.
- For resilience, implement leader failover with write-ahead log replay to ensure no bids are lost and ordering is preserved.
- Use optimistic concurrency control with persistent sequence numbers to detect out-of-order processing on recovery.

**Timing, Clock Synchronization & Fairness**

- Rely on server-side authoritative timestamps for bid acceptance. Client timestamps are advisory only.
- Servers should use NTP-synchronized clocks and, where needed, monotonic counters to avoid ambiguity.
- Determine acceptance at the leader using its authoritative time. Broadcast acceptance and sequence numbers to watchers.

Anti-sniping / Extension rules:

- To prevent unfair last-second sniping, implement configurable extension rules (e.g., if a bid arrives within X seconds of end_time, extend by Y seconds). This extension is applied atomically by the auction leader.

Close-time determinism:

- At close, the auction leader finalizes the highest bid at its authoritative time, marks the auction closed, and initiates settlement.
- Use a quorum/replication of the leader state for failover determinism if leader crashes at close time.

**Hot Auctions & Burst Handling**

- Identify hot auctions (high bid rate) and allocate extra resources: pin them to dedicated leader instances, increase processing parallelism for their partition, and reserve messaging capacity for real-time fan-out.
- Use backpressure and prioritized queues: bids for hot auctions are prioritized and fed to high-throughput workers.

**Real-time Updates & Fan-out**

- After accepting a bid, the auction leader publishes an update to the pub/sub layer (e.g., Kafka, Redis Streams) and notifies WebSocket hubs for immediate delivery to watchers.
- Fan-out should be region-aware: use local hubs for low-latency updates to geographically proximate viewers.

Optimization:

- Batch updates to reduce overhead when many watchers are connected, but ensure sub-second delivery remains.

**Payments & Settlement**

- When auction closes and winner is determined, create a payment intent and enqueue payment processing with idempotency keys.
- Reserve/hold payment methods pre-authorization when platform requires (optional) to reduce failed payments post-win.
- On payment success: mark auction as settled and notify seller and buyer; on payment failure: apply fallback policy (retry, extend payment window, or re-offer to next highest bidder depending on rules).

Integration notes:

- Use a queue and background workers for payment calls to external gateways; do not block auction close on external provider latency.

**Notifications & Communication**

- Notify participants (outbid, won, payment required, payment result) via in-app notifications, email, and SMS depending on user preferences.
- Use a reliable notification service and DLQ for failed sends; retries with exponential backoff and admin reconciliation for undelivered critical messages.

**Auditability & Immutable Logs**

- Store an immutable append-only log of bids (message bus + cold storage) for dispute resolution and compliance.
- Keep per-auction audit trails: bid events, leader transitions, close decisions, payment events, and admin actions.

**Fraud, Bots & Abuse Mitigation**

- Rate-limit bid submissions per user/IP and use CAPTCHA or challenge-response for suspicious patterns.
- Monitor bidding velocity and detect scripted/bot-like behaviors with anomaly detection.
- Enforce KYC/payment pre-approval for high-value auctions.

**Monitoring & Observability**

- Track metrics: bids/sec, acceptance rate, latency P50/P95/P99 for bid processing, leader failover events, payment success/failure rates, queue lag, and websocket fan-out latencies.
- Tracing: instrument critical paths (bid submission → acceptance → persist → notify → payment initiation).
- Alerts: auction leader failures, backlog growth for hot auctions, payment gateway errors, and high reconciliation counts.

**Testing & Operational Readiness**

- Load test: simulate hot auction scenarios with thousands of concurrent bidders to validate throughput and latency.
- Chaos test: leader failover during close, network partitions, and payment provider outage.
- Reconciliation tests: replay bid logs and verify winner selection matches production decisions.

**Security & Compliance**

- Authentication, authorization, and strong session management.
- Encrypt PII at rest and in transit; PCI compliance for payment processing.
- Maintain data retention and deletion policies to comply with regional laws.

**Data Model (core entities)**

- Auction: { auction_id, seller_id, item_id, start_time, end_time, reserve_price, buy_now_price, increment_rule, extension_policy, status }
- Bid: { bid_id, auction_id, bidder_id, amount, seq_no, server_timestamp }
- AuctionState: { auction_id, current_highest_bid_id, current_price, highest_bidder_id, last_updated }
- Payment: { payment_id, auction_id, bidder_id, amount, status, provider_reference }
- AuditLog: append-only events for actions and admin changes

**Trade-offs and Alternatives**

- Centralized leader per-auction (actor model) simplifies correctness and ordering at the cost of leader placement and failover complexity.
- Distributed locking with strong consensus (e.g., Paxos/Raft) could enforce global ordering but adds latency; the leader-per-auction approach is preferred for lower latency per-auction operations.
- Anti-sniping extension improves fairness but lengthens auctions under heavy last-second bidding; policies should be configurable.

**Cost Considerations**

- Costs driven by real-time infrastructure (gateways, pub/sub), persistent logs, payment gateway fees, and notification costs.
- Pin hot auctions to dedicated capacity during events to reduce contention costs elsewhere.

**Operational Playbook (short)**

- Pre-event (high-profile auctions): scale auction leaders, pre-warm pub/sub partitions, and verify payment provider capacity.
- During event: monitor bid latency and backlog; prioritize hot-auction pipelines; be ready to apply manual interventions if needed.
- Post-event: reconcile logs, run payment settlement checks, and audit winner/payment flows.

**APIs (example)**

- POST /auctions — create auction (seller authenticated)
- GET /auctions/{id} — fetch auction metadata and current state
- POST /auctions/{id}/bid — place bid (returns accepted/rejected + seq_no)
- GET /auctions/{id}/bids — fetch bid history (with pagination)
- POST /auctions/{id}/close — admin/manual close (restricted)
- GET /auctions/{id}/audit — fetch audit trail for dispute resolution

**Next Steps / Deliverables**

- Produce sequence diagrams for: bid submit & acceptance, auction close & settlement, hot-auction fan-out.
- Draft OpenAPI spec for the core auction and bidding APIs.
- Prototype an Auction Leader (actor) with sequenced bid processing using Kafka (ingest topic) and a simple in-memory leader for functional validation.

If you'd like, I can now:

- (A) Generate sequence diagrams and flowcharts for the core flows.
- (B) Produce an OpenAPI spec for POST /auctions, POST /auctions/{id}/bid, and related APIs.
- (C) Implement a small prototype Auction Leader (Node/Python) with Kafka-based ingest simulation and a simple stateful leader to validate ordering and close behavior.

Tell me which you'd like next.

# Chapter 27 — **Ticketing System**

**Overview**

This document describes a high-level system design for a scalable, reliable, and user-friendly ticketing platform inspired by BookMyShow. It follows the structure and level of detail used in the example email-provider.md and includes functional and non-functional requirements, constraints, scale estimates, architecture, data model, booking flows, failure handling, monitoring, security, and trade-offs.

**Goals**

- **Primary goal:** Provide a system where users can reliably browse events, select seats, and complete bookings with real-time seat availability and robust payment handling.
- **Secondary goals:** Low latency browsing, high availability during flash sales, auditability, and easy operational observability.

**Terminology**

- Event: A concert, movie, sports match, or any activity with tickets.
- Venue: The physical location; contains one or more seating layouts.
- Seat: A unique position in a seating layout (row, column, seat id).
- Booking: A confirmed reservation (paid) for one or more seats.
- Hold / Reservation: A temporary hold on seats while payment completes.

**Functional Requirements**

- Browse events and venues (search, filter, sort).
- View seat maps and live availability.
- Reserve/hold seats for a short time during checkout.
- Complete payment via third-party gateways and confirm bookings.
- Issue booking confirmations via email/SMS.
- Admin operations: create/manage events, venues, seat maps, pricing, and promotions.
- Refund / cancellation flows and admin adjustments.

**Non-Functional Requirements**

- **Availability:** 99.99% across regions during events.
- **Latency:** Read requests (browsing) in tens of milliseconds; booking operations under 200ms where possible.
- **Scalability:** Support 1M DAU, 100k concurrent users, peaks of 2k bookings/sec (or higher during top events).
- **Consistency:** Strong consistency for seat assignment to avoid double-bookings.
- **Durability & Auditability:** All booking/payment events persisted with immutable audit logs.

**Constraints & Challenges**

- Global multi-region support (low latency, compliance).
- Payment gateway latency and failures — must not block availability.
- High concurrency for hot events leading to contention for the same seats.
- Real-time seat availability and UI updates.

**Scale Estimates (Given)**

- 1,000,000 daily active users.
- 100,000 concurrent users at peak.
- 10,000,000 read requests per day (10 reads/user/day).
- 500,000 bookings/day (average) → ~6 bookings/sec; peaks up to 2,000 bookings/sec.

**High-Level Architecture**

Components:

- API Gateway / Edge CDN
- Frontend (web/mobile)
- Load balancers
- Microservices:
    - Event Service (catalog): events, venues, schedules
    - Seat Management Service: seat maps, availability
    - Reservation Service (holds): place/release holds with TTL
    - Booking Service: finalize bookings (strong consistency)
    - Payment Service: interact with payment gateways, handle callbacks
    - Notification Service: email/SMS via queued workers
    - Admin Service: event/venue management
    - Analytics + Reporting service
- Datastores:
    - Relational DB (primary transactional store) for bookings and seats (sharded)
    - NoSQL / Cache (Redis) for fast seat availability and reservation locks
    - Read replicas / search index (Elasticsearch) for browsing/search
    - Durable message queue (Kafka/RabbitMQ) for async workflows
    - Object storage for assets (S3 or equivalent)

Diagram (conceptual):

Frontend -> CDN -> API Gateway -> Load Balancer -> Microservices

Async flows use Kafka: Payment events, Notifications, Audit logs, Analytics.

**Data Model (Core Entities)**

- Event: { event_id, title, description, organizer_id, start_time, end_time, venue_id, categories }
- Venue: { venue_id, name, location, timezone }
- SeatingLayout: { layout_id, venue_id, sections\[\] }
- Seat: { seat_id, layout_id, section, row, number, attributes }
- PriceBand: { price_id, layout_id, section, price }
- Inventory / SeatState: { seat_id, event_id, state: AVAILABLE|HELD|BOOKED, last_updated }
- Reservation (Hold): { hold_id, user_id, event_id, seat_ids\[\], expires_at, status }
- Booking: { booking_id, user_id, event_id, seat_ids\[\], payment_id, status, created_at }
- Payment: { payment_id, booking_id, amount, currency, gateway, status, external_reference }
- AuditLog: append-only events for actions.

Indexes:

- Event by time, venue, popularity.
- Seat availability by event+section for quick queries.
- Booking by user and by event for reconciliation.

**Data Storage Choices & Rationale**

- Use a relational DB (Postgres, Amazon Aurora) for bookings and seat state requiring transactions. It supports ACID semantics needed to avoid double-booking.
- Use Redis (clustered) as an in-memory store for fast seat availability checks and distributed locks / counters.
- Use Kafka for durable, high-throughput async messaging (payment events, notifications, audit streams).
- Use Elasticsearch for search and fast browse UX.

**Seat Allocation Strategies**

Goal: Prevent double-booking while providing low-latency UX.

Options:

- Pessimistic locking in DB: acquire lock on seat rows or seat records inside a transaction — safe but scales poorly under high contention.
- Optimistic locking with version numbers: update seat state using compare-and-swap; on conflict retry. Works when contention is moderate.
- Reservation service with Redis-based atomic operations: mark seats as HELD using Redis SETNX or Lua scripts to ensure atomic multi-key operations. Use TTL for auto-release.
- Hybrid: Use Redis for fast holds and expire; on payment success, persist final state into the relational DB via a transactional write; use DB-level verification when writing final BOOKED state.

Recommended approach (balanced):

1.  When user selects seats, Reservation Service attempts an atomic hold in Redis (multi-key Lua script) that marks seats HELD and writes a short-lived Reservation record.
2.  The hold has a conservative TTL (e.g., 3–10 minutes) and the client shows the countdown.
3.  During checkout, payment is initiated asynchronously. Once payment success callback received, Booking Service performs a DB transaction to persist booking and flip seat state to BOOKED; the DB write must verify the seats are not already BOOKED.
4.  If DB write fails due to seat already BOOKED, refund or retry logic applies and user is notified.

This approach keeps the UI snappy (Redis) while ensuring the DB is the source of truth at commit time.

**Booking Flow (Sequence)**

1.  User selects event and seats -> frontend calls Seat Management API.
2.  Seat Management calls Reservation Service to place hold (atomic in Redis) -> returns hold_id.
3.  Frontend begins checkout; user provides payment info.
4.  Payment Service calls external gateway (async) -> returns authorization or failure. 5a. On payment success: Payment gateway sends webhook -> Payment Service validates and calls Booking Service. 5b. Booking Service starts DB transaction: verify seats are still held and not BOOKED -> persist Booking + Payment record -> set seats BOOKED -> commit.
5.  On commit success: Reservation entry removed; Notification Service enqueues confirmation (email/SMS).
6.  On payment failure or timeout: Reservation TTL expires or Reservation Service actively releases seats and notifies client.

Edge cases:

- Payment webhook arrives after TTL expiry: Booking Service must check the database and be resilient (double-check hold with Reservation or use idempotency keys). Implement idempotency tokens for checkout operations.
- Payment success but DB commit fails: trigger compensating action (refund or retry), log audit event, notify user and support.

**Idempotency & Exactly-Once Considerations**

- Use idempotency keys per checkout attempt (client generated or server-assigned) to deduplicate repeated requests across retries and network errors.
- Payment provider webhooks must be processed idempotently (store external_reference and ignore duplicates).

**Failure Handling and Compensation**

- Reservation TTLs to automatically release seats on payment failure or client disconnect.
- Circuit breakers and retries around payment gateway calls.
- Background job to reconcile held seats that exceeded TTL due to missed releases.
- Compensation flows: automatic refunds when DB commit failed after payment (or manual reconciliation for edge cases).

**Performance & Scaling Techniques**

- Read-heavy browsing: use CDN, aggressive caching (Edge/Redis), and Elasticsearch for search.
- Partitioning: shard bookings and seat state by event_id (or venue/region) to isolate hot partitions.
- Auto-scaling microservices and Redis clusters based on metrics (CPU, latency, queue length).
- Use connection pooling and prepared statements for DB.
- Bulk write patterns for analytics and audit via Kafka.

**Multi-Region & Latency**

- Deploy regionally with read replicas and local Redis caches for low-latency browsing.
- Use a single regional write path for booking per event — designate an event “home” region to avoid cross-region strong consistency complexities. For global events, partition seating by region or use a global consensus layer at higher cost.

**Security & Compliance**

- PCI compliance: do not store raw card data; use tokenization via PCI-compliant gateway.
- Encrypt sensitive data at rest and in transit (TLS everywhere).
- Role-based access control (RBAC) for admin operations.
- Rate limiting and abusive-behavior detection to protect against scalping/bots.

**Notifications & Backpressure**

- Use message queues (Kafka) for notification jobs and email/SMS workers with retries and DLQs.
- Throttle notification sending during massive spikes and send batched confirmations if needed.

**Monitoring & Observability**

- Metrics: request rates, latencies, bookings/sec, holds/sec, queue lengths, payment success/failure rates.
- Tracing: distributed tracing (OpenTelemetry) for end-to-end request visibility.
- Logs: structured logs pushed to ELK/Stackdriver.
- Alerts: SLO-based alerts for errors, latency spikes, and reduced throughput.

**Testing & Operational Readiness**

- Load testing to simulate peak booking scenarios and flash sales (thousands of concurrent seat holds and 2k+ bookings/sec).
- Chaos engineering for services like Payment, Reservation expiry, and DB failovers.
- Disaster recovery plans and regular backups for DB and Kafka.

**Cost Considerations**

- High-memory Redis clusters and DB write capacity for peak sale windows are the major cost drivers.
- Balance cost vs availability by scheduling pre-warming capacity for expected big events.

**Trade-offs and Alternatives**

- Strong consistency vs latency: Achieving strict global strong consistency across regions comes at higher latency and operational complexity. Preferred approach: regional home for write-critical operations (booking commit) and eventual consistency for cross-region reads.
- Seat allocation: Highly conservative DB locks guarantee correctness but suffer under contention; hybrid Redis holds + DB commit offers a good compromise.

**Operational Playbook (short)**

- Pre-event: scale up Redis clusters, DB replicas, and worker pools; enable stricter rate limiting for bots.
- During event: monitor key metrics, enable manual overrides for stuck holds, and ensure payment gateways are in circuit-breaker watch.
- Post-event: run reconciliation jobs to ensure held seats are cleared and all payments reconciled.

**Appendix: Key APIs (example endpoints)**

- GET /events — list/search events
- GET /events/{id}/seatmap — fetch seat layout + availability
- POST /reservations — request hold on seat_ids (returns hold_id)
- POST /checkout — initiate payment with hold_id and idempotency_key
- POST /webhooks/payment — payment gateway callback
- GET /bookings/{id} — fetch booking status

**Next Steps / Deliverables**

- Generate sequence diagrams for happy and failure flows.
- Design service API schemas (OpenAPI) and example DB schema DDL.
- Prototype Reservation Service (Redis Lua script) and Booking transaction example.

If you want, I can now:

- (A) Add sequence diagrams and example payloads.
- (B) Produce an OpenAPI spec for the key services.
- (C) Implement a small prototype Reservation Service (Lua + sample Node/Python wrapper).

Tell me which of the above you'd like next.

# Chapter 28 — **E‑commerce Marketplace System**

In today’s digital-first economy, providing a seamless, personalized, and reliable online shopping experience is critical for business growth and customer retention. E-commerce platforms must handle millions of products, process high-volume transactions, manage real-time inventory, and deliver personalized recommendations—all while ensuring security, scalability, and low latency. With global online sales reaching trillions annually and user expectations for fast, intuitive shopping continually rising, building a robust e-commerce system presents significant engineering challenges.

This engineering complexity is known as the E-Commerce System Problem — how to deliver a high-performance, scalable, and personalized shopping experience while managing product catalogs, inventory, orders, payments, and fraud detection at massive scale.

## Overview

As e-commerce platforms expand globally, several critical issues surface in building a world-class online shopping system:

**Goals**

- **Primary goal:** Deliver a fast, reliable, and personalized shopping experience with high conversion rates and minimal downtime.
- **Secondary goals:** Handle millions of products, real-time inventory updates, secure payment processing, personalized recommendations, and global logistics integration.

**Massive Product Catalog**  
Merchants list millions of products with detailed metadata—descriptions, images, variants, categories, prices, and reviews. This data must be searchable, filterable, and consistently available across regions.

**Real-Time Inventory & Order Management**  
Inventory levels must be accurate and updated in real time to prevent overselling. Order processing must be fault-tolerant, trackable, and integrated with fulfillment and logistics providers.

**Personalization & Recommendations**  
Product suggestions must be tailored to user behavior—browsing history, past purchases, and real-time intent. Recommendation engines must balance relevance, diversity, and business goals (e.g., high-margin items).

**Checkout & Payment Complexity**  
The checkout flow must be streamlined, secure, and support multiple payment methods (credit cards, digital wallets, etc.). Fraud detection must operate in real time without adding friction.

**Scalability During Peak Loads**  
Systems must handle traffic spikes during sales events (Black Friday, Prime Day) without degradation in performance or availability.

**Globalization & Compliance**  
Platforms must support multi-currency pricing, tax calculations, regional regulations (GDPR, CCPA), and localized user experiences.

## Requirements

### Functional Requirements

- User registration, authentication, and profile management.
- Product catalog management: CRUD operations, categories, variants, images, pricing.
- Search and discovery: keyword search, filters, sorting, faceted navigation.
- Shopping cart: add, update, remove items; persistent across sessions.
- Checkout process: address selection, shipping options, tax calculation, payment integration.
- Order management: order placement, status tracking, cancellation, returns.
- Inventory management: real-time stock updates, low-stock alerts.
- Recommendations: personalized product suggestions, “frequently bought together.”
- Reviews and ratings: user-generated content, moderation.
- Notifications: order confirmations, shipping updates, promotions.
- Admin dashboard: analytics, reporting, merchant tools.

### Non-Functional Requirements

- **Scalability:** Support 100M+ users, 10M+ daily active users, 1M+ daily orders.
- **Availability:** 99.99% uptime with multi-region redundancy.
- **Latency:** Page load < 2s, search results < 200ms, checkout < 3s.
- **Security:** PCI-DSS compliance, encrypted transactions, secure authentication.
- **Cost efficiency:** Auto-scaling, tiered storage, CDN caching for static assets.

**Assumptions & Constraints**

- Focus on B2C retail; no auction or wholesale models.
- Integrations with third-party payment gateways and shipping providers.
- No built-in warehouse management; inventory APIs provided by merchants.
- Use cloud-native services for scalability and resilience.

**Scale & Key Numbers (Example)**

- Registered users: 100M
- Daily active users: 10M
- Products in catalog: 50M
- Daily orders: 1M
- Peak order rate: 50,000 orders/minute
- Daily searches: 100M
- Average cart size: 3 items

## Design Considerations

The design must address catalog management, search, inventory, orders, checkout, fraud detection, caching, event-driven workflows, observability, and cost optimization.

**Architecture Overview**

Microservices-based architecture with clear separation of concerns:

- **Catalog Service** – product data
- **Search Service** – indexing and querying
- **Cart Service** – shopping cart management
- **Order Service** – order lifecycle
- **Inventory Service** – stock management
- **Payment Service** – transaction processing
- **Recommendation Service** – personalized suggestions
- **Notification Service** – alerts and emails

Event-driven communication via message broker (Kafka/Event Hub) for loose coupling.

**Catalog Management**

- Products stored in distributed SQL/NoSQL DB with JSON support for variants.
- Image assets stored in object storage with CDN delivery.
- Cache product details in Redis to reduce DB load.
- Support bulk imports and updates via async jobs.

**Search & Discovery**

- Elasticsearch/OpenSearch for full-text and faceted search.
- Real-time indexing via change data capture (CDC) or event streaming.
- Support autocomplete, typo tolerance, and relevance tuning.

**Inventory Management with Temporary Locking**

To prevent overselling during checkout, a temporary inventory reservation system is implemented.

**Reservation Flow:**

1.  When a user proceeds to checkout, the **Order Service** requests a temporary reservation from the **Inventory Service**.
2.  Inventory Service creates a reservation record with:
    - reservation_id (UUID)
    - product_id
    - quantity
    - expires_at (e.g., 10 minutes from now)
    - status (PENDING, CONFIRMED, RELEASED)
3.  The reserved quantity is deducted from available_quantity and added to reserved_quantity in the inventory table.
4.  The reservation is held for a configurable TTL (e.g., 10–15 minutes).

**Payment Success Scenario:**

1.  Payment Service confirms payment success → emits PaymentSucceeded event.
2.  Order Service consumes event, updates order status to PAID, and calls Inventory Service to confirm_reservation.
3.  Inventory Service moves reservation status to CONFIRMED, permanently deducts reserved_quantity from total stock.

**Payment Failure/Timeout Scenario:**

1.  If payment fails or times out, Payment Service emits PaymentFailed event.
2.  Order Service updates order status to FAILED and calls Inventory Service to release_reservation.
3.  Inventory Service releases the reserved quantity back to available_quantity and marks reservation as RELEASED.

**Expired Reservation:**

- A background cron job periodically scans for reservations where expires_at < NOW() and status is PENDING.
- These are automatically released, and the user sees an error if they attempt to complete payment after expiration.

**Handling Late Payments:**

- If a user pays after reservation expiry, the payment gateway webhook may still arrive.
- Order Service checks reservation status; if RELEASED or EXPIRED, it rejects the payment and initiates refund via Payment Service.
- A notification is sent to the user: “Item no longer reserved, payment refunded.”

**Idempotency & Retry Safety:**

- All reservation operations are idempotent using reservation_id.
- Event-driven orchestration ensures eventual consistency.

**Order Management**

- Order service orchestrates checkout, payment, and fulfillment.
- Event-driven state machine for order status (placed, paid, shipped, etc.).
- Idempotent APIs to handle duplicate requests.

**Checkout & Payments**

- Streamlined multi-step checkout (address → shipping → payment → review).
- Integration with payment gateways (Stripe, PayPal) with idempotency.
- Secure tokenization for card data; no raw PCI data stored.

**Fraud Detection**

- Real-time scoring of transactions using ML models (user behavior, IP, velocity).
- Rule-based checks (geolocation, BIN, amount thresholds).
- Async review queue for suspicious orders.

**Caching Strategy**

- CDN for static assets (product images, CSS/JS).
- Redis for product details, user sessions, cart data.
- Cache warming for hot products and categories.

**Event-Driven Flows**

- OrderPlaced → update inventory, send confirmation, trigger fraud check.
- PaymentSucceeded → update order status, initiate fulfillment.
- InventoryLow → alert merchant, adjust recommendations.

**Observability**

- Centralized logging (ELK stack) and metrics (Prometheus/Grafana).
- Distributed tracing (Jaeger/Zipkin) for request flow analysis.
- Real-time dashboards for business and operational metrics.

**Cost Efficiency**

- Auto-scaling based on load (CPU, queue depth).
- Tiered storage (hot/warm/cold) for product images and logs.
- Spot instances for batch jobs (analytics, recommendations).

## High-Level Architecture (Components & Flow)

\[Client\] → \[CDN\] → \[API Gateway\] → \[Microservices\]

│

├── Catalog Service → DB + Cache

├── Search Service → Elasticsearch

├── Cart Service → Redis

├── Order Service → DB + Event Hub

├── Inventory Service → DB + Event Sourcing

├── Payment Service → External Gateways

└── Recommendation Service → ML Models + Cache

Events flow via Kafka/Event Hub to downstream services (Notifications, Analytics, Fraud).

## Database Design

**Catalog Service**

**Products Table** | Column | Type | Nullable | Description | |---------------|--------------|----------|--------------------------------------| | id | UUID | No | Primary key | | name | VARCHAR(255) | No | Product name | | description | TEXT | Yes | Detailed description | | category_id | BIGINT | No | Foreign key to categories | | price | DECIMAL(10,2)| No | Unit price | | currency | CHAR(3) | No | Currency code (USD, EUR) | | variants | JSONB | Yes | SKU/variant data | | images | JSONB | Yes | Array of image URLs | | merchant_id | BIGINT | No | Seller ID | | is_active | BOOLEAN | No | Whether product is live | | created_at | TIMESTAMP | No | Creation timestamp | | updated_at | TIMESTAMP | No | Last update timestamp |

**Indexes:**

- idx_category_id (category_id)
- idx_merchant_id (merchant_id)
- idx_price_range (price, currency)

**Inventory Service**

**Inventory Table** | Column | Type | Nullable | Description | |------------------|-----------|----------|--------------------------------------| | product_id | UUID | No | Foreign key to products | | warehouse_id | BIGINT | No | Warehouse location | | available_qty | INTEGER | No | Available stock | | reserved_qty | INTEGER | No | Temporarily reserved stock | | last_updated | TIMESTAMP | No | Last stock update |

**Reservations Table** | Column | Type | Nullable | Description | |----------------|-----------|----------|--------------------------------------| | reservation_id | UUID | No | Primary key | | product_id | UUID | No | Reserved product | | order_id | UUID | No | Associated order | | quantity | INTEGER | No | Reserved quantity | | expires_at | TIMESTAMP | No | Reservation expiry | | status | VARCHAR | No | PENDING/CONFIRMED/RELEASED/EXPIRED | | created_at | TIMESTAMP | No | Creation time |

**Indexes:**

- idx_reservation_product (product_id, status)
- idx_reservation_expiry (expires_at) WHERE status = 'PENDING'

**Order Service**

**Orders Table** | Column | Type | Nullable | Description | |------------------|--------------|----------|--------------------------------------| | order_id | UUID | No | Primary key | | user_id | BIGINT | No | Customer ID | | status | VARCHAR(32) | No | PLACED/PAID/SHIPPED/CANCELLED | | total_amount | DECIMAL(12,2)| No | Order total | | currency | CHAR(3) | No | Currency code | | shipping_address | JSONB | No | Delivery address | | payment_method | VARCHAR(64) | No | Credit card, PayPal, etc. | | created_at | TIMESTAMP | No | Order creation time | | updated_at | TIMESTAMP | No | Last status update |

**Order Items Table** | Column | Type | Nullable | Description | |-------------|--------------|----------|--------------------------------------| | order_id | UUID | No | Foreign key to orders | | product_id | UUID | No | Product ID | | quantity | INTEGER | No | Quantity ordered | | unit_price | DECIMAL(10,2)| No | Price at time of order | | subtotal | DECIMAL(12,2)| No | quantity \* unit_price |

**Indexes:**

- idx_order_user (user_id, created_at DESC)
- idx_order_status (status, created_at)

**Cart Service**

**Carts Table** | Column | Type | Nullable | Description | |-------------|-----------|----------|--------------------------------------| | user_id | BIGINT | No | User ID | | cart_id | UUID | No | Cart identifier | | items | JSONB | No | \[{product_id, quantity, price}\] | | expires_at | TIMESTAMP | No | Cart expiration (e.g., 7 days) | | created_at | TIMESTAMP | No | Creation time | | updated_at | TIMESTAMP | No | Last update time |

**Primary Key:** (user_id, cart_id)

## API Design (RESTful)

**Catalog Service**

**Get Product Details**

**GET** /v1/products/{productId}  
**Response Body:**

{

"id": "prod-123",

"name": "Wireless Headphones",

"price": 99.99,

"currency": "USD",

"variants": \[\],

"images": \["https://cdn.example.com/img1.jpg"\]

}

**Status Codes:**

- 200 OK – Product found and returned
- 404 Not Found – Product does not exist
- 500 Internal Server Error – Server error

**Search Products**

**GET** /v1/products?q=headphones&category=electronics&page=1&size=20  
**Response Body:**

{

"items": \[\],

"total": 150,

"page": 1,

"size": 20

}

**Status Codes:**

- 200 OK – Results returned
- 400 Bad Request – Invalid query parameters
- 500 Internal Server Error – Search backend failure

**Cart Service**

**Add Item to Cart**

**POST** /v1/carts/{cartId}/items  
**Request Body:**

{

"productId": "prod-123",

"quantity": 2

}

**Status Codes:**

- 201 Created – Item added successfully
- 400 Bad Request – Invalid quantity or product
- 404 Not Found – Cart or product not found
- 409 Conflict – Inventory insufficient
- 500 Internal Server Error – Server error

**Remove Item from Cart**

**DELETE** /v1/carts/{cartId}/items/{itemId}  
**Status Codes:**

- 204 No Content – Item removed
- 404 Not Found – Cart or item not found
- 500 Internal Server Error – Server error

**Order Service**

**Create Order (Checkout)**

**POST** /v1/orders  
**Request Body:**

{

"cartId": "cart-123",

"shippingAddress": {},

"paymentMethod": "credit_card"

}

**Response Body:**

{

"orderId": "order-456",

"status": "PLACED",

"reservationId": "res-789",

"expiresAt": "2025-12-31T23:59:59Z"

}

**Status Codes:**

- 201 Created – Order created, inventory reserved
- 400 Bad Request – Invalid cart or address
- 409 Conflict – Inventory conflict or cart empty
- 422 Unprocessable Entity – Reservation failed
- 500 Internal Server Error – Server error

**Get Order Status**

**GET** /v1/orders/{orderId}  
**Status Codes:**

- 200 OK – Order details returned
- 404 Not Found – Order not found
- 500 Internal Server Error – Server error

**Cancel Order**

**PATCH** /v1/orders/{orderId}/cancel  
**Status Codes:**

- 200 OK – Order cancelled, inventory released
- 404 Not Found – Order not found
- 409 Conflict – Order cannot be cancelled (e.g., already shipped)
- 500 Internal Server Error – Server error

**Inventory Service**

**Reserve Inventory**

**POST** /v1/inventory/reserve  
**Request Body:**

{

"productId": "prod-123",

"quantity": 2,

"orderId": "order-456",

"ttlMinutes": 10

}

**Response Body:**

{

"reservationId": "res-789",

"expiresAt": "2025-12-31T23:59:59Z"

}

**Status Codes:**

- 201 Created – Inventory reserved
- 400 Bad Request – Invalid quantity or TTL
- 409 Conflict – Insufficient stock
- 500 Internal Server Error – Server error

**Confirm Reservation**

**POST** /v1/inventory/reservations/{reservationId}/confirm  
**Status Codes:**

- 200 OK – Reservation confirmed, stock deducted
- 404 Not Found – Reservation not found
- 409 Conflict – Reservation already confirmed or expired
- 500 Internal Server Error – Server error

**Release Reservation**

**POST** /v1/inventory/reservations/{reservationId}/release  
**Status Codes:**

- 200 OK – Reservation released, stock returned
- 404 Not Found – Reservation not found
- 409 Conflict – Reservation already released
- 500 Internal Server Error – Server error

**Payment Service**

**Process Payment**

**POST** /v1/payments  
**Request Body:**

{

"orderId": "order-456",

"amount": 199.98,

"currency": "USD",

"paymentMethod": {

"type": "credit_card",

"token": "tok_abc123"

}

}

**Response Body:**

{

"paymentId": "pay-123",

"status": "SUCCEEDED",

"processedAt": "2025-12-31T12:00:00Z"

}

**Status Codes:**

- 201 Created – Payment processed successfully
- 400 Bad Request – Invalid payment data
- 402 Payment Required – Payment failed (insufficient funds, declined)
- 404 Not Found – Order not found
- 409 Conflict – Payment already processed
- 500 Internal Server Error – Payment gateway error

**Get Payment Status**

**GET** /v1/payments/{paymentId}  
**Status Codes:**

- 200 OK – Payment status returned
- 404 Not Found – Payment not found
- 500 Internal Server Error – Server error

# Chapter 29 — **Hotel Booking System**

A hotel booking system is essential because managing room availability, reservations, pricing, and guest preferences manually becomes inefficient and error-prone as demand grows. Hotels operate with constantly changing inventory, varying rates, and multiple sales channels, making real-time coordination impossible without automation. A booking system centralizes all reservations, ensures accurate availability, prevents overbooking, streamlines check-ins and check-outs, and supports secure online payments. It also improves customer experience by offering instant search, comparison, and confirmation of rooms. Without such a system, hotels struggle to maintain operational accuracy, maximize occupancy, and deliver a seamless booking experience to guests.

## Overview

This document describes a high-level system design for a hotel booking platform (Airbnb/hotel-booking/Booking.com style) that supports multi-room types, multiple bed types, seasonal pricing, availability per-night, reservations with TTL-based holds, channel-manager integration, payment handling, and scale that varies by season. It follows the same structure as our other system design docs and is intended to be interview-ready.

**Goals**

- Enable guests to search, compare, reserve, and pay for hotel rooms with per-night availability and dynamic pricing.
- Support property owners/hotels to manage inventory (individual rooms or room pools), rate plans (seasonal pricing), bed configuration, and channel integrations (OTAs).
- Maintain strong availability guarantees (no double-booking), fair reservation holds, and resilient payment/settlement flows.
- Scale elastically to handle season-driven spikes (e.g., summer/winter holiday peaks).

**Terminology**

- **Property/Hotel:** A location with rooms and amenities.
- **Room Type:** Category (Basic, Deluxe, Premium), possibly with flexible bed configurations.
- **Room Unit:** A physical room instance (room_id) when property manages individual rooms.
- **Bed Type:** Single, double, king — room types may support multiple bed configurations.
- **Rate Plan:** Price rules for date ranges (seasonal rates, weekend rules, promotions).
- **Inventory:** Available rooms for a given date range.
- **Reservation/Hold:** Short-term hold on room(s) while guest completes booking.

## Requirements

### Functional Requirements

- Browse/search hotels by location + date range + filters (room type, beds, price, amenities).
- Show availability per-night and display rate breakdown including seasonal surcharges.
- Support different room types and bed configurations (single/double/king) and flexible room options.
- Reserve (hold) room(s) for a short TTL during checkout; finalize on payment.
- Support various rate plans (seasonal prices, weekend/weekday, promotions) and per-night pricing.
- Channel manager & OTA integration: ingest external bookings and publish availability to channels.
- Payment capture, refund, cancellations, invoices, and payout to properties.
- Admin/host dashboard for inventory, rates, calendar, and reporting.

### Non-Functional Requirements

- **Availability:** Critical booking path must be highly available during peak season windows.
- **Consistency:** Strong consistency for per-night availability to avoid double-booking.
- **Latency:** Search responses within ~300ms; reservation operation under 1s where possible.
- **Scalability:** Scale elastically based on season (ability to tolerate 5-10x baseline load during peak).
- **Observability:** Metrics and tracing for search, reservation holds, payment success/failure.

**Additional Requirements**

1.  Different room types like Basic, Deluxe, Premium — each may have flexible bed configurations.
2.  Different bed types: single, double, king; must be searchable and selectable.
3.  Price changes by season (summer/winter) and normal days; seasonal pricing must be supported by Rate Plans.
4.  Load increases during seasonal times — scalability must depend on season and rate plan traffic.

**Constraints & Assumptions**

- Properties may manage inventory as per-room units (explicit room IDs) or as aggregated room counts per room-type per date.
- Use third-party payment processors for PCI compliance.
- Channel partners (OTAs) require push/pull availability sync and booking acknowledgements quickly.
- Most heavy load occurs during seasonal windows; system should pre-warm and scale for known events.

**Scale & Capacity Considerations**

- **Baseline:** Assume 100k searches/day and 10k bookings/day.
- **Seasonal peak:** 1M+ searches/day, 100k bookings/day (10x increase).
- **Peak concurrency:** High demand for hotels near events with many concurrent holds.
- **Average stay:** 3-14 nights per booking.

## Design Considerations

**Architecture Overview**

Microservices-based architecture with clear separation:

- **Property Service** – hotel/room metadata
- **Inventory Service** – per-night availability
- **Rate Service** – dynamic pricing and rate plans
- **Search Service** – fast querying with filters
- **Reservation Service** – booking holds and confirmations
- **Payment Service** – transaction processing
- **Channel Manager Service** – OTA integration
- **Notification Service** – email/SMS/push alerts

Event-driven communication via Kafka/Event Hub for eventual consistency where appropriate.

**Property & Room Management**

- Each property has multiple room types (Basic, Deluxe, Premium).
- Room types support multiple bed configurations via mapping table.
- Room units can be managed individually or as pooled inventory.
- Amenities and policies stored as JSON for flexibility.

**Availability & Rate Management**

**Inventory Management:**

- Daily inventory records for each room type/property.
- Two models:
    1.  **Pooled inventory:** Total count per room type per date.
    2.  **Unit inventory:** Specific room IDs with status (available, occupied, maintenance).
- Strong consistency required for inventory updates to prevent overbooking.

**Rate Plans:**

- Seasonal pricing with date ranges, day-of-week adjustments, and promotions.
- Rate rules can be percentage-based or fixed amount.
- Rate calculation service computes final price per night.

**Search & Discovery**

- Elasticsearch/OpenSearch for geo, date, and filter-based queries.
- Pre-computed availability and pricing for faster search.
- Real-time inventory checks during search via cached availability.
- Support for complex filters: bed type, amenities, price range, rating.

**Reservation & Hold System**

**Hold Flow:**

1.  User selects dates → Search Service returns available room types with prices.
2.  User initiates booking → Reservation Service creates a temporary hold.
3.  **Hold creation:**
    - Inventory Service creates hold record with TTL (e.g., 15 minutes).
    - Deducts from available inventory (strong consistency).
    - Returns hold_id.
4.  Payment attempted within TTL:
    - Success → hold converted to confirmed booking.
    - Failure → hold released after retry logic.
5.  **Hold expiration:** Background job releases expired holds and restores inventory.

**Preventing Double Booking:**

- Optimistic locking with version stamps on inventory records.
- Distributed lock (Redis) per room-type/date during hold creation.
- Eventual consistency acceptable for search cache, but not for booking path.

**Checkout & Payments**

- Multi-step checkout: guest details → payment → confirmation.
- Integration with payment gateways (Stripe, Braintree) with idempotency.
- Support for pre-authorization (hold on card) and capture on check-in.
- Automatic cancellation and refund based on property policy.

**Channel Manager Integration**

- Two-way sync with OTAs (Booking.com, Expedia) via APIs.
- **Push:** Availability and rate updates to channels.
- **Pull:** Ingest external bookings and update local inventory.
- Webhook endpoints for real-time updates from partners.
- Conflict resolution: last-write-wins with manual override option.

**Caching Strategy**

- **CDN:** Property images, static assets.
- **Redis:**
    - Search results with date-range keys.
    - Property and room-type metadata.
    - Active holds and rate plans.
- **Cache warming:** Pre-load inventory for high-demand dates/events.

**Event-Driven Flows**

- HoldCreated → update search cache, send reminder notification.
- PaymentSucceeded → confirm booking, update inventory, emit BookingConfirmed.
- HoldExpired → release inventory, notify user.
- ExternalBookingReceived → reduce inventory, create local booking record.

**Observability**

- Centralized logging with structured JSON logs.
- Metrics: search latency, hold success rate, payment failure rate, inventory accuracy.
- Distributed tracing across booking flow.
- Real-time dashboards for business and operational KPIs.

**Cost Efficiency**

- Auto-scaling based on search QPS and booking rate.
- Tiered storage: hot for current/future dates, cold for past bookings.
- Spot instances for batch jobs (reporting, data sync).
- Intelligent caching to reduce DB load during peaks.

## High-Level Architecture (Components & Flow)

\[User/OTA\] → \[API Gateway\] → \[Microservices\]

│

├── Search Service → Elasticsearch + Cache

├── Property Service → DB

├── Inventory Service → DB (strong consistency)

├── Rate Service → DB + Cache

├── Reservation Service → DB + Event Hub

├── Payment Service → External Gateways

├── Channel Manager → OTA APIs

└── Notification Service → Email/SMS/Push

Events flow via Kafka/Event Hub for async processing (analytics, notifications, cache updates).

## Database Design

**Property Service**

**Properties Table** | Column | Type | Nullable | Description | |----------------|---------------|----------|--------------------------------------| | id | UUID | No | Primary key | | name | VARCHAR(255) | No | Property name | | address | JSONB | No | Full address + geo coordinates | | amenities | JSONB | Yes | \[wifi, pool, breakfast\] | | policies | JSONB | Yes | Cancellation, check-in/out times | | is_active | BOOLEAN | No | Whether property is listed | | created_at | TIMESTAMP | No | Creation time | | updated_at | TIMESTAMP | No | Last update |

**Room Types Table** | Column | Type | Nullable | Description | |----------------|---------------|----------|--------------------------------------| | id | UUID | No | Primary key | | property_id | UUID | No | Foreign key to properties | | name | VARCHAR(100) | No | Basic, Deluxe, Premium | | description | TEXT | Yes | Room description | | max_guests | INTEGER | No | Maximum occupancy | | base_price | DECIMAL(10,2) | No | Default nightly rate | | bed_configs | JSONB | No | Available bed types and counts | | created_at | TIMESTAMP | No | Creation time |

**Bed Configurations Table** | Column | Type | Nullable | Description | |----------------|---------------|----------|--------------------------------------| | id | UUID | No | Primary key | | room_type_id | UUID | No | Foreign key to room_types | | bed_type | VARCHAR(50) | No | single, double, king | | count | INTEGER | No | Number of beds of this type |

**Inventory Service**

**Daily Inventory Table** | Column | Type | Nullable | Description | |----------------|---------------|----------|--------------------------------------| | property_id | UUID | No | Property ID | | room_type_id | UUID | No | Room type ID | | date | DATE | No | Calendar date | | total_units | INTEGER | No | Total units available | | booked_units | INTEGER | No | Currently booked units | | held_units | INTEGER | No | Temporarily held units | | version | BIGINT | No | Optimistic lock version | | updated_at | TIMESTAMP | No | Last update | **Primary Key:** (property_id, room_type_id, date)

**Holds Table** | Column | Type | Nullable | Description | |----------------|---------------|----------|--------------------------------------| | hold_id | UUID | No | Primary key | | property_id | UUID | No | Property ID | | room_type_id | UUID | No | Room type ID | | start_date | DATE | No | Start date of stay | | end_date | DATE | No | End date (exclusive) | | quantity | INTEGER | No | Number of rooms held | | guest_id | BIGINT | Yes | Guest user ID | | session_id | VARCHAR(255) | Yes | Anonymous session ID | | expires_at | TIMESTAMP | No | Hold expiration time | | status | VARCHAR(20) | No | ACTIVE, CONFIRMED, EXPIRED, RELEASED | | created_at | TIMESTAMP | No | Creation time |

**Rate Service**

**Rate Plans Table** | Column | Type | Nullable | Description | |----------------|---------------|----------|--------------------------------------| | id | UUID | No | Primary key | | property_id | UUID | No | Property ID | | room_type_id | UUID | Yes | Specific room type or NULL for all | | name | VARCHAR(100) | No | Summer Special, Weekend Rate | | start_date | DATE | No | Plan start date | | end_date | DATE | No | Plan end date | | price_adjustment| JSONB | No | {type: percent/fixed, value: 10} | | day_of_week | INTEGER\[\] | Yes | \[1,2,3\] for Mon,Tue,Wed | | is_active | BOOLEAN | No | Whether plan is active | | created_at | TIMESTAMP | No | Creation time |

**Reservation Service**

**Bookings Table** | Column | Type | Nullable | Description | |----------------|---------------|----------|--------------------------------------| | booking_id | UUID | No | Primary key | | property_id | UUID | No | Property ID | | room_type_id | UUID | No | Room type ID | | guest_id | BIGINT | No | Guest user ID | | start_date | DATE | No | Check-in date | | end_date | DATE | No | Check-out date | | quantity | INTEGER | No | Number of rooms | | total_amount | DECIMAL(12,2) | No | Total booking cost | | currency | CHAR(3) | No | Currency code | | status | VARCHAR(20) | No | CONFIRMED, CANCELLED, CHECKED_IN | | payment_id | UUID | Yes | Foreign key to payments | | created_at | TIMESTAMP | No | Creation time | | updated_at | TIMESTAMP | No | Last status update |

**Channel Manager Service**

**Channel Mappings Table** | Column | Type | Nullable | Description | |----------------|---------------|----------|--------------------------------------| | id | UUID | No | Primary key | | property_id | UUID | No | Property ID | | channel_name | VARCHAR(100) | No | booking.com, expedia, etc. | | external_id | VARCHAR(255) | No | Property ID on channel | | sync_enabled | BOOLEAN | No | Whether to sync with this channel | | last_sync | TIMESTAMP | Yes | Last successful sync | | config | JSONB | Yes | Channel-specific configuration |

## API Design (RESTful)

**Search Service**

**Search Properties**

**GET** /v1/search?location=NYC&checkin=2025-12-20&checkout=2025-12-25&adults=2&roomType=Deluxe&bedType=king&minPrice=100&maxPrice=500  
**Response Body:**

{

"results": \[

{

"propertyId": "prop-123",

"name": "Grand Hotel",

"availableRoomTypes": \[

{

"roomTypeId": "room-456",

"name": "Deluxe King",

"bedConfig": \[{"type": "king", "count": 1}\],

"nightlyRate": 199.99,

"total": 999.95,

"availableUnits": 5

}

\]

}

\],

"total": 150,

"page": 1,

"size": 20

}

**Status Codes:**

- 200 OK – Results returned successfully
- 400 Bad Request – Invalid parameters (e.g., invalid dates)
- 500 Internal Server Error – Search backend failure
- 503 Service Unavailable – Search index temporarily unavailable

**Reservation Service**

**Create Hold**

**POST** /v1/holds  
**Request Body:**

{

"propertyId": "prop-123",

"roomTypeId": "room-456",

"startDate": "2025-12-20",

"endDate": "2025-12-25",

"quantity": 1,

"guestId": 789,

"sessionId": "sess-abc"

}

**Response Body:**

{

"holdId": "hold-789",

"expiresAt": "2025-12-19T15:30:00Z",

"totalAmount": 999.95,

"currency": "USD"

}

**Status Codes:**

- 201 Created – Hold created successfully
- 400 Bad Request – Invalid date range or quantity
- 409 Conflict – Insufficient availability
- 422 Unprocessable Entity – Rate calculation failed
- 500 Internal Server Error – Server error

**Confirm Booking**

**POST** /v1/bookings  
**Request Body:**

{

"holdId": "hold-789",

"paymentMethod": {

"type": "credit_card",

"token": "tok_xyz"

},

"guestDetails": {

"firstName": "John",

"lastName": "Doe",

"email": "john@example.com"

}

}

**Response Body:**

{

"bookingId": "book-123",

"status": "CONFIRMED",

"confirmationNumber": "GH-2025-123456",

"totalCharged": 999.95,

"checkinInstructions": "Check-in after 3 PM"

}

**Status Codes:**

- 201 Created – Booking confirmed successfully
- 400 Bad Request – Invalid hold or guest details
- 404 Not Found – Hold does not exist
- 409 Conflict – Hold expired or already used
- 402 Payment Required – Payment failed
- 500 Internal Server Error – Server error

**Cancel Booking**

**POST** /v1/bookings/{bookingId}/cancel  
**Request Body:**

{

"reason": "change of plans",

"refundPreference": "original_method"

}

**Response Body:**

{

"cancellationId": "cancel-456",

"refundAmount": 899.95,

"refundEstimateDays": 5-10

}

**Status Codes:**

- 200 OK – Cancellation processed
- 404 Not Found – Booking not found
- 409 Conflict – Booking cannot be cancelled (e.g., past check-in)
- 500 Internal Server Error – Server error

**Inventory Service**

**Get Availability**

**GET** /v1/inventory/{propertyId}/{roomTypeId}?startDate=2025-12-20&endDate=2025-12-25  
**Response Body:**

{

"propertyId": "prop-123",

"roomTypeId": "room-456",

"availability": \[

{"date": "2025-12-20", "available": 5, "holds": 2},

{"date": "2025-12-21", "available": 4, "holds": 3}

\]

}

**Status Codes:**

- 200 OK – Availability returned
- 404 Not Found – Property or room type not found
- 500 Internal Server Error – Server error

**Update Inventory (Admin)**

**PUT** /v1/inventory/{propertyId}/{roomTypeId}  
**Request Body:**

{

"date": "2025-12-20",

"totalUnits": 10

}

**Status Codes:**

- 200 OK – Inventory updated
- 400 Bad Request – Invalid date or units
- 409 Conflict – Would cause overbooking
- 500 Internal Server Error – Server error

**Channel Manager Service**

**Push Availability to Channel**

**POST** /v1/channels/{channelName}/availability  
**Request Body:**

{

"propertyId": "prop-123",

"roomTypeId": "room-456",

"dates": \[

{"date": "2025-12-20", "available": 5, "rate": 199.99},

{"date": "2025-12-21", "available": 5, "rate": 199.99}

\]

}

**Status Codes:**

- 202 Accepted – Update queued for processing
- 400 Bad Request – Invalid data format
- 404 Not Found – Channel or property not found
- 429 Too Many Requests – Rate limit exceeded
- 500 Internal Server Error – Sync failure

**Ingest External Booking (Webhook)**

**POST** /v1/channels/webhook/{channelName}/booking  
**Headers:** X-Channel-Signature for verification  
**Status Codes:**

- 200 OK – Booking accepted
- 400 Bad Request – Invalid payload
- 401 Unauthorized – Invalid signature
- 409 Conflict – Inventory conflict
- 500 Internal Server Error – Processing failed

# Chapter 30 — **Taxi Hailing System**

**Overview**

This document describes a high-level system design for a taxi-hailing platform (MVP launched in a single metro city) that supports real-time matching between riders and drivers, frequent location updates, map tile views, and payments. The design addresses the expected scale, bottlenecks, component architecture, APIs, data models, failure handling, monitoring, and recommended next steps.

**Goals & Non-Goals**

- Goal: Reliable, low-latency ride requests and real-time location updates for riders and drivers at the estimated scale below.
- Goal: Accurate, near-real-time matching and resilient payment processing.
- Non-Goal: Building a custom mapping or payments stack — rely on third-party providers (map tiles, routing, payments).

**Estimated Scale (MVP, single metro)**

- Registered users: 10M
- Daily active users (DAU): 1M
- Active drivers per day: 200k
- Peak concurrent sessions (riders + drivers): ~150k
- Ride requests per day: 500k (≈ 6 requests/sec)
- Location updates: ~18 updates/sec (interpreted below as location update events per trip — see notes)
- Map tile views: 1M per hour (≈ 280/sec)
- Payment transactions per day: 100k (≈ 1.2 TPS)

Notes:

- Location updates are frequent per active trip (drivers/riders sending updates every 2–3s). The aggregate write load for location/position data and push notifications is heavy and latency-sensitive.

**Key Bottlenecks & Challenges**

1.  Real-time location ingestion and propagation:
    - High write rate for frequent location updates.
    - Low-latency propagation to the rider and to the matching engine and monitoring dashboards.
2.  Matching (nearest-driver search):
    - Must search available drivers quickly and accurately (geo queries, capacity to scale by zone).
    - Avoid race conditions (two riders matched to same driver) and minimize latency.
3.  Push & realtime channels:
    - Maintain WebSocket/Push connections to many mobile clients.
    - Scale gateway layer and manage backpressure.
4.  Third-party dependencies:
    - Maps API: rate limits and latency for routing/tiles.
    - Payment gateway: retries, idempotency, and failure handling.
5.  Platform-wide scale issues:
    - Consistency across services (eventual consistency vs. strong where needed).
    - Cost management — balancing reserved capacity vs. autoscaling.
6.  Operational complexity:
    - Monitoring the health of real-time streams, SLOs for end-to-end latency.

**High-Level Architecture**

Components (logical):

- Mobile Apps (Rider / Driver)
- Edge/API Gateway (HTTPS + WebSocket termination)
- Auth Service (OAuth/JWT)
- Location Ingest Service (websocket/tcp/HTTP ingest)
- Presence Service (tracks online/available driver state)
- Matching Service (geo-index + match policies)
- Trip Service (creates and stores trips / lifecycle)
- Driver Service (driver profile, status, docs)
- Rider Service (profile, payment methods)
- Payment Service (integrates with 3rd-party payment gateway)
- Notification Service (push, SMS, in-app)
- Maps Adapter (caching + proxy for map tiles & routing)
- Event Bus (Kafka / Pulsar for async events)
- Analytics / Metrics Pipeline (streaming & batch)
- Data Stores: Redis (geo/ephemeral), Postgres (primary relational), Timeseries or Cassandra (telemetry/locations), S3 (logs, trip receipts)
- Websocket / Real-time Gateway (connection layer supporting push to clients)

Deployment patterns:

- Microservices per major capability; each stateless service autoscaled behind a load balancer.
- Use region/city partitions — in the MVP a single metro cluster. When multi-city, partition matching and location shards by city or geo-zone.
- Use Kubernetes or a managed container service to orchestrate containers and autoscaling policies.

**Data Flow / Interaction Patterns**

1.  Ride Request Flow (happy path):
    - Rider taps “Request Ride” → App calls POST /rides with pick-up/drop-off/time & payment token.
    - API Gateway → Auth validation → Rider Service → Trip Service creates a PENDING trip and publishes trip.requested to Kafka.
    - Matching Service consumes trip.requested, queries Presence/Location stores for nearest available drivers, scores candidates, and proposes driver via driver.push channel.
    - Driver receives match; driver accepts → Driver Service updates state → Trip Service moves to ASSIGNED and notifies rider and driver.
    - Driver navigation & trip start → Trip Service IN_PROGRESS; location updates flow to Location Ingest and are proxied to rider app.
    - Trip end → Trip Service COMPLETED; Payment Service charges rider (or marks for capture) and issues receipts.
2.  Location Updates:
    - Driver/Client sends frequent location updates (every 2–3s) over websocket or UDP->TLS ingest.
    - Location Ingest validates, writes to an ephemeral store (Redis geo index + a time-limited cache) and publishes change events to Kafka for downstream consumers (matching, UI push, analytics).
    - For in-trip users, gateway pushes location updates to subscribed clients (rider sees driver live). For other riders/drivers, the update may be throttled or sampled.
3.  Map Tile & Routing Views:
    - Mobile app requests tiles or route polylines. Maps Adapter proxies to the third-party provider and caches responses in CDN and local tile cache (Redis or CDN edge). Use cache headers aggressively.
4.  Payment Flow:
    - Payment requests go to Payment Service which calls external payment gateway with idempotency keys. Use async receipts and webhooks to reconcile.

**APIs (examples)**

- POST /v1/rides — Request a ride (body: rider_id, pickup, dropoff, payment_method_id, options)
- GET /v1/rides/{id} — Get ride status
- POST /v1/drivers/{id}/status — Update driver availability/state
- WS /v1/realtime — WebSocket endpoint for location updates, match offers, trip events
- POST /v1/payments/charge — Request payment capture (idempotent)

Communication patterns:

- Synchronous: APIs for requests/reads and WebSocket for real-time push.
- Asynchronous: Kafka event bus for trip.\*, location.\*, payment.\* events (used for decoupling and reliability).

**Data Models (simplified)**

- Rider: {id, name, phone, default_payment_id, rating, created_at}
- Driver: {id, name, vehicle_id, status: \[ONLINE, OFFLINE, BUSY\], location_last_seen, rating}
- Trip: {id, rider_id, driver_id, pickup, dropoff, fare_estimate, status: \[PENDING, ASSIGNED, IN_PROGRESS, COMPLETED, CANCELLED\], timestamps}
- LocationEvent: {entity_type (driver|rider), entity_id, lat, lon, heading, speed, ts}

**Storage Choices & Patterns**

- Redis (sharded): ephemeral geo-index for nearest-driver queries and presence, with key TTL for stale driver detection.
- Postgres (vertical scaling or partitioned): authoritative storage for profiles, payment tokens, and trip records.
- Kafka: event log for decoupled workflows and at-least-once delivery; use compacted topics for entity state.
- Timeseries DB / Cassandra: store high-volume telemetry and location history for analytics and playback.
- S3: store receipts, logs, trip artifacts, and backup exports.

**Matching Design Details**

- Use a two-stage approach: 1) Candidate discovery using a geo-index (Redis Geo or in-memory geohash shards) to pull nearest N drivers in a zone. 2) Scoring & filtering using in-memory scoring service (latency, ETA, driver acceptance rate, surge multiplier, vehicle type).
- Partition matching by zone/city to scale horizontally; each partition runs independent matchers and is responsible for consistency within its shard.
- Use optimistic locking / ephemeral driver reservations (short TTL) to avoid double-assignment. On assignment, update driver state atomically (driver state persisted and published).

**Real-Time & Connection Handling**

- Use persistent WebSocket (or MQTT) gateway clustered and fronted by LB. Gateways are sticky for connections.
- Gateway forwards messages to backend via a local message broker or direct gRPC to Location Ingest service.
- Backpressure handling: drop or downsample non-essential updates (e.g., map pings outside active trips) and use adaptive sampling on network congestion.

**Handling Third-Party Limits (Maps, Payments)**

- Caching: aggressive caching for tiles and routing, TTLs per provider limits; use CDN edges for tile hits.
- Circuit breakers & fallback: degrade gracefully (e.g., approximate route or ETA when routing provider slow), queue payments and reconcile with retries.
- Cost controls: rate-limiting map tile requests per user/session, pre-fetch tiles near the user instead of repeated requests.

**Consistency, Transactions, and Idempotency**

- Use idempotency keys for payment and critical operations.
- For ride assignment, aim for strong-per-trip consistency within a shard; use short-lived reservations in Redis and a single-source-of-truth Trip Service commit.
- For cross-service state, rely on eventual consistency and reconciliation jobs to fix drift (e.g., a driver says ONLINE but BLE heartbeat missing).

**Failure Modes and Mitigations**

- Lost connection (driver or rider disconnects): mark presence stale after TTL, fallback to SMS/push for critical updates.
- Double assignment: use reservation TTLs + atomic driver state update; reconcile via compensating actions and notify affected parties.
- Map provider outage: switch to alternate provider or degrade with cached tiles; provide best-effort ETA.
- Payment declines: mark trip PAYMENT_FAILED, allow alternative payment or manual settlement; retry with exponential backoff.

**Monitoring, Observability, and SLOs**

- Key metrics:
    - End-to-end match latency (request → driver assigned)
    - Location ingest p50/p95/p99 latency
    - WebSocket connection counts and disconnects
    - Payment success rate and retry rate
    - Error rates per service and per endpoint
- SLOs (examples):
    - 99% of ride request responses under 300ms (API layer)
    - 99% of location updates processed under 200ms
    - Payment success 99.9% (excluding card declines)
- Tools: Prometheus + Grafana + tracing (Jaeger) + ELK for logs + Kafka lag monitoring.

**Scaling Strategies and Cost Trade-offs**

- Shard by geo (city/zone) for matching and location ingestion to achieve horizontal scale.
- Use a mix of in-memory (Redis) for low-latency ephemeral state and durable DBs for persistent record-keeping.
- Autoscale matchers and websocket gateways during peak hours, but use scheduled scaling for known peaks to reduce cost.
- Use cheaper storage for historical telemetry (cold storage) and retain hot telemetry only for necessary period.

Trade-offs:

- Strong consistency for assignment vs. throughput: choose strong consistency for assignment within a shard and eventual consistency across shards.
- Push frequency vs. bandwidth/cost: lower update frequency reduces cost but harms UX; use adaptive frequency based on relevance (in-trip vs. idle).

**Security & Privacy**

- Authentication via JWT with short expiry for mobile sessions.
- Use tokenization for payment details and PCI-compliant flows delegated to payment provider.
- Protect location data and PII in transit (TLS) and at rest (encryption). Access control for internal services.

**Operational Playbooks (short)**

- Driver surge detection: if matching latency increases and acceptance drops, increase candidate radius and open surge pricing.
- Outage of map provider: redirect to secondary provider and notify ops; throttle non-critical map calls.

# Chapter 31 — **Collaborative Document Editor**

**Overview**

This document describes a high-level design for a web-based collaborative document editor (Google Docs style) that enables multiple users to edit the same document in real time with low latency, correct conflict-resolution, versioning, and access control. The design covers functional and non-functional requirements, scale estimates, architectural components, data models, synchronization strategy (OT vs CRDT), storage and partitioning, failure modes, monitoring, and next steps.

**Goals & Non-Goals**

- Goal: Provide sub-100ms real-time synchronization for active collaborators and seamless reconnection and autosave.
- Goal: Support large scale: millions of documents and millions of active users with billions of edit events per day.
- Non-Goal (MVP): No heavy media (large images/video embeds) or complex layout engines — MVP focuses on text and basic rich-text formatting.

**Functional Requirements (MVP)**

- Create, edit, delete documents.
- Real-time multi-user collaboration with visible live cursors and selection.
- Real-time syncing of edits (character/operation level) across all connected clients.
- Conflict-free collaboration using a robust conflict resolution algorithm (OT or CRDT).
- Document versioning, history, and ability to revert to previous versions.
- Access control and sharing (link/email invites) with role-based permissions (view/comment/edit).
- Autosave and crash recovery.

**Non-Functional Requirements**

- Performance: end-to-end propagation under 100ms for active collaborators.
- Scalability: support millions of documents and 10M+ daily active users.
- Availability: 99.9% uptime and graceful reconnection.
- Security: TLS, authenticated/authorized access, audit logs.
- Reliability: no lost edits; support eventual consistency and converge to identical state across clients.
- Testability: ability to simulate high-frequency edit workloads (10B events/day target).

**Assumptions & Constraints**

- Modern browsers with WebSocket support.
- Most documents are text-heavy and small (≈100KB) in MVP.
- Typical collaboration groups: 2–50 active collaborators (hotspots may have 100s).
- System must handle frequent small writes (ops/sec) and periodic bulk reads (open document, history snapshot).

**Scale Estimates (provided)**

- DAU: 10M
- Peak concurrent editors: 200k+
- Edit events: ~10 billion events/day (avg 1–2 events/sec per active user; hotspots 5–20 ops/sec per document)
- Average document size: ~100KB; history and versioning overhead 2–5x

These drive design choices for in-memory processing, partitioning, durable storage, and event pipeline provisioning.

**Key Challenges & Bottlenecks**

1.  Concurrency control and conflict resolution (OT/CRDT) — CPU & memory intensive for hotspots.
2.  WebSocket scaling and fan-out — large number of persistent connections and high fanout for popular docs.
3.  Event throughput & storage — write-heavy streams with many small operations and versioning overhead.
4.  Hotspot documents — uneven traffic and imbalance across partitions.
5.  Offline edits and merge/reconciliation on reconnection.

**High-Level Architecture**

Components:

- Client (Web): Editor UI, local op buffer, optimistic local execution, awareness (cursor/selection).
- Edge / API Gateway: terminates WebSockets and HTTP; authenticates users.
- Collaboration Gateway / Sync Service (stateful per-document session): receives ops, transforms/merges, sequences ops, and broadcasts to clients.
- CRDT/OT Engine: algorithm library used by client and server for transforming or merging operations.
- Session Store / In-memory Document State: per-active-document in-memory state (sharded across servers).
- Durable Storage (Document Store): append-only operation log + snapshot store (S3/Postgres/Cassandra) for persistence and history.
- Presence / Awareness Service: live cursors, connected users.
- Authz Service: permissions, invites, sharing.
- Event Bus (Kafka): durable ordered event stream for async processing, analytics, background compaction.
- Offline Sync / Reconciliation Worker: applies buffered ops from reconnecting clients and resolves conflicts.
- Search & Indexing: document search and text indexing (Elasticsearch).

Deployment patterns:

- Shard by document ID (hash) for assignment to a collaboration node. Hot documents can be autoscaled or routed to special high-capacity nodes.
- Use sticky session routing for WebSocket connections so the same collaboration node handles the same client while active.

**Synchronization Strategy: OT vs CRDT**

- Operational Transformation (OT):
    - Centralized sequencer (server) assigns global order and performs transform against concurrent operations.
    - Pros: lower metadata overhead per operation; proven in Google Docs.
    - Cons: server must run transformation logic and maintain ordering — harder to scale horizontally for conflict resolution CPU.
- Conflict-free Replicated Data Types (CRDT):
    - Decentralized approach; clients can merge operations without a central sequencer; each op contains metadata to ensure converge.
    - Pros: better for offline edits and easier eventual consistency; good for distributed systems.
    - Cons: larger metadata overhead (per-character IDs), more storage and memory overhead for high-frequency edits.

Design choice (MVP recommendation): start with a hybrid—use a server-side sequencer + OT-like transform for active editing sessions (low metadata overhead, low client complexity). Evaluate CRDT for offline-first or multi-region replication later.

**Document Session Lifecycle**

1.  Client opens document → WebSocket connection to Edge Gateway → routed to Collaboration Node for doc shard.
2.  Collaboration Node loads latest snapshot + op-log tail into memory; assigns local sequence number.
3.  Client sends local ops (user typing) to node; node applies algorithm (OT/merge), persists op to local append-only log and publishes to Kafka, and broadcasts transformed ops to connected clients.
4.  Periodically (or on low activity), snapshot the in-memory state to durable storage (S3/DB) and compact the op-log.

**Data Model & Storage**

- Operation: {op_id, user_id, doc_id, base_seq, payload, ts, metadata}
- Snapshot: {doc_id, snapshot_id, content_blob, base_seq, ts}
- Document metadata: {doc_id, owner, permissions, created_at, last_modified}

Storage strategy:

- Append-only op-log in durable store (Kafka for streaming + compacted topic or durable DB for replay).
- Periodic snapshots stored in object storage (S3) plus compacted state in a DB for quick fetch.
- Index text periodically into search engine for full-text search.

**Partitioning & Hotspot Handling**

- Hash-doc sharding maps doc_id to collaboration nodes. Each node keeps in-memory state for assigned docs.
- Hotspot mitigation:
    - Auto-detect heavy docs (ops/sec) and migrate to a pool of high-capacity nodes.
    - Use read-only replicas for heavy read traffic (viewers) while writes stay on primary node.
    - Rate-limit non-critical operations (e.g., presence updates) for large audiences.

**WebSocket & Fan-out**

- Use a horizontally-scaled WebSocket gateway with sticky sessions.
- For broadcast to many clients, use the collaboration node to push via gateway; if scale is very large, offload fanout to a publish/subscribe messaging layer (e.g., Redis Streams or a push gateway).
- Batching ops: Aggregate small ops into micro-batches to reduce network overhead while keeping perceived latency under 100ms.

**Offline & Reconnection**

- Clients buffer local ops while offline and obtain a new base_seq on reconnect; collaboration node replays and transforms buffered ops and returns merged state.
- For CRDTs, merge is simpler; for OT, server transforms buffered client ops against ops that occurred while offline.

**Consistency and Convergence Guarantees**

- Ensure strong per-document session ordering for active editing; eventual convergence guaranteed by OT transforms or CRDT merge rules.
- Provide deterministic tie-breaking for simultaneous edits (e.g., per-user priority or timestamps) only where algorithm requires it.

**Versioning & History**

- Maintain append-only op-log; derive versions by snapshotting at timepoints and keeping deltas.
- Provide history UI that can reconstruct document at given sequence number or timestamp by replaying snapshot + ops.

**APIs (examples)**

- POST /v1/docs — Create document
- GET /v1/docs/{doc_id} — Fetch latest snapshot and metadata
- WS /v1/docs/{doc_id}/realtime — WebSocket for bidirectional ops & awareness
- GET /v1/docs/{doc_id}/history?from_seq=&to_seq= — Fetch op deltas or version history
- POST /v1/docs/{doc_id}/share — Invite collaborators / set permissions

**Operational Concerns & Monitoring**

- Metrics:
    - Ops/sec per document and per node
    - Op apply latency (ingest → broadcast)
    - Snapshot latency and storage throughput
    - WebSocket connection counts, disconnects, reconnection rates
    - Kafka lag for op-log replication
- SLO examples:
    - 99% of ops applied and broadcast within 100ms
    - 99.9% uptime for collaboration node cluster
- Tools: Prometheus + Grafana for metrics, Jaeger for tracing, ELK for logs, Kafka monitoring.

**Security & Privacy**

- TLS for all client-server traffic; authentication (OAuth/JWT) and per-doc authorization checks.
- Audit logs for edits, shares and permission changes.
- Rate-limiting and abuse detection (detect bots or automated high-volume edits).

**Failure Modes & Mitigations**

- Node crash: reconnect clients to another node, replay op-log from durable store and resume session. Use graceful handoff when possible.
- Kafka or event store outages: buffer ops in memory with bounded size and disallow new sessions when safety threshold exceeded.
- Split-brain in multi-region: prefer single-writable region per doc or use CRDT with careful merge policies.

**Trade-offs**

- OT (centralized sequencing) reduces metadata overhead and eases snapshotting but requires a strong central sequencer and can be CPU-heavy.
- CRDT enables easier multi-region/offline but increases metadata/storage costs and operational complexity for compaction.

# Chapter 32 — **Parking Lot System**

A parking lot system is essential because managing vehicle entry, exit, availability, and payments becomes increasingly complex as traffic density grows. Manual tracking leads to inefficiencies such as long queues, miscounted spaces, revenue leakage, and poor customer experience. A parking lot system automates these operations—monitoring space occupancy, guiding drivers to available spots, enforcing parking rules, and streamlining payments—while providing operators with real-time insights and analytics. By reducing congestion, improving turnaround time, and ensuring accurate billing, the system enhances both operational efficiency and user satisfaction. Without such a system, large or busy parking facilities struggle to operate smoothly, especially during peak hours.

## Overview

This document presents a high-level design for a modern parking-lot management system (covers parking garages, surface lots, and reserved spots). The system supports real-time occupancy tracking, reservation and payment flows, entry/exit gate control, license-plate recognition (LPR) integrations, and analytics for utilization and pricing.

**Goals & Non-Goals**

- Goal: Provide accurate, near-real-time occupancy and reservation guarantees for customers and operators.
- Goal: Reliable gate control and integrated payments with support for transient and reserved parking.
- Non-Goal: Replace city-wide traffic or mapping systems — focus is the parking domain and its integrations.

**Typical Scale & Assumptions**

- Single deployment (city-level parking operator / medium-sized garage operator): 100–1,000 spots per site.
- Concurrent in-lot devices (sensors/gates/cameras): 10–100 per site.
- Reservation volume (initial): 1k–10k reservations/day across many sites.
- Peak entry/exit transactions: 50–200/sec across all sites for a medium operator.
- Telemetry (sensor heartbeats): up to 1–10 messages/sec per device when active.

Design note: scale figures are adjustable — architect to partition per site and use multi-tenant orchestration for many lots.

**Key Requirements**

- Functional: real-time spot occupancy, allow reservations (ad-hoc and advance), support entry/exit gates, payments, and reporting.
- Non-functional: high availability (garage operations should remain safe), low-latency for gate decisions, secure payment flows, and auditability.

**Primary Components**

- Mobile/Web Frontend (customers + operators)
- Edge/API Gateway (REST + WebSocket)
- Auth Service (user/operator auth)
- Reservation Service (creates/validates reservations)
- Availability Service (real-time occupancy and spot map)
- Device Gateway (IoT bridge for sensors, gates, cameras)
- Camera/LPR Service (processes images for license-plate recognition)
- Gate Controller Service (issues commands to gates/barriers)
- Payment Service (3rd-party integration)
- Billing & Invoicing Service
- Event Bus (Kafka/Rabbit) for async processing
- Data Stores: Postgres (core transactional), Redis (ephemeral occupancy cache), Time-series DB (sensor telemetry), Object store (images, receipts)
- Analytics & Monitoring stack

Deployment patterns:

- Each parking site runs a local edge gateway (optional) that aggregates device telemetry and caches occupancy state, and connects to central services for control and accounting.

**Core Flows**

1) Vehicle Entry (no reservation):

- Vehicle approaches gate. Camera captures plate or sensor detects vehicle.
- Device Gateway forwards event to Camera/LPR Service. LPR result → check for active reservation or pre-authorized account.
- If allowed, Gate Controller sends OPEN command; Availability Service marks spot(s) as occupied after spot allocation.
- Trip/Session started; billing session created.

2) Vehicle Entry (with reservation):

- Customer holds reservation token/QR or LPR entry matches reservation.
- Reservation Service validates reservation window and marks spot allocated; Gate open and session begins.

3) Reservation lifecycle:

- Customer requests POST /reservations (site_id, start_time, duration, vehicle_info).
- Reservation Service checks Availability Service for free spots (or allocates a virtual spot), temporarily holds spot (short TTL until payment confirmation), and returns confirmation.
- Payment Service charges or pre-authorizes; successful payment converts hold to confirmed reservation.

4) Exit & Billing:

- On exit, gate/camera triggers LPR and session end. Billing calculated (flat/variable/seasonal pricing) and charged if not prepaid. Receipt issued.

5) Sensor Telemetry & Heartbeats:

- Parking sensors (magnetic, ultrasonic), camera health pings, and gate controllers send periodic heartbeats to Device Gateway.
- Device Gateway validates and forwards telemetry to Time-series DB and Availability Service for state updates.

**APIs (examples)**

- POST /v1/reservations — Create reservation (body: user_id, site_id, start_time, duration, vehicle_plate, payment_method)
- GET /v1/sites/{site_id}/availability — Return current occupancy map and free spot count
- POST /v1/sites/{site_id}/devices/{device_id}/event — Device ingress endpoint for telemetry/events
- WS /v1/ops — WebSocket for real-time operator dashboard updates
- POST /v1/payments/charge — Charge outstanding balance (idempotent)

**Data Models (simplified)**

- Site: {id, name, address, capacity, zone_map}
- Spot: {id, site_id, level, number, type: \[REGULAR, EV, HANDICAP\], status: \[FREE, OCCUPIED, RESERVED\], last_seen}
- Reservation: {id, user_id, site_id, spot_id?, vehicle_plate, start_time, end_time, status: \[PENDING, CONFIRMED, EXPIRED, CANCELLED\], payment_status}
- Session: {id, reservation_id?, entry_ts, exit_ts, plate, spot_id, billed_amount}
- DeviceEvent: {device_id, site_id, type, payload, ts}

**Storage & Caching**

- Postgres (ACID) for reservations, sessions, user accounts, and audit logs.
- Redis for hot occupancy cache keyed by site_id and spot_id, used by APIs and gate decision logic.
- Time-series DB (InfluxDB/ClickHouse/Cassandra) for sensor telemetry and analytics.
- Object store (S3) for LPR images, video clips, and receipts.

**Real-time & Edge Considerations**

- Local Edge Gateway: perform local decisions (open gate, accept vehicle) even if central connection is degraded, using cached rules and short-lived tokens.
- Decision latency: gate/open decisions must complete within 100–300ms in many deployments to keep traffic flowing.

**Reservation & Allocation Strategy**

- Soft vs hard allocation:
    - On reservation request: perform soft-hold (allocate logical slot) and require payment to confirm (convert to hard-hold).
    - Soft hold TTL prevents deadlocks; a background reconciler releases expired holds.
- Overbooking mitigation: allow operational buffers (reserve a percentage of spots for walk-ins) and dynamic release windows.

**Integrations (LPR, Payments, Sensors)**

- LPR: integrate with vendor LPR engine or run local ML models. Use edge preprocessing to reduce bandwidth and send only plate and confidence score upstream.
- Payments: use PCI-compliant payment provider; use idempotency keys and webhooks for reconciliation.
- Sensors: IoT devices connect via MQTT/HTTPS to Device Gateway. Implement device authentication and OTA updates where possible.

**Failure Modes & Mitigations**

- Device failure: detect via heartbeats; mark related spots as UNKNOWN and route operator alerts; optionally close entrance to prevent misuse.
- Network partition: allow edge gateway to operate autonomously (local rules) and buffer events for later sync.
- Double allocation (race between reservation and physical entry): use atomic reservation commit in Postgres and short TTLs; reconcile via periodic audits.

**Monitoring, Alerting & SLOs**

- Key metrics: occupancy rate by site, reservation success rate, gate command latency, device health, payment success rate, reconciliation lag.
- Alerts: device offline > X minutes, gate command failures > threshold, payment gateway errors spike.
- SLO examples: 99% of gate open commands execute under 300ms; reservation confirmation within 2s for prepaid flow.

**Pricing, Dynamic Pricing & Policy**

- Support per-minute, flat, and dynamic pricing (event-based, peak pricing).
- Policy engine (central) publishes pricing configs to edge gateways and operator dashboards.

**Security & Privacy**

- Encrypt in transit (TLS) and at rest for sensitive data.
- Access controls for operator consoles; role-based permissions.
- LPR data is sensitive — define retention policy and redaction standards.

**Analytics & Reporting**

- Occupancy trends, revenue per site, peak hours, and device reliability dashboards.
- Exportable reports for operators and integrated billing feeds for accounting.

**Operational Playbooks**

- Device replacement: mark site degraded, route drivers to unaffected entrances, and schedule prompt hardware swap.
- Payment disputes: store full audit trail (LPR image + time + session) to help resolve disputes.

# Chapter 33 — Web Crawler System

A web crawler system is essential because the web is vast, dynamic, and constantly evolving, making manual discovery of content impossible at scale. Crawlers automatically navigate and gather data from billions of webpages, enabling systems such as search engines, content aggregators, SEO tools, and data analytics platforms to stay up-to-date with the latest information. By continuously scanning sites, detecting changes, extracting structured content, and following links across the web, crawlers ensure that the information ecosystem remains fresh, searchable, and reliable. Without a web crawler system, maintaining a comprehensive and current view of the internet would be unmanageable, severely limiting the usefulness and accuracy of modern online products and services.

## Overview

This document focuses on the web crawler subsystem: a distributed, polite, and scalable crawler that discovers and fetches web pages, extracts content and links, and feeds the indexing pipeline. The crawler must be bandwidth-efficient, respect robots.txt policies, deduplicate content, and support large-scale parallel fetching.

**Goals & Non-Goals**

- Goal: Efficiently discover and fetch public web pages at scale (seed → frontier → fetch → parse → emit).
- Goal: Respect robots.txt and site-specific politeness; support change detection and prioritized re-crawl scheduling.
- Non-Goal: Full browser rendering and heavy JS execution by default (optional renderers for specific sites can be added).

**Scale Targets & Assumptions (example MVP)**

- Target corpus: 100M pages
- Crawl window: complete initial crawl within ~7 days (~170 pages/sec aggregate)
- Concurrent fetchers: adjustable (hundreds to thousands depending on throughput & politeness)
- Bandwidth budget: plan per-site rate limiting and global bandwidth caps; typical page size 30–100KB after extraction

Design assumptions:

- Crawler will be polite (robots.txt), avoid login-protected pages, and handle content negotiation.

**High-Level Architecture**

- Seed Manager: initial seeds ingestion and priority seeds (sitemaps, known domains).
- URL Frontier: persistent, distributed queue with priority and per-domain rate controls; supports requeueing and dedup metadata.
- Fetcher Pool: worker fleet that performs HTTP fetches, conditional GETs, and hands content to parser.
- Robots Manager: centralized store/manager of robots.txt and crawl-delay policies per domain.
- Parser / Extractor: HTML parsing, link extraction, content cleaning, language detection, outlink normalization.
- Renderer (optional): headless browser workers (Puppeteer) for JS-heavy pages (used selectively due to cost).
- Dedup & Canonicalizer: content fingerprinting, canonical URL resolution, duplicate detection (hash + near-duplicate detection)
- Outlink Filter & Scheduler: URL normalization, filters (only http/https, allowed domains), push back to frontier with appropriate priority.
- Frontier Coordinator: partitioning strategy (domain-hash) and work assignment to fetchers.
- Storage: raw content store (S3/HDFS), parsed content store (for indexer), URL metadata DB, link graph emitter.
- Monitoring & Ops UI: crawler dashboard, domain health, crawl progress, error tracking.

**URL Frontier & Partitioning**

- Partition by domain-hash to ensure single domain's requests go through a single partition (enables easy politeness enforcement).
- Frontier data per domain: pending URL queue, last fetch timestamp, crawl-delay, failure counts.
- Priority strategy: use scoring (Page importance, site priority, freshness, change frequency, sitemap hints) to rank URLs for fetch.

**Politeness & Rate Limiting**

- Robots.txt parsing: fetch and cache robots.txt per host; support crawl-delay directives and allow/disallow rules.
- Domain-level rate limiters: token-bucket or leaky-bucket per host, per-IP where applicable.
- Host coalescing: group subdomains when appropriate to avoid overloading infrastructure.

**Fetcher Design**

- Fetcher responsibilities: resolve DNS, open connection, HTTP fetch, handle redirects, conditional requests (ETag/If-Modified-Since), retry/backoff, and TLS.
- Concurrency: per-fetcher connection pools with limits across domains.
- Error handling: classify errors (4xx, 5xx, timeouts) and set exponential backoff and backoff windows per domain.
- Retries & DLQ: retries limited per URL; after threshold, send to DLQ for manual review or further analysis.

**Parsing & Extraction**

- HTML parse: sanitize, extract visible text, title, meta tags, structured data (schema.org), microformats.
- Link extraction: canonicalize URLs, resolve relative links, extract anchor text.
- Language detection & charset handling.
- Content hashing: compute fingerprint (e.g., SHA256) and simhash/minhash for near-duplicate detection.

**Deduplication & Canonicalization**

- URL canonicalization: remove tracking params, normalize scheme/host, apply canonical link element if present.
- Exact dedup: compare content hashes and drop duplicates or map to canonical document.
- Near-duplicate detection: use simhash/minhash with locality-sensitive hashing to detect high-similarity pages.

**Scheduling & Recrawl Strategies**

- Freshness-driven scheduling: maintain per-URL priority based on last-modified, historical change frequency, and site importance.
- Adaptive recrawl: increase frequency for high-change sites (news sites), reduce for stable pages (archival content).
- Incremental crawl: use conditional GET; if content unchanged, update metadata and deprioritize.

**Link Graph & Outlink Emission**

- Emit outlinks to Link Graph Builder for PageRank and link analysis.
- Provide crawl-time signals (anchor text, link prominence) as features for ranking.

**Storage & Data Flow**

- Raw fetch store: compressed raw HTML stored in object store (S3/HDFS) for replay and reprocessing.
- Parsed content store: cleaned text, metadata, and content fingerprint written to indexer ingestion topic (Kafka) or persistent queue.
- URL metadata DB: tracks URL states (pending, fetched, failed, canonical_id), last_crawled_ts, response headers.

**JS Rendering Strategy**

- Use a small fleet of headless-renderer workers for important or JS-heavy pages.
- Selective rendering: decide to render based on heuristics (content-length, presence of JS frameworks, user agent detection), not by default due to cost.

**Bandwidth, Throughput & Cost Controls**

- Global bandwidth throttle: enforce global bandwidth cap and per-region caps.
- Differential scheduling: balance crawling across domains to avoid spikes; use per-domain polices for burst handling.

**Scalability Patterns**

- Scale fetchers horizontally and partition frontier by domain-hash to add more fetch capacity.
- Use autoscaling for parser and renderer clusters based on queue depths.
- Kafka-backed ingestion buffers to decouple fetchers from indexers.

**Monitoring & Observability**

- Key metrics: pages/sec fetched, bytes/sec, success/error rates, robots.txt misses, domain-level errors, queue depth, fetch latency distribution.
- Alerts: high error rate for a domain, frontier starvation/overgrowth, renderer queue length > threshold, DLQ spike.

**Failure Modes & Mitigations**

- External bans / 403s: detect and backoff; provide operator workflow to appeal/blocklist.
- Network partitions: buffer frontier state locally and resume when connectivity restored.
- Disk/Storage failures: replicate raw store writes and use checksums.

**Security & Compliance**

- Respect robots.txt and legal constraints; implement opt-out handling for sites that request removal.
- Identify crawler with clear User-Agent and contact information.

**Ops & Control APIs**

- POST /crawler/seed — add seed URLs
- POST /crawler/pause?domain=example.com — pause domain crawling
- GET /crawler/status — global crawler health and progress
- GET /crawler/domain/{domain} — domain-level stats and last-crawl info

# Chapter 34 — Search Engine System

A search engine is essential because the internet contains an overwhelming amount of unstructured information that no user could navigate manually. With billions of webpages, documents, and media files constantly being created, people need a fast, reliable way to locate relevant information within milliseconds. Search engines solve this by continuously crawling the web, organizing content into searchable indexes, ranking results by relevance and quality, filtering unsafe or spam content, and delivering personalized, trustworthy answers at massive scale. Without a search engine, discovering information online would be slow, inefficient, and practically impossible for most users and businesses.

## Overview

This document describes a large-scale web search engine (crawl-index-serve) that crawls, indexes and serves keyword queries against hundreds of millions (or billions) of web pages. It covers functional & non-functional requirements, scale estimates, crawler and indexer design, inverted/forward index architecture, query serving, ranking, freshness, storage, monitoring, failure handling, trade-offs and next steps.

**Goals & Non-Goals**

- Goal: crawl and index public web pages and serve keyword search queries with low latency (<200ms), high throughput, and reasonable freshness.
- Goal: support scalable indexing and ranking for tens-to-hundreds of millions of pages (MVP: 100M pages, ~1M QPS peak target configurable).
- Non-Goal: full web rendering (JS-heavy SPA rendering), deep personalization, or complex ML models in MVP (can be added later).

## Requirements

### Functional Requirements

- Crawl public pages, respect robots.txt, detect duplicates and canonical URLs.
- Parse pages, extract text, titles, metadata, and outlinks.
- Build and maintain inverted index and forward index for ranking and retrieval.
- Support keyword queries, basic boolean and phrase queries.
- Rank results using text relevance (TF-IDF/ BM25), link-based signals (PageRank), and freshness signals.
- Periodic re-crawl and re-index to keep content fresh.

### Non-Functional Requirements

- Latency: query response under 200ms (typical target under 100ms).
- Throughput: scale to thousands QPS (MVP target configurable to 1k–2k QPS; larger deployments scale horizontally).
- Freshness: re-index frequently changing pages within hours for hot content.
- Storage efficiency: store petabytes with compression, deduplication, and segment merging.
- Fault tolerance: avoid single points of failure and allow graceful degradation.

**Scale Estimates (MVP example)**

- Pages: 100M pages
- Avg processed page size (text): ~30–100KB
- Inverted index size: 0.5–1TB at 100M pages (approx; depends on compression)
- Forward index & stored fields: ~3–5TB
- Crawling throughput: ~170 pages/sec to finish 100M in a week (parallelized)
- Query load: 1k–2k QPS peak for MVP (can scale horizontally)

Notes: numbers are illustrative; production systems (Google/Bing) operate orders of magnitude larger and require additional optimizations.

**High-level Components**

- Crawler Fleet: distributed fetchers, URL frontier, politeness/rate limiting, dedupe & canonicalization.
- Parser/Renderer: extract text, metadata, outlinks; optional JS rendering workers for dynamic pages.
- Link Graph Builder: accumulate link edges and compute PageRank / link signals.
- Indexer: tokenization, normalization (stemming, stopwords), term statistics, and segment creation.
- Segment Store: write-once immutable inverted index segments (local disk/HDFS/S3-backed) and forward stores.
- Merge Service: background merging/compaction of segments and index optimization.
- Query Layer: distributed search nodes (shards) that load segments and serve query requests.
- Coordinator / Router: fan-out queries to shards, merge ranked results, apply final scoring.
- Cache Layer: query/result cache, document cache (hot docs), and CDN for static assets.
- Admin & Scheduler: crawl scheduling, re-crawl prioritization, freshness heuristics.
- Monitoring & Analytics: metrics, logs, tracing, and offline analytics pipeline.

**Crawl Design**

- URL Frontier: persistent, priority-based queue (domain sharding to ensure politeness and parallelism). Partition frontier by domain-hash to assign domain ranges to crawler workers.
- Politeness & Rate Limits: per-domain rate control, robots.txt parsing & respect, backoff on errors.
- Fetching: adaptive fetcher pool with retries, conditional GETs (ETag/If-Modified-Since) to reduce bandwidth.
- Deduplication: content hashing and canonical URL normalization to avoid duplicate indexing.
- Outlink Extraction: emit discovered URLs back into the frontier with domain-based partitioning.

**Indexing Pipeline**

1.  Parsing: HTML → cleaned text, tokenization, language detection, metadata.
2.  Token processing: lowercase, stemming/lemmatization, stop-word removal, n-grams as needed.
3.  Term statistics: compute term frequency, document frequency, field-specific weights (title/anchor/body).
4.  Segment creation: build inverted lists (posting lists) per shard/segment; write immutable segment files.
5.  Forward index & stored fields: store document metadata, URL, title, snippet fields, and compressed stored content (or pointer to raw storage).
6.  Merge/compaction: background merging of small segments into larger ones for query efficiency.

Storage notes:

- Use compressed posting lists (delta encoding + variable-byte / Golomb / PFor) and front-coding of lexicon.
- Store indices on fast disks or local SSDs in query-serving nodes; keep cold backups in object store (S3/HDFS).

**Sharding and Query Serving**

- Shard by document id (hash) or by domain-range. Each shard holds a subset of the inverted index and forward index.
- Query flow:
    - Router accepts query and fans out to all relevant shard replicas in parallel (scatter-gather).
    - Each shard executes local retrieval (term lookup, scoring), returns top-K local results.
    - Router merges results (global rerank, dedupe, snippets) and returns final top results to client.
- Replication: keep N replicas per shard for availability; use quorum reads if strong consistency required for updates.

**Ranking & Scoring**

- Base relevance: TF-IDF or BM25 with field boosts (title, anchor, URL path).
- Link signals: PageRank or other link-analysis metrics to capture authority.
- Freshness & recency features: boost recently updated pages for time-sensitive queries.
- Query-time features: click-through feedback, query intent signals (later iteration), runtime filters (language, country).
- Final rerank: combine offline model (learning-to-rank) with lightweight online features for the top results.

**Caching Strategy**

- Query Cache: store results for high-frequency queries (cache key = normalized query + params).
- Document Cache: keep hot documents / stored fields in memory to speed snippet generation.
- Posting Cache: hot term posting lists cached in memory or in an in-memory index (e.g., RocksDB, Redis).

**Freshness & Re-indexing**

- Scheduling: prioritise high-change sites and high-importance hosts for frequent crawling; use change-frequency heuristics.
- Incremental indexing: update per-document segments and apply incremental merges to avoid full reindex.
- Real-time updates: for high-value pages, support near-real-time indexing via small daily/continuous jobs.

**Query Latency Budget (example)**

- Parse & normalize query: ~<5ms
- Shard lookup & local scoring (parallel): ~20ms
- Merge & final ranking: ~30–50ms
- Snippet generation & response formatting: ~10ms
- Network + routing overhead: ~10–20ms Total target: under 200ms (optimise via caching and fast in-memory posting retrieval).

**Storage Options & Durability**

- Immutable on-disk segments stored locally on query nodes for low-latency reads; periodic snapshot + upload to object store (S3/HDFS) for durability.
- Forward store: columnar/wide-row DB (Cassandra/Bigtable) or compressed SSTables to map docID→stored fields.
- Raw page store: optionally keep raw HTML compressed in object storage for re-processing.

**Monitoring, Observability & SLOs**

- Metrics: QPS, query latency p50/p95/p99, crawl throughput, crawl error rates, index merge latency, disk usage, memory pressure, cache hit ratios.
- Alerts: shard unavailability, high merge backlog, consumer lag for pipeline, excessive crawler failures, index corruption detection.
- SLO examples: 99% of queries under 200ms; crawl processing pipeline throughput ≥ target; indexing job completion SLA for scheduled windows.

**Failure Modes & Mitigations**

- Crawler overload / bans: respect robots, expose backoff, and maintain retry windows; blacklist abusive domains.
- Segment corruption: verify checksums, maintain replicas, and rebuild from raw logs/segments.
- Query node failure: use replicas and load-balancer retry; graceful degradation (serve cached results) when insufficient replicas.
- Merge backlog: autoscale merge workers and prioritize hot segments; stall ingestion only when safe.

**Security & Compliance**

- Respect robots.txt and legal constraints; provide opt-out mechanisms and crawler identity.
- Secure internal APIs and control plane with TLS and authentication.
- Rate-limits and abuse detection to prevent scraping and attacks.

**Trade-offs**

- Freshness vs cost: more frequent crawling increases bandwidth and compute cost; tune recrawl frequency by importance.
- Latency vs completeness: caching and precomputed results lower latency but may serve slightly stale results.
- Complexity vs flexibility: more advanced ranking (ML models) improves relevance but increases serving complexity and latency.