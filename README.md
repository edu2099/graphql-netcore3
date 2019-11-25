# graphql-netcore3
.net core GraphQL example converted to .net core 3

For testing:

- Execute the update-database on PM (change connection string to your database)
- Execute the project
- Go to URL https://localhost:5001/ui/playground
- Start executing graphql queries, some samples:

query Test {
  q1: owners {
    ...ownerFields
  },
  q2: owners {
    name,
    address
  },
  q3: owner (id: "514c3bc3-14df-4515-bc13-256e75dd2e9f") {
    name
  },
  q4: accounts {
    ...accountFields
  }
}

fragment ownerFields on OwnerType {
    id
    name
    address
}

fragment accountFields on AccountType {
    id
  	accountType
  	description
  	owner {
      ...ownerFields
    }
}
