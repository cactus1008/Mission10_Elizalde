import type { Team } from "./team"

export type bowler = {
    bowlerId: number,
    bowlerLastName: string,
    bowlerFirstName: string,
    bowlerMiddleInit: string | null,
    bowlerAddress: string,
    bowlerCity: string,
    bowlerState: string,
    bowlerZip: number,
    bowlerPhoneNumber: number,
    teamID: number,
    team: Team
}